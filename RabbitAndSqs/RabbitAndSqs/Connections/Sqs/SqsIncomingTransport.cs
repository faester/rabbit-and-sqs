﻿using System.Collections.Generic;
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
        /// 10 messages in response for each request is the maximum allowed. 
        /// </summary>
        private const int MaximumMessagesPerRequest = 10;
        private readonly IAmazonSQS _sqsClient;
        private readonly string _queueUrl;
        private readonly IMessageFactory<TModel> _messageFactory;
        private readonly IAmazonS3 _s3;
        private readonly string _bucketName;

        public SqsIncomingTransport(IAmazonSQS sqsClient, string queueUrl, IMessageFactory<TModel> messageFactory, string bucketName)
        {
            _sqsClient = sqsClient;
            _queueUrl = queueUrl;
            _messageFactory = messageFactory;
            _bucketName = bucketName;
        }

        public async Task Receive(IMessageReceiver<TModel> receiver, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                ReceiveMessageRequest request = new ReceiveMessageRequest(_queueUrl);
                request.MaxNumberOfMessages = MaximumMessagesPerRequest;
                request.WaitTimeSeconds = WaitTimeSeconds;
                var response = await _sqsClient.ReceiveMessageAsync(request, cancellationToken);
                response.Messages.ForEach(async msg => await DoReceive(msg, receiver));
            }
        }

        private async Task DoReceive(Message msg, IMessageReceiver<TModel> receiver)
        {
            // Store all attributes in dictionary
            Dictionary<string, string> headerDictionary = new Dictionary<string, string>();
            // Except for json dictionary in attribute
            foreach (var simpleAttribute in msg.MessageAttributes.Where(x => x.Key != SqsOutgoingTransport<TModel>.JsonHeadersAttributeName))
            {
                headerDictionary[simpleAttribute.Key] = simpleAttribute.Value.StringValue;
            }

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

            var body = headerDictionary.TryGetValue(SqsOutgoingTransport<TModel>.SpilloverHeaderName, out var spillover)
                       && bool.Parse(spillover)
                ? await DownloadContent(msg.Body)
                : msg.Body;

            // Create model with the combined headers from jsonDictionary and other attributes. 
            var model = _messageFactory.CreateFrom(body, headerDictionary);

            // Notify the receiver that we have received a message.
            await receiver.ReceiveMessage(model);
        }

        private async Task<string> DownloadContent(string msgBody)
        {
            var content = await _s3.GetObjectAsync(_bucketName, msgBody);
            using var reader = new StreamReader(content.ResponseStream);
            return await reader.ReadToEndAsync();
        }
    }
}