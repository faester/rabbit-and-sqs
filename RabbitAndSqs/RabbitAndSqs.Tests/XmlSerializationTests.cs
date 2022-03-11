using System.Configuration;
using System.IO;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Models;
using Xunit;
using FluentAssertions;

namespace RabbitAndSqs.Tests
{
    public class XmlSerializationTests
    {
        private readonly XmlSerialization<AdsMLBookings> _subject;
        private static readonly FileInfo FileInfo = new FileInfo("adsml-bookings.xml");

        public XmlSerializationTests()
        {
            _subject = new XmlSerialization<AdsMLBookings>();
        }

        [Fact]
        public void Deserialize_ThenDeserializedObject()
        {
            AdsMLBookings deserialized = _subject.Deserialize(TestConfiguration.GetAdsMLBookingXmlFileContent());

            deserialized.Should().NotBeNull();
        }

        [Fact]
        public void Serialize_ThenDeserializableString()
        {
            var serializedString = _subject.Serialize(TestConfiguration.CreatePopulatedAdsMLBookingsInstance());

            var deserialized = _subject.Deserialize(serializedString);
            deserialized.Should().NotBeNull();
        }
    }
}
