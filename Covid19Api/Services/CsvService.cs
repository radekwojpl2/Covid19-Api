using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Dtos;
using Covid19Api.Repositories.Interfaces;
using Covid19Api.Services.Interfaces;
using CsvParser.Models;

namespace Covid19Api.Services
{
    public class CsvService : ICsvService
    {
        private readonly ICsvRepository _csvRepository;

        public CsvService(ICsvRepository csvRepository)
        {
            _csvRepository = csvRepository;
        }


        public IEnumerable<CountriesAggregated> GetAllDataFromCountriesAggregated()
        {
            try
            {
                return _csvRepository.GetAllDataFromCountriesAggregated();

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
                return _csvRepository.GetByDateCountriesAggregated(dateTime);

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
                return _csvRepository.GetAllDataFromWorldWideAggregated();

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
                return _csvRepository.GetAllDataFromKeyCountriesPivoted();

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
                return _csvRepository.GetAllDataFromTimeSeries19CovidCombined();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}