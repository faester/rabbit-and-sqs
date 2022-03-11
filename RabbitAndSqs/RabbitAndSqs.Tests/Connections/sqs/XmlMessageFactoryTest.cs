using System;
using System.Collections.Generic;
using FluentAssertions;
using RabbitAndSqs.Connections.Messages;
using RabbitAndSqs.Models;
using Xunit;

namespace RabbitAndSqs.Tests.Connections.sqs
{
    public class XmlMessageFactoryTest
    {
        [Fact]
        public void Create_ThenExpectedHeaders()
        {
            var subject = new XmlMessageFactory<AdsMLBookings>(
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusBusinessId", adsml => adsml.AdOrder.BookingIdentifier),
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusDescription", adsml => adsml.AdOrder.Campaign.CodeValue.ToString())
            );

            var actual = subject.CreateFrom(TestConfiguration.CreatePopulatedAdsMLBookingsInstance());

            actual.Headers.Should().Contain(new KeyValuePair<string, string>("ServiceBusBusinessId", "test.jpp.adpoint.me:2016-01-01:CA562835"));
            actual.Headers.Should().Contain(new KeyValuePair<string, string>("ServiceBusDescription", "850211"));
        }

        [Fact]
        public void Create_WhenSerializedThenHeaders()
        {
            var subject = new XmlMessageFactory<AdsMLBookings>(
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusBusinessId", adsml => adsml.AdOrder.BookingIdentifier),
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusDescription", adsml => adsml.AdOrder.Campaign.CodeValue.ToString())
            );
            Dictionary<string, string> dictionary = new Dictionary<string, string> { { "a", "a1" }, { "b", "b1" } };

            var actual = subject.CreateFrom(TestConfiguration.GetAdsMLBookingXmlFileContent(), dictionary);

            actual.Headers.Should().Contain(new KeyValuePair<string, string>("a", "a1"));
            actual.Headers.Should().Contain(new KeyValuePair<string, string>("b", "b1"));
            actual.Headers.Should().HaveCount(2);
        }

        [Fact]
        public void Create_WhenSerializedThenContents()
        {
            var subject = new XmlMessageFactory<AdsMLBookings>(
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusBusinessId", adsml => adsml.AdOrder.BookingIdentifier),
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusDescription", adsml => adsml.AdOrder.Campaign.CodeValue.ToString())
            );
            var dictionary = new Dictionary<string, string> { { "a", "a1" }, { "b", "b1" } };

            var actual = subject.CreateFrom(TestConfiguration.GetAdsMLBookingXmlFileContent(), dictionary);

            actual.Content.Should().Be(TestConfiguration.GetAdsMLBookingXmlFileContent());
            actual.Deserialize().Should().BeEquivalentTo(TestConfiguration.CreatePopulatedAdsMLBookingsInstance());
        }

        [Fact]
        public void Create_WhenModelThenContents()
        {
            var subject = new XmlMessageFactory<AdsMLBookings>(
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusBusinessId", adsml => adsml.AdOrder.BookingIdentifier),
                new KeyValuePair<string, Func<AdsMLBookings, string>>("ServiceBusDescription", adsml => adsml.AdOrder.Campaign.CodeValue.ToString())
            );
            var dictionary = new Dictionary<string, string> { { "a", "a1" }, { "b", "b1" } };

            var actual = subject.CreateFrom(TestConfiguration.CreatePopulatedAdsMLBookingsInstance());

            actual.Content.Should().NotBeEmpty();
            actual.Deserialize().Should().BeEquivalentTo(TestConfiguration.CreatePopulatedAdsMLBookingsInstance());
        }
    }
}