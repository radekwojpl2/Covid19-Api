using System;
using System.Text.Json.Serialization;
using CsvParser.Providers;
using CsvParser.Providers.Interfaces;
using CsvParser.Tests.Fake;
using NUnit.Framework;

namespace CsvParser.Tests.Unit
{
    //MethodName_StateUnderTest_ExpectedBehavior
    [TestFixture]
    public class CsvProviderTests
    {
        private IFileProvider _fileProvider;

        [SetUp]
        public void Setup()
        {
            _fileProvider = new CsvProvider(new ReadFileProviderFake());
        }

        [Test]
        public void ParseCountriesAggregatedFile_CorrectListProvided_ShouldReturnCorrectJson()
        {
            var actual = _fileProvider.ParseCountriesAggregatedFile("/home/test/path");

            var expected =
                "[{\"Date\":\"2020-09-13T00:00:00\",\"Country\":\"Poland\",\"Confirmed\":100,\"Recovered\":90,\"Deaths\":10}]";

            Assert.AreEqual(expected, actual);
        }
    }
}