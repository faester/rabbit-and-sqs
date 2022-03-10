using System.Collections.Generic;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Connections.Messages
{
    public class AdsMlBookingsMessageFactory : IMessageFactory<AdsMLBookings>
    {
        private readonly IModelSerializer<AdsMLBookings> _serializer = new XmlSerializer<AdsMLBookings>();

        public AdsMlBookingsMessageFactory() { }

        public ISerializedMessage<AdsMLBookings> CreateFrom(string serializedModel, Dictionary<string, string> headerValues)
        {
            return new AdsMLBookingsMessage(_serializer.Deserialize(serializedModel), _serializer, headerValues);
        }

        public ISerializedMessage<AdsMLBookings> CreateFrom(AdsMLBookings model)
        {
            return new AdsMLBookingsMessage(model, _serializer);
        }
    }
}