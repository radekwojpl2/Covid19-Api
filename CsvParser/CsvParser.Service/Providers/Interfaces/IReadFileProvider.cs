using System.Collections;
using System.Collections.Generic;
using CsvParser.Models;

namespace CsvParser.Providers.Interfaces
{
    public interface IReadFileProvider
    {
        public IEnumerable<CountriesAggregated> ReadCountriesAggregatedFile(string pathToFolder);
        public IEnumerable<WordWideCases> ReadWorldWideAggregatedFile(string pathToFolder);
        public IEnumerable<KeyCountries> ReadKeyCountriesPivotedFile(string pathToFolder);
        public IEnumerable<TimeSeries19Covid> ReadTimeSeries19CovidCombinedFile(string pathToFolder);
    }
}