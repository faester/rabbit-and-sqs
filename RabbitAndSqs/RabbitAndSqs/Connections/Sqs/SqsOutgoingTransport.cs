using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;

namespace RabbitAndSqs.Connections.Sqs
{
    public class SqsOutgoingTransport<TModel> : IOutgoingTransport<TModel>
        
    {
        public const string JsonHeadersAttributeName = "jsonHeaders";

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
        private readonly string _queueUrl;

        public SqsOutgoingTransport(IAmazonSQS sqsClient, string queueUrl)
        {
            _sqsClient = sqsClient;
            _queueUrl = queueUrl;
        }

        /// <summary>
        /// Performs the real sending of messages. 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task Send(ISerializedMessage<TModel> model)
        {
            var sendMessageRequest = new SendMessageRequest(_queueUrl, model.Content);
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
                            StringValue = keyValuePair.Value
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
            });

            // Enqueue messages in sqs. 
            return _sqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}