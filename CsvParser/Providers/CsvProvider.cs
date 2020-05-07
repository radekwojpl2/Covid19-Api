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
                using (var reader = new StreamReader("/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/countries-aggregated.csv"))
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

                throw exception;
            }
        }

        public string ParseReferencesFile()
        {
            throw new System.NotImplementedException();
        }

        public string ParseTimeSeries19CovidCombinedFile()
        {
            throw new System.NotImplementedException();
        }

        public string ParseUKeyCountriesPivotedFile()
        {
            throw new System.NotImplementedException();
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
                using (var reader = new StreamReader("/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/worldwide-aggregated.csv"))
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