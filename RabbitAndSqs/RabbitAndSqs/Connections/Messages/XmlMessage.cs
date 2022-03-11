using System;
using System.Collections.Generic;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Connections.Messages
{
    internal class Message<TModel> : AbsMessage<TModel>
    {
        public Message(string content, IModelSerializer<TModel> serializer, Dictionary<string, string> headerValues)
            : base(content, serializer, headerValues)
        {
        }
        public Message(TModel content, IModelSerializer<TModel> serializer, Dictionary<string, string> headerValues)
            : base(content, serializer, headerValues)
        {
        }
    }
}