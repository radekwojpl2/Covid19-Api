using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvParser.Models;
using CsvParser.Providers.Interfaces;

namespace CsvParser.Providers
{
    public class ReadFileProvider : IReadFileProvider
    {
        public IEnumerable<CountriesAggregated> ReadCountriesAggregatedFile(string pathToFolder)
        {
            try
            {
                using (var reader =
                    new StreamReader(
                        Path.Combine(pathToFolder + "/countries-aggregated.csv")))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CountriesAggregated>();

                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Error during CountriesAggregatedFile");
                Console.WriteLine($"EXCEPTION: {e}");
                throw;
            }
        }

        public IEnumerable<WordWideCases> ReadWorldWideAggregatedFile(string pathToFolder)
        {
            try
            {
                using (var reader =
                    new StreamReader(
                        Path.Combine(pathToFolder + "/worldwide-aggregated.csv")))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<WordWideCases>();

                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Error during WorldWideAggregatedFile");
                Console.WriteLine($"EXCEPTION: {e}");
                throw;
            }
        }

        public IEnumerable<KeyCountries> ReadKeyCountriesPivotedFile(string pathToFolder)
        {
            try
            {
                using (var reader =
                    new StreamReader(
                        Path.Combine(pathToFolder + "/key-countries-pivoted.csv")))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<KeyCountries>();

                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Error during KeyCountriesPivotedFile");
                Console.WriteLine($"EXCEPTION: {e}");
                throw;
            }
        }

        public IEnumerable<TimeSeries19Covid> ReadTimeSeries19CovidCombinedFile(string pathToFolder)
        {
            try
            {
                using (var reader =
                    new StreamReader(
                        Path.Combine(pathToFolder + "/time-series-19-covid-combined.csv")))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<TimeSeries19Covid>();

                    return records.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Error during TimeSeries19CovidCombinedFile");
                Console.WriteLine($"EXCEPTION: {e}");
                throw;
            }
        }
    }
}