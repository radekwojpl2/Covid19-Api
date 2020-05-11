using System;
using System.IO;
using CsvParser.Providers;
using CsvParser.Services;

namespace CsvParser
{
    class Program
    {
        static int Main(string[] args)
        {
            string pathToCsvFiles = "";
            string pathToJsonDestination = "";

            try
            {
                laodParameters(args, ref pathToCsvFiles, ref pathToJsonDestination);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }

            var csvProvider = new CsvService(pathToCsvFiles, pathToJsonDestination, new CsvProvider(new StreamProvider()));

            try
            {
                csvProvider.SaveWorldWideAggregatedFile();
                csvProvider.SaveCountriesAggregatedFile();
                csvProvider.SaveTimeSeries19CovidCombinedFile();
                csvProvider.SaveKeyCountriesPivotedFile();
                
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Error during processing {e}");
                return 0;
            }
        }

        static void laodParameters(string[] args, ref string pathToCSV, ref string pathToJsonDestination)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (Directory.Exists(args[i]))
                        {
                            pathToCSV = args[i];
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Path to csv files have to be specified!");
                            throw new Exception("Path to csv files have to be specified!");
                        }

                        break;
                    case 1:
                        if (args[i] != null)
                        {
                            pathToJsonDestination = args[i];
                        }
                        else
                        {
                            pathToJsonDestination = Directory.GetCurrentDirectory() + "/../JsonData/";
                        }

                        break;
                }
            }
        }
    }
}