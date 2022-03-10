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
            AdsMLBookings deserialized = _subject.Deserialize(GetXmlFileContent());

            deserialized.Should().NotBeNull();
        }

        [Fact]
        public void Serialize_ThenDeserializableString()
        {
            var serializedString = _subject.Serialize(CreatePopulatedAdsMLBookingsInstance());

            var deserialized = _subject.Deserialize(serializedString);
            deserialized.Should().NotBeNull();
        }

        private static string GetXmlFileContent()
        {
            using var reader = new StreamReader(FileInfo.OpenRead());
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Populating one of these guys isn't dead simple. Get one here...
        /// </summary>
        /// <returns></returns>
        public static AdsMLBookings CreatePopulatedAdsMLBookingsInstance()
        {
            var serialization = new XmlSerialization<AdsMLBookings>();
            return serialization.Deserialize(GetXmlFileContent());
        }
    }
}
