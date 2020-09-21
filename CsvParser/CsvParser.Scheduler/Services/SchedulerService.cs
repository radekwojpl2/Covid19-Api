using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CsvParser.Scheduler.Jobs;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using LogLevel = Quartz.Logging.LogLevel;

namespace CsvParser.Scheduler.Services
{
   public class SchedulerService: IHostedService, IDisposable
   {

       private readonly ILogger _logger;
       private readonly StdSchedulerFactory _schedulerFactory;
       private readonly IScheduler _scheduler;
        public  SchedulerService(ILogger<SchedulerService> logger)
        {
            this._logger = logger;
            this._schedulerFactory = new StdSchedulerFactory();
            this._scheduler = this._schedulerFactory.GetScheduler().Result;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {

            await this._scheduler.Start();
            _logger.LogInformation("elko");
            IJobDetail job = JobBuilder.Create<ParseCsvFileJob>()
                .WithIdentity("job1", "group1")
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(10)
                    .RepeatForever())
                .Build();

            await this._scheduler.ScheduleJob(job, trigger, cancellationToken);

            await Console.Out.WriteLineAsync("papa");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await this._scheduler.Shutdown(cancellationToken);

            await Console.Out.WriteLineAsync("Greetings from HelloJob!");
        }

        public async void Dispose()
        {
            await Console.Out.WriteLineAsync("papa");
        }
    }
}
