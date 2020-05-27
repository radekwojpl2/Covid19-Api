using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using CsvHelper;
using CsvParser.Models;
using CsvParser.Providers.Interfaces;

namespace CsvParser.Providers
{
    public class GitFileProvider : IReadFileProvider
    {
        public IEnumerable<CountriesAggregated> ReadCountriesAggregatedFile(string pathToFolder)
        {
            try
            {
                using var client = new WebClient();
                using var stream = client.OpenRead(new Uri(pathToFolder +"/countries-aggregated.csv"));
                using var reader = new StreamReader(stream);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            
                var records = csv.GetRecords<CountriesAggregated>();
                
                var restult = records.ToList();

                return restult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IEnumerable<WordWideCases> ReadWorldWideAggregatedFile(string pathToFolder)
        {
            try
            {
                using var client = new WebClient();
                using var stream = client.OpenRead(new Uri(pathToFolder +"/worldwide-aggregated.csv"));
                using var reader = new StreamReader(stream);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            
                var records = csv.GetRecords<WordWideCases>();
                
                var restult = records.ToList();

                return restult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public IEnumerable<KeyCountries> ReadKeyCountriesPivotedFile(string pathToFolder)
        {
            try
            {
                using var client = new WebClient();
                using var stream = client.OpenRead(new Uri(pathToFolder +"/key-countries-pivoted.csv"));
                using var reader = new StreamReader(stream);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            
                var records = csv.GetRecords<KeyCountries>();
                
                var restult = records.ToList();

                return restult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public IEnumerable<TimeSeries19Covid> ReadTimeSeries19CovidCombinedFile(string pathToFolder)
        {
            try
            {
                using var client = new WebClient();
                using var stream = client.OpenRead(new Uri(pathToFolder + "/time-series-19-covid-combined.csv"));
                using var reader = new StreamReader(stream);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            
                var records = csv.GetRecords<TimeSeries19Covid>();
                
                var restult = records.ToList();

                return restult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}