using System.Collections.Generic;

namespace RabbitAndSqs.Connections.Messages
{
    public abstract class AbsMessage<TModel> : ISerializedMessage<TModel>
    {
        private readonly IModelSerializer<TModel> _serializer;
        public Dictionary<string, string> Headers { get; }
        public string Content { get; private set; }
        public TModel Deserialize()
        {
            return _serializer.Deserialize(Content);
        }

        protected AbsMessage(TModel content, IModelSerializer<TModel> serializer, Dictionary<string, string> headers)
        {
            _serializer = serializer;
            Headers = headers;
        }

        protected AbsMessage(TModel content, IModelSerializer<TModel> serializer)
        {
            _serializer = serializer;
            Headers = new Dictionary<string, string>();
            PrepareMessage(content);
        }

        private void PrepareMessage(TModel model)
        {
            Content = _serializer.Serialize(model);

            foreach (var kvp in GetHeaderValues(model))
            {
                Headers[kvp.Key] = kvp.Value;
            }
        }

        protected abstract IEnumerable<KeyValuePair<string,string>> GetHeaderValues(TModel model);
    }
}