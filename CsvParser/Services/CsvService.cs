using System.Net;
using System.IO;
using CsvParser.Providers;
using CsvParser.Providers.Interfaces;
using System;

namespace CsvParser.Services
{
    public class CsvService : ISaveFiles
    {
        private readonly IFileProvider _fileProvider;
        private readonly string pathToCsvFiles;
        private readonly string pathToJsonFilesDestination;

        public CsvService()
        {
            _fileProvider = new CsvProvider();
        }

        private void DeleteFileIfExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public bool ProccesAllFiles()
        {
            try
            {
                this.SaveWorldWideAggregatedFile();
                return true;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public bool SaveCountriesAggregatedFile()
        {
            try
            {
                var content = _fileProvider.ParseCountriesAggregatedFile();

                this.DeleteFileIfExist(
                    "countries-aggregated.json");

                File.WriteAllText("countries-aggregated.json",
                    content);

                return true;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public bool SaveReferencesFile()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveTimeSeries19CovidCombinedFile()
        {
            try
            {
                var content = _fileProvider.ParseTimeSeries19CovidCombinedFile();
                
                this.DeleteFileIfExist(
                    "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/time-series-19-covid-combined.json");

                File.WriteAllText(
                    "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/time-series-19-covid-combined.json", content);

                return true;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public bool SaveKeyCountriesPivotedFile()
        {
            try
            {
                var content = _fileProvider.ParseTimeSeries19CovidCombinedFile();
                
                this.DeleteFileIfExist(
                    "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/key-countries-pivoted.json");

                File.WriteAllText(
                    "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/key-countries-pivoted.json", content);

                return true;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public bool SaveUsConfirmedFile()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveUsDeathsFile()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveWorldWideAggregatedFile()
        {
            try
            {
                var content = _fileProvider.ParseWorldWideAggregatedFile();
                
                this.DeleteFileIfExist(
                    "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/worldwide-aggregated.json");

                File.WriteAllText("/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/worldwide-aggregated.json",
                    content);

                return true;
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}