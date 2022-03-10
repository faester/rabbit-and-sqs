using System.Collections.Generic;

namespace RabbitAndSqs.Connections
{
    public interface IMessageFactory<TModel>
    {
        ISerializedMessage<TModel> CreateFrom(string serializedModel, Dictionary<string, string> headerValues);
    }

    public interface IModelSerializer<TModel>
    {
        string Serialize(TModel model);

        TModel Deserialize(string serializedModel);
    }
}