using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvParser.Models;
using CsvParser.Providers.Interfaces;
using Newtonsoft.Json;

namespace CsvParser.Providers
{
    public class CsvProvider : IFileProvider
    {
        private readonly IReadFileProvider _readFileProvider;

        public CsvProvider(IReadFileProvider readFileProvider)
        {
            _readFileProvider = readFileProvider;
        }

        public string ParseCountriesAggregatedFile(string pathToFolder)
        {
            try
            {
                var records = _readFileProvider.ReadCountriesAggregatedFile(pathToFolder);

                return JsonConvert.SerializeObject(records);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine($"ERROR: error during parsing CountriesAggregatedFile");
                Console.WriteLine($"Exception: {exception.Message} / InnerException: {exception.InnerException} ");

                throw;
            }
        }

        public string ParseReferencesFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }

        public string ParseTimeSeries19CovidCombinedFile(string pathToFolder)
        {
            try
            {
                var records = _readFileProvider.ReadTimeSeries19CovidCombinedFile(pathToFolder);

                return JsonConvert.SerializeObject(records);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine($"ERROR: error during parsing TimeSeries19CovidCombinedFile");
                Console.WriteLine($"Exception: {exception.Message} / InnerException: {exception.InnerException} ");

                throw;
            }
        }

        public string ParseKeyCountriesPivotedFile(string pathToFolder)
        {
            try
            {
                var records = _readFileProvider.ReadKeyCountriesPivotedFile(pathToFolder);

                return JsonConvert.SerializeObject(records);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine($"ERROR: error during parsing KeyCountriesPivotedFile");
                Console.WriteLine($"Exception: {exception.Message} / InnerException: {exception.InnerException} ");

                throw;
            }
        }

        public string ParseUsConfirmedFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }

        public string ParseUsDeathsFile(string pathToFolder)
        {
            throw new System.NotImplementedException();
        }

        public string ParseWorldWideAggregatedFile(string pathToFolder)
        {
            try
            {
                var records = _readFileProvider.ReadWorldWideAggregatedFile(pathToFolder);

                return JsonConvert.SerializeObject(records);
            }
            catch (System.Exception exception)
            {
                Console.WriteLine($"ERROR: error during parsing WorldWideAggregatedFile");
                Console.WriteLine($"Exception: {exception.Message} / InnerException: {exception.InnerException} ");

                throw exception;
            }
        }
    }
}