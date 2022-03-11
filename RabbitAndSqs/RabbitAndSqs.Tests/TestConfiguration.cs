using System;
using System.Collections.Generic;
using System.IO;
using Amazon;
using Amazon.Runtime;
using Newtonsoft.Json;
using RabbitAndSqs.Connections;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Tests
{
    public static class TestConfiguration
    {
        private static readonly FileInfo ConfigFile = new FileInfo("config.json");
        private static readonly FileInfo AdsMlBookingFile = new FileInfo("adsml-bookings.xml");
        private static readonly FileInfo InvoiceFile = new FileInfo("invoiceExample.xml");
        private static Dictionary<string, string> _settings;

        static TestConfiguration()
        {
        }

        private static void PopulateSettings()
        {
            if (_settings != null)
            {
                return;
            }
            if (!ConfigFile.Exists)
            {
                throw new Exception("The configuration file 'config.json' appears to be missing. Please fix.");
            }

            using var reader = new StreamReader(ConfigFile.OpenRead());
            _settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.ReadToEnd());
        }

        public static string GetValue(string key)
        {
            PopulateSettings();

            if (!_settings.TryGetValue(key, out var value))
            {
                throw new ArgumentException($"'{key}' not found in settings.");
            }

            return value;
        }

        public static T GetValue<T>(string key, Func<string, T> converter)
        {
            string value = null;
            try
            {
                value = GetValue(key);
                return converter(value);
            }
            catch (FormatException)
            {
                throw new ArgumentException($"Could not convert '{value}' to {typeof(T)}");
            }
        }

        public static string GetAdsMLBookingXmlFileContent()
        {
            using var reader = new StreamReader(AdsMlBookingFile.OpenRead());
            return reader.ReadToEnd();
        }

        public static string GetInvoiceXmlFileContent()
        {
            using var reader = new StreamReader(InvoiceFile.OpenRead());
            return reader.ReadToEnd();
        }

        public static ZADP_INVOICE_V1 GetPopulatedInvoice()
        {
            var serialization = new XmlSerialization<ZADP_INVOICE_V1>();
            return serialization.Deserialize(GetInvoiceXmlFileContent());
        }

        /// <summary>
        /// Populating one of these guys isn't dead simple. Get one here...
        /// </summary>
        /// <returns></returns>
        public static AdsMLBookings CreatePopulatedAdsMLBookingsInstance()
        {
            var serialization = new XmlSerialization<AdsMLBookings>();
            return serialization.Deserialize(GetAdsMLBookingXmlFileContent());
        }

        public static RegionEndpoint GetAWSRegionEndpoint()
        {
            return RegionEndpoint.EUWest1;
        }
        public static AWSCredentials GetAwsCredentials()
        {
            return new BasicAWSCredentials(
                GetValue("AWS_ACCESS_KEY_ID"), 
                GetValue("AWS_SECRET_CLIENT_KEY"));
        }
    }
}