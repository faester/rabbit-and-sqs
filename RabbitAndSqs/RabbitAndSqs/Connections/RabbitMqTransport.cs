using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace RabbitAndSqs.Connections
{
    public class RabbitMqTransport<TModel> : IOutgoingTransport<TModel>, IIncomingTransport<TModel>
    {
        private readonly IMessageFactory<TModel> _messageFactory;

        private readonly string _queue;
        private readonly string _username;
        private readonly string _password;
        private readonly string _hostname;
        private readonly int _port;

        public RabbitMqTransport(string queue, string username, string password, string hostname, IMessageFactory<TModel> messageFactory, int port)
        {
            _queue = queue;
            _username = username;
            _password = password;
            _hostname = hostname;
            _messageFactory = messageFactory;
            _port = port;
        }

        public Task Send(ISerializedMessage<TModel> message)
        {
            using var connection = CreateConnection();

            using var channel = connection.CreateModel();
            var properties = channel.CreateBasicProperties();
            properties.Headers ??= new Dictionary<string, object>();
            foreach (var kvp in message.Headers)
            {
                properties.Headers[kvp.Key] = kvp.Value;
            }

            var body = Encoding.UTF8.GetBytes(message.Content);

            channel.QueueDeclare(queue: _queue, durable: false, exclusive: false, autoDelete: false, arguments: null);
            channel.ExchangeDeclare(exchange: _queue, durable: false, autoDelete:false, type: "fanout");

            channel.BasicPublish(exchange: _queue, routingKey: "ignore", basicProperties: properties, body: body);

            return Task.CompletedTask;
        }
        // lb.mq-dev.jppol.net:15672/#/
        // sb
        // sb
        private IConnection CreateConnection()
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostname,
                UserName = _username,
                Password = _password, 
                Port = _port,
                VirtualHost = "servicebus",
            };
            
            // Channel pool maxize
            // Prefetch global false
            // Prefetch 
            // Publisher acknowledgements true
            return factory.CreateConnection();
        }

        public Task<IEnumerable<ISerializedMessage<TModel>>> ReceiveBatch(CancellationToken cancellationToken)
        {
            using var connection = CreateConnection();
            using var channel = connection.CreateModel();
            var result = new List<ISerializedMessage<TModel>>();
            BasicGetResult lastReceived;
            int sizeLeft = 10;
            do
            {
                lastReceived = channel.BasicGet(_queue, true);
                if (lastReceived == null) { continue; }

                var message = _messageFactory.CreateFrom(Encoding.UTF8.GetString(lastReceived.Body.ToArray()), lastReceived.BasicProperties.Headers.ToDictionary(x => x.Key, x=> x.Value?.ToString()));
                result.Add(message);

            } while (lastReceived != null && sizeLeft-- > 0);

            return Task.FromResult((IEnumerable<ISerializedMessage<TModel>>)result);
        }
    }
}