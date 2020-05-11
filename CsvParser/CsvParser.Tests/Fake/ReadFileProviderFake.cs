using System;
using System.Collections.Generic;
using CsvParser.Models;
using CsvParser.Providers.Interfaces;

namespace CsvParser.Tests.Fake
{
    public class ReadFileProviderFake : IReadFileProvider
    {
        public IEnumerable<CountriesAggregated> ReadCountriesAggregatedFile(string pathToFolder)
        {
            return new List<CountriesAggregated>()
            {
                new CountriesAggregated()
                {
                    Confirmed = 100,
                    Country = "Poland",
                    Date = new DateTime(2020,9,13),
                    Deaths = 10,
                    Recovered = 90,
                }
            };
        }

        public IEnumerable<WordWideCases> ReadWorldWideAggregatedFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<KeyCountries> ReadKeyCountriesPivotedFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TimeSeries19Covid> ReadTimeSeries19CovidCombinedFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }
    }
}