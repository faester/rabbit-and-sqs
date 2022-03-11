using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.Runtime.Internal.Util;

namespace RabbitAndSqs.Connections.Messages
{
    internal abstract class AbsMessage<TModel> : ISerializedMessage<TModel>
    {
        private readonly IModelSerializer<TModel> _serializer;
        public Dictionary<string, string> Headers { get; }
        public string Content { get; private set; }
        public TModel Deserialize()
        {
            return _serializer.Deserialize(Content);
        }

        protected AbsMessage(string content, IModelSerializer<TModel> serializer, Dictionary<string, string> headers)
        {
            _serializer = serializer;
            Headers = headers;
            Content = content;
        }

        protected AbsMessage(TModel content, IModelSerializer<TModel> serializer, Dictionary<string, string> headers)
        {
            _serializer = serializer;
            Headers = new Dictionary<string, string>();
        }
    }
}