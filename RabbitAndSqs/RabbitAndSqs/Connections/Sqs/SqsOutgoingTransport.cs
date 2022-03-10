using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;

namespace RabbitAndSqs.Connections.Sqs
{
    public class SqsOutgoingTransport<TModel> : IOutgoingTransport<TModel>
    {
        /// <summary>
        /// Max sqs size - we leave plenty of room for headers
        /// </summary>
        public const int MaxContentSize = 262144 - 50000;
        public const string JsonHeadersAttributeName = "jsonHeaders";
        private static readonly IDictionary<string, object> EmptyDictionary = new Dictionary<string, object>();
        public const string SpilloverHeaderName = "IsLargeContent";

        /// <summary>
        /// We identify headers we want to be directly available here.
        /// <para>
        /// Other headers will be wrapped in a header named 'jsonObject' containing
        /// a json encoded dictionary. 
        /// </para>
        /// <para>
        /// This division ensures we don't exceed the maximum of 10
        /// header attributes on a message. 
        /// </para>
        /// </summary>
        private static readonly string[] RealHeaders = { "ServiceBusDescription", "ServiceBusBusinessId", "ServiceBusCustomField1", "ServiceBusCustomField2" };

        private readonly IAmazonSQS _sqsClient;
        private readonly IAmazonS3 _s3Client;
        private readonly string _spilloverBucketName;
        private readonly string _queueUrl;

        public SqsOutgoingTransport(IAmazonSQS sqsClient, string queueUrl, IAmazonS3 s3Client, string spilloverBucketName)
        {
            _sqsClient = sqsClient;
            _queueUrl = queueUrl;
            _s3Client = s3Client;
            _spilloverBucketName = spilloverBucketName;
        }

        private async Task<string> UploadToS3(string content)
        {
            await using var stream = new MemoryStream(Encoding.UTF8.GetBytes(content));
            var key = Guid.NewGuid().ToString();
            // Everything is cleaned up using bucket policy. So just upload and forget.
            await _s3Client.UploadObjectFromStreamAsync(_spilloverBucketName, key, stream, EmptyDictionary);
            return key;
        }


        /// <summary>
        /// Performs the real sending of messages. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task Send(ISerializedMessage<TModel> model)
        {
            bool needsSpillOver = model.Content.Length > MaxContentSize;

            var content = needsSpillOver
                ? await UploadToS3(model.Content)
                : model.Content;

            var sendMessageRequest = new SendMessageRequest(_queueUrl, content);
            var jsonHeaders = new Dictionary<string, string>();

            // Send all headers as part of the request. 
            foreach (var keyValuePair in model.Headers)
            {
                // Headers with names from our whitelist is 
                // added as string values. 
                if (RealHeaders.Contains(keyValuePair.Key))
                {
                    sendMessageRequest.MessageAttributes.Add(keyValuePair.Key,
                        new MessageAttributeValue
                        {
                            StringValue = keyValuePair.Value,
                            DataType = "String",
                        });
                }
                else
                {
                    // Other headers are stored in a dictionary 
                    jsonHeaders[keyValuePair.Key] = keyValuePair.Value;
                }
            }

            // 'other' headers are serialized and stored in a single attribute containing a json dictionary. 
            sendMessageRequest.MessageAttributes.Add(JsonHeadersAttributeName, new MessageAttributeValue
            {
                StringValue = JsonConvert.SerializeObject(jsonHeaders),
                DataType = "String",
            });

            sendMessageRequest.MessageAttributes.Add(SpilloverHeaderName, new MessageAttributeValue
            {
                StringValue = needsSpillOver.ToString(),
                DataType = "String", 
            });

            // Enqueue messages in sqs. 
            await _sqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}