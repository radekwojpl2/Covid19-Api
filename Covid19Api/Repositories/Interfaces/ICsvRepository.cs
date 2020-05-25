using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Dtos;
using CsvParser.Models;

namespace Covid19Api.Repositories.Interfaces
{
    public interface ICsvRepository
    {
        public IEnumerable<CountriesAggregated> GetAllDataFromCountriesAggregated();
        public IEnumerable<CountriesAggregated> GetByDateCountriesAggregated(DateDto dateTime);
        public IEnumerable<WordWideCases> GetAllDataFromWorldWideAggregated();
        public IEnumerable<KeyCountries> GetAllDataFromKeyCountriesPivoted();
        public IEnumerable<TimeSeries19Covid> GetAllDataFromTimeSeries19CovidCombined();
    }
}