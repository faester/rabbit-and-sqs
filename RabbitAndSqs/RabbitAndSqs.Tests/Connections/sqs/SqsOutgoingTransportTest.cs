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
    public abstract class TransportTest<TModel>
    {
        private readonly IOutgoingTransport<TModel> _outgoingTransport;
        private readonly IIncomingTransport<TModel> _incomingTransport;
        protected readonly XmlMessageFactory<TModel> _messageFactory;


        public TransportTest()
        {
            _messageFactory = new XmlMessageFactory<TModel>(GetHeaderFunctions().ToArray());
            _incomingTransport = CreateIncomingTransport();
            _outgoingTransport = CreateOutgoingTransport();
        }

        protected abstract IIncomingTransport<TModel> CreateIncomingTransport();

        protected abstract IOutgoingTransport<TModel> CreateOutgoingTransport();

        protected abstract IEnumerable<KeyValuePair<string, Func<TModel, string>>> GetHeaderFunctions();

        protected abstract TModel CreateModelInstance();


        [Fact]
        public async Task Send_ThenNoApparentException()
        {
            var message = _messageFactory.CreateFrom(CreateModelInstance());
            await _outgoingTransport.Send(message);
        }

        [Fact]
        public async Task Send_ThenReceive()
        {
            var message = _messageFactory.CreateFrom(CreateModelInstance());
            await _outgoingTransport.Send(message);

            var items = await _incomingTransport.ReceiveBatch(CancellationToken.None);
            items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task Send_ThenCanBeDeserialized()
        {
            var originalMessage = CreateModelInstance();
            var message = _messageFactory.CreateFrom(originalMessage);

            await _outgoingTransport.Send(message);

            var response = await _incomingTransport.ReceiveBatch(CancellationToken.None);
            var first = response.Select(x => x.Deserialize()).Single();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }

        [Fact]
        public async Task Send_ThenReceiveSendItem()
        {
            var originalMessage = CreateModelInstance();
            var message = _messageFactory.CreateFrom(originalMessage);

            await _outgoingTransport.Send(message);

            var items = await _incomingTransport.ReceiveBatch(CancellationToken.None);
            var first = items.Single().Deserialize();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }
    }

    public abstract class SqsOutgoingTransportTest<TModel> : TransportTest<TModel>
    {
        private readonly AmazonSQSClient _client = new AmazonSQSClient(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
        private readonly AmazonS3Client _s3 = new AmazonS3Client(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
        private readonly string _queue = TestConfiguration.GetValue("sqs_queue");
        private readonly string _bucket = TestConfiguration.GetValue("s3_bucket");

        protected SqsOutgoingTransportTest()
        {
            ClearQueue();
        }

        protected override IIncomingTransport<TModel> CreateIncomingTransport()
        {
            return new SqsIncomingTransport<TModel>(_client, _queue, _messageFactory, _s3, _bucket);
        }

        protected override IOutgoingTransport<TModel> CreateOutgoingTransport()
        {
            return new SqsOutgoingTransport<TModel>(_client, _queue, _s3, _bucket);
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
    }
}