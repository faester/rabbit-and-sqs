namespace RabbitAndSqs.Connections
{
    /// <summary>
    /// Serialization logic for creating and deserializing message payloads
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IModelSerializer<TModel>
    {
        string Serialize(TModel model);

        TModel Deserialize(string serializedModel);
    }
}