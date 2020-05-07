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

        public CsvService()
        {
            _fileProvider = new CsvProvider();
        }

        private void DeleteFileIfExist(string filePath )
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
            catch (System.Exception)
            {
                
                throw;
            }

        }

        public bool SaveCountriesAggregatedFile()
        {
            try
            {
               var content = _fileProvider.ParseCountriesAggregatedFile();

               Console.WriteLine(Directory.GetCurrentDirectory());

                this.DeleteFileIfExist("/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/countries-aggregated.json");

                File.WriteAllText("/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/countries-aggregated.json", content);

                return true;

            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool SaveReferencesFile()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveTimeSeries19CovidCombinedFile()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveUKeyCountriesPivotedFile()
        {
            throw new System.NotImplementedException();
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

               Console.WriteLine(Directory.GetCurrentDirectory());

                this.DeleteFileIfExist("/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/worldwide-aggregated.json");

                File.WriteAllText("/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData/worldwide-aggregated.json", content);

                return true;

            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}