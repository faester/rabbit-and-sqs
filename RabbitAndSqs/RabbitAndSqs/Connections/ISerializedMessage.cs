using System.Collections.Generic;

namespace RabbitAndSqs.Connections
{
    public interface ISerializedMessage<TModel>
    {
        /// <summary>
        /// The header collection to send. 
        /// </summary>
        public Dictionary<string, string> Headers { get; }

        /// <summary>
        /// The serialized content applicable for sending using some 
        /// transport. 
        /// </summary>
        string Content { get; }

        /// <summary>
        /// Deserializes Content and initializes a new instance of the TModel class.
        /// </summary>
        /// <returns></returns>
        public TModel Deserialize();
    }
}