using System;
using System.Collections.Generic;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Connections.Messages
{
    public class AdsMLBookingsMessage : AbsMessage<AdsMLBookings>
    {
        public AdsMLBookingsMessage(string content, IModelSerializer<AdsMLBookings> serializer, Dictionary<string, string> headerValues)
            : base(content, serializer, headerValues)
        {
        }
        public AdsMLBookingsMessage(AdsMLBookings content, IModelSerializer<AdsMLBookings> serializer)
            : base(content, serializer)
        {
        }

        protected override IEnumerable<KeyValuePair<string, string>> GetHeaderValues(AdsMLBookings model)
        {
            yield return new KeyValuePair<string, string>("ServiceBusBusinessId", model.AdOrder.BookingIdentifier);
            yield return new KeyValuePair<string, string>("ServiceBusDescription", model.AdOrder.Campaign.CodeValue.ToString());
        }
    }
}