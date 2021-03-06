using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Covid19Api.Dtos;
using Covid19Api.Repositories.Interfaces;
using CsvParser.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Covid19Api.Repositories
{
    public class CsvRepository : ICsvRepository
    {
        private readonly ILogger<CsvRepository> _logger;
        private readonly IConfiguration _configuration;

        public CsvRepository(ILogger<CsvRepository> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IEnumerable<CountriesAggregated> GetAllDataFromCountriesAggregated()
        {
            try
            {
                
                using (StreamReader r =
                    new StreamReader(Path.Combine("JsonData/",
                        "countries-aggregated.json")))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<CountriesAggregated>>(json);
                    return items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<CountriesAggregated> GetByDateCountriesAggregated(DateDto dateTime)
        {
            try
            {
                using (StreamReader r =
                    new StreamReader(Path.Combine("JsonData/",
                        "countries-aggregated.json")))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<CountriesAggregated>>(json)
                        .Where(x => x.Date.Month == dateTime.Month && x.Date.Day == dateTime.Day );
                    return items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<WordWideCases> GetAllDataFromWorldWideAggregated()
        {
            try
            {
                using (StreamReader r =
                    new StreamReader(Path.Combine("JsonData/",
                        "worldwide-aggregated.json")))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<WordWideCases>>(json);
                    return items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<KeyCountries> GetAllDataFromKeyCountriesPivoted()
        {
            try
            {
                using (StreamReader r =
                    new StreamReader(
                        Path.Combine("JsonData/", "key-countries-pivoted.json")))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<KeyCountries>>(json);
                    return items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<TimeSeries19Covid> GetAllDataFromTimeSeries19CovidCombined()
        {
            try
            {
                using (StreamReader r =
                    new StreamReader(
                        Path.Combine("JsonData/", "time-series-19-covid-combined.json")))
                {
                    string json = r.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<TimeSeries19Covid>>(json);
                    return items;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}