using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace RabbitAndSqs.Connections.Sqs
{
    public class SqsIncomingTransport<TModel> : IIncomingTransport<TModel>
    {
        /// <summary>
        /// SQS offers 'long polling' this means that the number of requests to SQS can be
        /// decreased. When requesting messages any available messages will be returned
        /// from the queue immediately. If the queue is empty, the connection will be
        /// open for WaitTimeSeconds. If a messages arrive during waiting, this message
        /// will be returned immediately.
        /// <para>
        /// This allows fast return of all available messages and avoids flooding SQS
        /// with requests against empty queues.
        /// </para>
        /// </summary>
        private const int WaitTimeSeconds = 20;

        /// <summary>
        /// Attributes must be explicitly requested. A list containing
        /// the attribute name 'All' returns all attributes. 
        /// </summary>
        private static readonly List<string> RequestedAttributes = new[] { "All" }.ToList();

        /// <summary>
        /// 10 messages in response for each request is the maximum allowed. 
        /// </summary>
        private const int MaximumMessagesPerRequest = 10;

        private readonly IAmazonSQS _sqsClient;
        private readonly string _queueUrl;
        private readonly IMessageFactory<TModel> _messageFactory;
        private readonly IAmazonS3 _s3;
        private readonly string _bucketName;

        /// <summary>
        /// Receive messages from SQS. 
        /// </summary>
        /// <param name="sqsClient">Client connecting to SQS.</param>
        /// <param name="queueUrl">Url of queue to receive messages from.</param>
        /// <param name="messageFactory">Deserialization logic</param>
        /// <param name="s3">S3 client. When message content exceeds the size limit, the payload will be stored in S3.</param>
        /// <param name="bucketName">Name of S3 bucket to use for spillover.</param>
        public SqsIncomingTransport(IAmazonSQS sqsClient, string queueUrl, IMessageFactory<TModel> messageFactory, IAmazonS3 s3, string bucketName)
        {
            _sqsClient = sqsClient;
            _queueUrl = queueUrl;
            _messageFactory = messageFactory;
            _bucketName = bucketName;
            _s3 = s3;
        }

        public async Task<IEnumerable<ISerializedMessage<TModel>>> ReceiveBatch(CancellationToken cancellationToken)
        {
            ReceiveMessageRequest request = new ReceiveMessageRequest(_queueUrl);
            request.MessageAttributeNames = RequestedAttributes;
            request.MaxNumberOfMessages = MaximumMessagesPerRequest;
            request.WaitTimeSeconds = WaitTimeSeconds;
            var response = await _sqsClient.ReceiveMessageAsync(request, cancellationToken);
            var result = new List<ISerializedMessage<TModel>>(MaximumMessagesPerRequest);
            foreach (var item in response.Messages)
            {
                var msg = await DoReceive(item);
                result.Add(msg);
            }

            await DeleteReceivedMessages(cancellationToken, response);
            return result;
        }

        /// <summary>
        /// Delete all received messages before returning result to caller.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        private Task DeleteReceivedMessages(CancellationToken cancellationToken, ReceiveMessageResponse response)
        {
            // Delete the received messages. 
            var deleteRequest = new DeleteMessageBatchRequest(_queueUrl, response.Messages.Select(x => new DeleteMessageBatchRequestEntry(x.MessageId, x.ReceiptHandle)).ToList());
            return _sqsClient.DeleteMessageBatchAsync(deleteRequest, cancellationToken);
        }

        private async Task<ISerializedMessage<TModel>> DoReceive(Message msg)
        {
            // Store all attributes in dictionary
            Dictionary<string, string> headerDictionary = new Dictionary<string, string>();
            // Except for json dictionary in attribute
            foreach (var simpleAttribute in msg.MessageAttributes.Where(x => x.Key != SqsOutgoingTransport<TModel>.JsonHeadersAttributeName))
            {
                headerDictionary[simpleAttribute.Key] = simpleAttribute.Value.StringValue;
            }

            var body = headerDictionary.TryGetValue(SqsOutgoingTransport<TModel>.SpilloverHeaderName, out var spillover)
                       && bool.Parse(spillover)
                ? await DownloadContentFromS3(msg.Body)
                : msg.Body;

            // This is an internal setting - we remove it before sending to the user.
            headerDictionary.Remove(SqsOutgoingTransport<TModel>.SpilloverHeaderName);

            // If the json dictionary is present
            if (msg.MessageAttributes.TryGetValue(SqsOutgoingTransport<TModel>.JsonHeadersAttributeName, out var value))
            {
                var jsonValuesHeaderContent = JsonConvert.DeserializeObject<Dictionary<string,string>>(value.StringValue);
                // Store each element from the json dictionary
                foreach (var kvp in jsonValuesHeaderContent)
                {
                    headerDictionary[kvp.Key] = kvp.Value;
                }
            }

            // Create model with the combined headers from jsonDictionary and other attributes. 
            return _messageFactory.CreateFrom(body, headerDictionary);
        }

        private async Task<string> DownloadContentFromS3(string msgBody)
        {
            var content = await _s3.GetObjectAsync(_bucketName, msgBody);
            using var reader = new StreamReader(content.ResponseStream);
            return await reader.ReadToEndAsync();
        }
    }
}