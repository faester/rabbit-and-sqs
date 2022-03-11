using System.Collections.Generic;

namespace RabbitAndSqs.Connections
{
    public interface IMessageFactory<TModel>
    {
        ISerializedMessage<TModel> CreateFrom(string serializedModel, Dictionary<string, string> headerValues);

        TModel Deserialize(string payload);

        string Serialize(TModel model);
    }
}