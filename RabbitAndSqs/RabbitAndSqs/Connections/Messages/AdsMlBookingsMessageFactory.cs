using System;
using System.Collections.Generic;
using System.Linq;

namespace RabbitAndSqs.Connections.Messages
{
    public class XmlMessageFactory<TModel> : IMessageFactory<TModel>
    {
        private readonly KeyValuePair<string, Func<TModel, string>>[] _headerFunctions;
        private readonly IModelSerializer<TModel> _serializer = new XmlSerialization<TModel>();

        public XmlMessageFactory(params KeyValuePair<string,  Func<TModel, string>>[] headerFunctions)
        {
            _headerFunctions = headerFunctions;
        }

        public ISerializedMessage<TModel> CreateFrom(TModel model)
        {
            var headers = _headerFunctions.Select(x => new KeyValuePair<string, string>(x.Key, x.Value(model))).ToDictionary(x => x.Key, x => x.Value);
            return CreateFrom(Serialize(model), headers);
        }

        public ISerializedMessage<TModel> CreateFrom(string serializedModel, Dictionary<string, string> headerValues)
        {
            return new Message<TModel>(serializedModel, _serializer, headerValues);
        }

        public TModel Deserialize(string payload)
        {
            return _serializer.Deserialize(payload);
        }

        public string Serialize(TModel model)
        {
            return _serializer.Serialize(model);
        }
    }
}