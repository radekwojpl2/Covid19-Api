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
        private readonly string _pathToCsvFiles;
        private readonly string _pathToJsonFilesDestination;

        public CsvService(string pathToCsvFiles, string pathToJsonFilesDestination)
        {
            _pathToCsvFiles = pathToCsvFiles;
            _pathToJsonFilesDestination = pathToJsonFilesDestination;
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
                var content = _fileProvider.ParseCountriesAggregatedFile(_pathToCsvFiles);

                this.DeleteFileIfExist(
                    _pathToJsonFilesDestination + "/countries-aggregated.json");

                File.WriteAllText(_pathToJsonFilesDestination + "/countries-aggregated.json",
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
                var content = _fileProvider.ParseTimeSeries19CovidCombinedFile(_pathToCsvFiles);

                this.DeleteFileIfExist(
                    _pathToJsonFilesDestination + "/time-series-19-covid-combined.json");

                File.WriteAllText(
                    _pathToJsonFilesDestination + "/time-series-19-covid-combined.json", content);

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
                var content = _fileProvider.ParseTimeSeries19CovidCombinedFile(_pathToCsvFiles);

                this.DeleteFileIfExist(
                    _pathToJsonFilesDestination + "/key-countries-pivoted.json");

                File.WriteAllText(
                    _pathToJsonFilesDestination + "/key-countries-pivoted.json", content);

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
                var content = _fileProvider.ParseWorldWideAggregatedFile(_pathToCsvFiles);

                this.DeleteFileIfExist(
                    _pathToJsonFilesDestination + "/worldwide-aggregated.json");

                File.WriteAllText(_pathToJsonFilesDestination + "/worldwide-aggregated.json",
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