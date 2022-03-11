using System.Collections.Generic;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Connections.Messages
{
    public class AdsMlBookingsMessageFactory : IMessageFactory<AdsMLBookings>
    {
        private readonly IModelSerializer<AdsMLBookings> _serializer = new XmlSerialization<AdsMLBookings>();

        public AdsMlBookingsMessageFactory() { }

        public ISerializedMessage<AdsMLBookings> CreateFrom(string serializedModel, Dictionary<string, string> headerValues)
        {
            return new AdsMLBookingsMessage(serializedModel, _serializer, headerValues);
        }

        public AdsMLBookings Deserialize(string payload)
        {
            return _serializer.Deserialize(payload);
        }

        public string Serialize(AdsMLBookings model)
        {
            return _serializer.Serialize(model);
        }
    }
}