using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Amazon.Runtime.Internal.Util;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Models;
using Xunit;
using FluentAssertions;

namespace RabbitAndSqs.Tests
{
    public class UnitTest1
    {
        private XmlSerialization<AdsMLBookings> _subject;
        private readonly AdsMLBookings _item;
        FileInfo _fileInfo = new FileInfo("adsml-bookings.xml");

        public UnitTest1()
        {
            _subject = new XmlSerialization<AdsMLBookings>();

        }

        [Fact]
        public void Test1()
        {
            using var reader = _fileInfo.OpenText();
            var xml = reader.ReadToEnd();
            xml.Should().NotBeEmpty();
            var item = _subject.Deserialize(xml);
            item.Should().NotBeNull();
        }

        [Fact]
        public void FileIsDeserializable()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AdsMLBookings));
            AdsMLBookings deserialized = (AdsMLBookings)xmlSerializer.Deserialize(new FileStream(_fileInfo.FullName, FileMode.Open));

            deserialized.Should().NotBeNull();

        }
    }
}
