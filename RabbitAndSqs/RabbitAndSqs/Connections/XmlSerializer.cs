using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace RabbitAndSqs.Connections
{
    /// <summary>
    /// XML serializer for various models. 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    class XmlSerializer<TModel> : IModelSerializer<TModel>
    {
        private static readonly Encoding Encoding = Encoding.UTF8;
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(TModel));

        public string Serialize(TModel model)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream, Encoding))
            {
                _serializer.Serialize(streamWriter, model);
            }

            return Encoding.GetString(memoryStream.ToArray());
        }

        public TModel Deserialize(string serializedModel)
        {
            using var memoryStream = new MemoryStream(Encoding.GetByteCount(serializedModel));
            using var streamWriter = new StreamReader(memoryStream);
            return (TModel)_serializer.Deserialize(memoryStream);
        }
    }
}