using System;
using System.IO;
using Amazon.Runtime.Internal.Util;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Models;
using Xunit;
using FluentAssertions;

namespace RabbitAndSqs.Tests
{
    public class UnitTest1
    {
        private XmlSerializer<AdsMLBookings> _subject;
        private readonly AdsMLBookings _item;

        public UnitTest1()
        {
            _subject = new XmlSerializer<AdsMLBookings>();

        }

        [Fact]
        public void Test1()
        {
            FileInfo fileInfo = new FileInfo("adsml-bookings.xml");
            using var reader = new StreamReader(fileInfo.OpenRead());
            var xml = reader.ReadToEnd();
            xml.Should().NotBeEmpty();
            var item = _subject.Deserialize(xml);
            item.Should().NotBeNull();

        }
    }
}
