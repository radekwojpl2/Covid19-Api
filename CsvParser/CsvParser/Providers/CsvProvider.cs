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
        public string ParseCountriesAggregatedFile(string pathToFolder)
        {
            try
            {
                using (var reader =
                    new StreamReader(
                        pathToFolder + "/countries-aggregated.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CountriesAggregated>();

                    return JsonConvert.SerializeObject(records);
                }
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
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        pathToFolder + "/time-series-19-covid-combined.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<TimeSeries19Covid>();

                    return JsonConvert.SerializeObject(records);
                }
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
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        pathToFolder + "/key-countries-pivoted.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<KeyCountries>();

                    return JsonConvert.SerializeObject(records);
                }
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
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        pathToFolder + "/worldwide-aggregated.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<WordWideCases>();

                    return JsonConvert.SerializeObject(records);
                }
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