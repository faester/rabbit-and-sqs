using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SQS.Model;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Connections.Sqs;
using RabbitAndSqs.Models;
using Xunit.Abstractions;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public class RabbitTransportInvoiceTest : TransportTest<ZADP_INVOICE_V1>
    {
        private readonly string _username = "sb";
        private readonly string _password = "sb";
        private readonly string _host = "lb.mq-dev.jppol.net";
        private readonly string _queue = "TEMP_lineup_testing";
        private readonly int _port = 5672;
        private RabbitMqTransport<ZADP_INVOICE_V1> _subject;

        public RabbitTransportInvoiceTest()
        {
            EmptyQueue();
        }

        private void EmptyQueue()
        {
            var incoming = CreateIncomingTransport();
            Task<IEnumerable<ISerializedMessage<ZADP_INVOICE_V1>>> items;
            do
            {
                items = incoming.ReceiveBatch(CancellationToken.None);
            } while (items != null && items.Result.Any());
        }

        protected override IIncomingTransport<ZADP_INVOICE_V1> CreateIncomingTransport()
        {
            return _subject ??= new RabbitMqTransport<ZADP_INVOICE_V1>(_queue, _username, _password, _host, _messageFactory, _port);
        }

        protected override IOutgoingTransport<ZADP_INVOICE_V1> CreateOutgoingTransport()
        {
            return _subject ??= new RabbitMqTransport<ZADP_INVOICE_V1>(_queue, _username, _password, _host, _messageFactory, _port);
        }

        protected override IEnumerable<KeyValuePair<string, Func<ZADP_INVOICE_V1, string>>> GetHeaderFunctions()
        {
            yield return new KeyValuePair<string, Func<ZADP_INVOICE_V1, string>>("ServiceBusBusinessId", invoice => invoice.I_INVOICE_TOP.INVOICE_BATCH);
        }

        protected override ZADP_INVOICE_V1 CreateModelInstance()
        {
            return TestConfiguration.GetPopulatedInvoice();
        }
    }

    public class RabbitTransportAdsMlTest : TransportTest<AdsMLBookings>
    {
        private readonly string _username = "sb";
        private readonly string _password = "sb";
        private readonly string _host =  "lb.mq-dev.jppol.net";
        private readonly string _queue = "TEMP_lineup_testing";
        private readonly int _port = 5672;
        private RabbitMqTransport<AdsMLBookings> _subject;

        public RabbitTransportAdsMlTest()
        {
            EmptyQueue();
        }

        private void EmptyQueue()
        {
            var incoming = CreateIncomingTransport();
            Task<IEnumerable<ISerializedMessage<AdsMLBookings>>> items;
            do
            {
                items = incoming.ReceiveBatch(CancellationToken.None);
            } while (items != null && items.Result.Any());
        }

        protected override IIncomingTransport<AdsMLBookings> CreateIncomingTransport()
        {
            return _subject ??= new RabbitMqTransport<AdsMLBookings>(_queue, _username, _password, _host, _messageFactory, _port);
        }

        protected override IOutgoingTransport<AdsMLBookings> CreateOutgoingTransport()
        {
            return _subject ??= new RabbitMqTransport<AdsMLBookings>(_queue, _username, _password, _host, _messageFactory, _port);
        }

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

    public abstract class SqsOutgoingTransportTest<TModel> : TransportTest<TModel>
    {
        private readonly AmazonSQSClient _client = new AmazonSQSClient(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
        private readonly AmazonS3Client _s3 = new AmazonS3Client(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
        private readonly string _queue = TestConfiguration.GetValue("sqs_queue");
        private readonly string _bucket = TestConfiguration.GetValue("s3_bucket");

        protected SqsOutgoingTransportTest()
        {
            ClearQueue();
        }

        protected override IIncomingTransport<TModel> CreateIncomingTransport()
        {
            return new SqsIncomingTransport<TModel>(_client, _queue, _messageFactory, _s3, _bucket);
        }

        protected override IOutgoingTransport<TModel> CreateOutgoingTransport()
        {
            return new SqsOutgoingTransport<TModel>(_client, _queue, _s3, _bucket);
        }

        private void ClearQueue()
        {
            Task<ReceiveMessageResponse> messageResponse;
            do
            {
                messageResponse = _client.ReceiveMessageAsync(_queue);
                messageResponse.Wait();
                _client.DeleteMessageBatchAsync(_queue, messageResponse.Result.Messages.Select(x => new DeleteMessageBatchRequestEntry(x.MessageId, x.ReceiptHandle)).ToList());

            } while (messageResponse.Result.Messages.Any());
        }
    }
}