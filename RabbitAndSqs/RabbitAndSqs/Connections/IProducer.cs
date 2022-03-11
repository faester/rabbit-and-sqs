using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using RabbitAndSqs.Models;
using RabbitMQ.Client;

namespace RabbitAndSqs.Connections
{
    public interface IReceiver<TModel>
    {
        public Task<IEnumerable<TModel>> ReceiveBatch();
    }

    public interface IOutgoingTransport<TModel>
    {
        Task Send(ISerializedMessage<TModel> message);
    }

    class RabbitMqTransport<TModel> : IOutgoingTransport<TModel>
    {
        private string _queue;
        private string _username;
        private string _password;
        private string _hostname;

        public RabbitMqTransport(string queue, string username, string password, string hostname)
        {
            _queue = queue;
            _username = username;
            _password = password;
            _hostname = hostname;
        }

        public Task Send(ISerializedMessage<TModel> message)
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostname,
                UserName = _username,
                Password = _password
            };
            using var connection = factory.CreateConnection();
            
            using var channel = connection.CreateModel();
            var properties = channel.CreateBasicProperties();
            foreach (var kvp in message.Headers)
            {
                properties.Headers[kvp.Key] = kvp.Value;
            }


            var body = Encoding.UTF8.GetBytes(message.Content);

            channel.QueueDeclare(queue: _queue, durable: false, exclusive: false, autoDelete: false, arguments: null);

            channel.BasicPublish(exchange: "", routingKey: "ignore", basicProperties: properties, body: body);

            return Task.CompletedTask;
        }
    }

    public interface IIncomingTransport<TModel>
    {
        Task<IEnumerable<ISerializedMessage<TModel>>> ReceiveBatch(CancellationToken cancellationToken);
    }
}
