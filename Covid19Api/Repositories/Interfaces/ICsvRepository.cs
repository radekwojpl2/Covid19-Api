using System.Collections.Generic;
using System.Threading.Tasks;
using CsvParser.Models;

namespace Covid19Api.Repositories.Interfaces
{
    public interface ICsvRepository
    {
        public IEnumerable<CountriesAggregated> GetAllDataFromCountriesAggregated();
        public IEnumerable<WordWideCases> GetAllDataFromWorldWideAggregated();
        public IEnumerable<KeyCountries> GetAllDataFromKeyCountriesPivoted();
        public IEnumerable<TimeSeries19Covid> GetAllDataFromTimeSeries19CovidCombined();
    }
}