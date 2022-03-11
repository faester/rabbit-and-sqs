using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SQS.Model;
using FluentAssertions;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Connections.Messages;
using RabbitAndSqs.Connections.Sqs;
using Xunit;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public abstract class SqsOutgoingTransportTest<TModel>
    {
        private readonly SqsOutgoingTransport<TModel> _subject;
        private readonly SqsIncomingTransport<TModel> _receive;
        private readonly IMessageFactory<TModel> _messageFactory;
        private readonly AmazonSQSClient _client;
        private readonly AmazonS3Client _s3;
        private readonly string _queue;
        private readonly string _bucket;

        protected SqsOutgoingTransportTest()
        {
            _messageFactory = new XmlMessageFactory<TModel>(GetHeaderFunctions().ToArray());

            _client = new AmazonSQSClient(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
            _s3 = new AmazonS3Client(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
            _queue = TestConfiguration.GetValue("sqs_queue");
            _bucket = TestConfiguration.GetValue("s3_bucket");
            _subject = new SqsOutgoingTransport<TModel>(_client, _queue, _s3, _bucket);
            _receive = new SqsIncomingTransport<TModel>(_client,_queue, _messageFactory, _s3, _bucket);

            ClearQueue();
        }

        private void ClearQueue()
        {
            Task<ReceiveMessageResponse> messageResponse;
            do
            {
                messageResponse = _client.ReceiveMessageAsync(_queue);
                messageResponse.Wait();
                _client.DeleteMessageBatchAsync(_queue, messageResponse.Result.Messages.Select(x => new DeleteMessageBatchRequestEntry(x.MessageId, x.ReceiptHandle)).ToList());

            } while (messageResponse.Result.Messages.Any());
        }

        protected abstract IEnumerable<KeyValuePair<string, Func<TModel, string>>> GetHeaderFunctions();
        protected abstract TModel CreateModelInstance();


        [Fact]
        public async Task Send_ThenNoApparentException()
        {
            ISerializedMessage<TModel> messages = _messageFactory.CreateFrom(CreateModelInstance());
            await _subject.Send(messages);
        }

        [Fact]
        public async Task Send_ThenReceive()
        {
            ISerializedMessage<TModel> messages = _messageFactory.CreateFrom(CreateModelInstance());
            await _subject.Send(messages);

            var items = await _receive.ReceiveBatch(CancellationToken.None);
            items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task Send_ThenCanBeDeserialized()
        {
            var originalMessage = CreateModelInstance();
            ISerializedMessage<TModel> message = _messageFactory.CreateFrom(originalMessage);

            await _subject.Send(message);

            var response = await _receive.ReceiveBatch(CancellationToken.None);
            var first = response.Select(x => x.Deserialize()).Single();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }

        [Fact]
        public async Task Send_ThenReceiveSendItem()
        {
            var originalMessage = CreateModelInstance();
            ISerializedMessage<TModel> message = _messageFactory.CreateFrom(originalMessage);

            await _subject.Send(message);

            var items = await _receive.ReceiveBatch(CancellationToken.None);
            var first = items.Single().Deserialize();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }
    }
}