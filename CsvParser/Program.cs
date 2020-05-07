using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvParser.Models;
using CsvParser.Providers;
using CsvParser.Services;
using Newtonsoft.Json;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvProvider = new CsvService();

            var fileContent = csvProvider.SaveWorldWideAggregatedFile();
            var countriescontent = csvProvider.SaveCountriesAggregatedFile();

            // using (var reader = new StreamReader("/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/worldwide-aggregated.csv"))
            // using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            // {
            //     var records = csv.GetRecords<WordWideCases>();
            //     Console.WriteLine(JsonConvert.SerializeObject(records));
            // }
            Console.WriteLine(countriescontent);
            Console.WriteLine(fileContent);
        }
    }
}
