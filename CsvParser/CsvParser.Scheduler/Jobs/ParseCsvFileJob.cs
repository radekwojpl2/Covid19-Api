using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CsvParser.Scheduler.Interfaces;
using Quartz;

namespace CsvParser.Scheduler.Jobs
{
   public class ParseCsvFileJob : IParseFileJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }
    }
}
