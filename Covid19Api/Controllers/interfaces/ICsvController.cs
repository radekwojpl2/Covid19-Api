using System.Collections.Generic;
using System.Threading.Tasks;
using CsvParser.Models;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Api.Controllers
{
    public interface ICsvController
    {
        public IActionResult GetAllDataFromCountriesAggregated();
        public IActionResult GetAllDataFromWorldWideAggregated();
        public IActionResult GetAllDataFromKeyCountriesPivoted();
        public IActionResult GetAllDataFromTimeSeries19CovidCombined();
    }
}