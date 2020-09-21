using System;
using System.IO;
using System.Threading.Tasks;
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
            //string webMode = "";
            //string pathToCsvFiles = "";
            //string pathToJsonDestination = "";
            //CsvService csvProvider;
            
            
            //try
            //{
            //    laodParameters(args, ref pathToCsvFiles, ref pathToJsonDestination, ref webMode);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    return;
            //}

            //if (webMode == "true")
            //{
            //    csvProvider = new CsvService(pathToCsvFiles, pathToJsonDestination,
            //        new CsvProvider(new GitFileProvider()));
            //}
            //else 
            //{
            //    csvProvider = new CsvService(pathToCsvFiles, pathToJsonDestination,
            //        new CsvProvider(new ReadFileProvider()));
            //}

            

            //try
            //{
            //    csvProvider.SaveWorldWideAggregatedFile();
            //    csvProvider.SaveCountriesAggregatedFile();
            //    csvProvider.SaveTimeSeries19CovidCombinedFile();
            //    csvProvider.SaveKeyCountriesPivotedFile();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"ERROR: Error during processing {e}");
            //}

            await new HostBuilder()
                .ConfigureServices(
                (hostContext, services) =>
                {
                    services.AddLogging();
                    services.AddHostedService<SchedulerService>();
                })
                .ConfigureLogging((hostContext, configLogging) =>
                {
                    configLogging.AddConsole();
                    configLogging.AddDebug();
                })
                .RunConsoleAsync();
                
            //LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());

            //StdSchedulerFactory factory = new StdSchedulerFactory();
            //IScheduler scheduler = await factory.GetScheduler();

            //// and start it off
            //await scheduler.Start();

            //IJobDetail job = JobBuilder.Create<ParseCsvFileJob>()
            //    .WithIdentity("job1", "group1")
            //    .Build();

            //ITrigger trigger = TriggerBuilder.Create()
            //    .WithIdentity("trigger1", "group1")
            //    .StartNow()
            //    .WithSimpleSchedule(x => x
            //        .WithIntervalInSeconds(10)
            //        .RepeatForever())
            //    .Build();

            //await scheduler.ScheduleJob(job, trigger);

            //await Task.Delay(TimeSpan.FromSeconds(60));

            //// and last shut down the scheduler when you are ready to close your program
            //await scheduler.Shutdown();

            //Console.WriteLine("Press any key to close the application");
            //Console.ReadKey();

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