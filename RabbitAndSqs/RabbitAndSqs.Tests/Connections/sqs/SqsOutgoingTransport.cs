using System;
using System.Collections.Generic;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public class SqsAdsMLBookingsTest : SqsOutgoingTransportTest<AdsMLBookings>
    {
        protected override IEnumerable<KeyValuePair<string, Func<AdsMLBookings, string>>> GetHeaderFunctions()
        {
            yield return new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusBusinessId", adsml => adsml.AdOrder.BookingIdentifier);
            yield return new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusDescription", adsml => adsml.AdOrder.Campaign.CodeValue.ToString());
        }

        protected override AdsMLBookings CreateModelInstance()
        {
            return TestConfiguration.CreatePopulatedAdsMLBookingsInstance();
        }
    }

    public class SqsTestInvoice : SqsOutgoingTransportTest<ZADP_INVOICE_V1>
    {
        protected override IEnumerable<KeyValuePair<string, Func<ZADP_INVOICE_V1, string>>> GetHeaderFunctions()
        {
            yield return new KeyValuePair<string, Func<ZADP_INVOICE_V1, string>>("ServiceBusBusinessId", invoice => invoice.I_INVOICE_TOP.INVOICE_BATCH);
        }

        protected override ZADP_INVOICE_V1 CreateModelInstance()
        {
            return TestConfiguration.GetPopulatedInvoice();
        }
    }
}
