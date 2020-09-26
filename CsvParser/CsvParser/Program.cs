using System;
using System.IO;
using System.Threading.Tasks;
using CsvParser.Models.Models;
using CsvParser.Providers;
using CsvParser.Scheduler.Jobs;
using CsvParser.Scheduler.Services;
using CsvParser.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using LogLevel = Quartz.Logging.LogLevel;

namespace CsvParser
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            string webMode = "";
            string pathToCsvFiles = "";
            string pathToJsonDestination = "";
            CsvService csvProvider;


            try
            {
                laodParameters(args, ref pathToCsvFiles, ref pathToJsonDestination, ref webMode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            if (webMode == "true")
            {
                csvProvider = new CsvService(pathToCsvFiles, pathToJsonDestination,
                    new CsvProvider(new GitFileProvider()));
            }
            else
            {
                csvProvider = new CsvService(pathToCsvFiles, pathToJsonDestination,
                    new CsvProvider(new ReadFileProvider()));
            }



            try
            {
                csvProvider.SaveWorldWideAggregatedFile();
                csvProvider.SaveCountriesAggregatedFile();
                csvProvider.SaveTimeSeries19CovidCombinedFile();
                csvProvider.SaveKeyCountriesPivotedFile();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Error during processing {e}");
            }

            await new HostBuilder()
                .ConfigureServices(
                    (hostContext, services) =>
                    {
                        services.AddSingleton(new CsvSchedulerConfig()
                        {
                            PathToCsvFiles = pathToCsvFiles,
                            PathToJsonDestination = pathToJsonDestination
                        });
                        services.AddLogging();
                        services.AddHostedService<SchedulerService>();
                    })
                .ConfigureLogging((hostContext, configLogging) =>
                {
                    configLogging.AddConsole();
                    configLogging.AddDebug();
                })
                .RunConsoleAsync();

        }

        static void laodParameters(string[] args, ref string pathToCSV, ref string pathToJsonDestination, ref string webMode)
        {
            for (int i = 0; i < args.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (args[i] != null)
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
                    case 2:
                        if (args[i] != null)
                        {
                            webMode = args[i];
                        }
                        else
                        {
                            webMode = "false";
                        }

                        break;

                }
            }
        }
    }
}