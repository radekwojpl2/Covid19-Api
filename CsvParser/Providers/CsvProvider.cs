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
        public string ParseCountriesAggregatedFile()
        {
            try
            {
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        "/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/countries-aggregated.csv"))
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

        public string ParseReferencesFile()
        {
            throw new System.NotImplementedException();
        }

        public string ParseTimeSeries19CovidCombinedFile()
        {
            try
            {
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        "/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/time-series-19-covid-combined.csv"))
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

        public string ParseKeyCountriesPivotedFile()
        {
            try
            {
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        "/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/key-countries-pivoted.csv"))
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

        public string ParseUsConfirmedFile()
        {
            throw new System.NotImplementedException();
        }

        public string ParseUsDeathsFile()
        {
            throw new System.NotImplementedException();
        }

        public string ParseWorldWideAggregatedFile()
        {
            try
            {
                //Environment.CurrentDirectory
                using (var reader =
                    new StreamReader(
                        "/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/worldwide-aggregated.csv"))
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