using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CsvParser.Providers;
using CsvParser.Scheduler.Interfaces;
using CsvParser.Services;
using Quartz;

namespace CsvParser.Scheduler.Jobs
{
   public class ParseCsvFileJob : IParseFileJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            var csvProvider = new CsvService(
                dataMap.GetString("PathToCsvFiles"),
                dataMap.GetString("PathToJsonDestination"),
                new CsvProvider(new GitFileProvider())
                );

            try
            {
                csvProvider.SaveWorldWideAggregatedFile();
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Error during processing {e}");
            }
        }
    }
}
