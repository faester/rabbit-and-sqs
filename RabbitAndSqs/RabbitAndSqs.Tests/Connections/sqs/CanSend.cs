using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.SQS;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Connections.Messages;
using RabbitAndSqs.Connections.Sqs;
using RabbitAndSqs.Models;
using Xunit;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public class SqsOutgoingTransport
    {
        private readonly SqsOutgoingTransport<AdsMLBookings> _subject;

        public SqsOutgoingTransport()
        {
            IAmazonSQS client= new AmazonSQSClient(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
            IAmazonS3 s3 = new AmazonS3Client(TestConfiguration.GetAwsCredentials(), TestConfiguration.GetAWSRegionEndpoint());
            _subject = new SqsOutgoingTransport<AdsMLBookings>(client, TestConfiguration.GetValue("sqs_queue"), s3 , TestConfiguration.GetValue("s3_bucket"));
        }

        [Fact]
        public async Task Send_ThenNoApparentException()
        {
            ISerializedMessage<AdsMLBookings> messages = new AdsMLBookingsMessage(TestConfiguration.CreatePopulatedAdsMLBookingsInstance(), new XmlSerialization<AdsMLBookings>());
            await _subject.Send(messages);
        }
    }
}
