using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Connections.Messages;
using Xunit;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public abstract class TransportTest<TModel>
    {
        protected readonly XmlMessageFactory<TModel> _messageFactory;
        public TransportTest()
        {
            _messageFactory = new XmlMessageFactory<TModel>(GetHeaderFunctions().ToArray());
        }

        protected abstract IIncomingTransport<TModel> CreateIncomingTransport();

        protected abstract IOutgoingTransport<TModel> CreateOutgoingTransport();

        protected abstract IEnumerable<KeyValuePair<string, Func<TModel, string>>> GetHeaderFunctions();

        protected abstract TModel CreateModelInstance();


        [Fact]
        public async Task Send_ThenNoApparentException()
        {
            var message = _messageFactory.CreateFrom(CreateModelInstance());
            await CreateOutgoingTransport().Send(message);
        }

        [Fact]
        public async Task Send_ThenReceive()
        {
            var message = _messageFactory.CreateFrom(CreateModelInstance());
            await CreateOutgoingTransport().Send(message);

            var items = await CreateIncomingTransport().ReceiveBatch(CancellationToken.None);
            items.Should().NotBeEmpty();
        }

        [Fact]
        public async Task Send_ThenCanBeDeserialized()
        {
            var originalMessage = CreateModelInstance();
            var message = _messageFactory.CreateFrom(originalMessage);

            await CreateOutgoingTransport().Send(message);

            var response = await CreateIncomingTransport().ReceiveBatch(CancellationToken.None);
            var first = response.Select(x => x.Deserialize()).Single();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }

        [Fact]
        public async Task Send_ThenReceiveSendItem()
        {
            var originalMessage = CreateModelInstance();
            var message = _messageFactory.CreateFrom(originalMessage);

            await CreateOutgoingTransport().Send(message);

            var items = await CreateIncomingTransport().ReceiveBatch(CancellationToken.None);
            var first = items.Single().Deserialize();
            first.Should().BeEquivalentTo(originalMessage, options => options.AllowingInfiniteRecursion());
        }
    }
}