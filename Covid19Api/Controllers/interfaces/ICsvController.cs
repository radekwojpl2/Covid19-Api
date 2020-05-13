using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Dtos;
using CsvParser.Models;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Api.Controllers
{
    public interface ICsvController
    {
        public ActionResult<IEnumerable<CountriesAggregated>> GetAllDataFromCountriesAggregated();
        
        public ActionResult<IEnumerable<CountriesAggregated>> GetByDateCountriesAggregated(DateDto dateTime);

        public ActionResult<IEnumerable<WordWideCases>> GetAllDataFromWorldWideAggregated();
        public ActionResult<IEnumerable<KeyCountries>> GetAllDataFromKeyCountriesPivoted();
        public ActionResult<IEnumerable<TimeSeries19Covid>> GetAllDataFromTimeSeries19CovidCombined();
    }
}