using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CsvParser.Models.Models;
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
       private readonly CsvSchedulerConfig _config;
        public  SchedulerService(ILogger<SchedulerService> logger, CsvSchedulerConfig config)
        {
            this._config = config;
            this._logger = logger;
            this._schedulerFactory = new StdSchedulerFactory();
            this._scheduler = this._schedulerFactory.GetScheduler().Result;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {

            await this._scheduler.Start(cancellationToken);
            _logger.LogInformation("Csv Scheduler");
            IJobDetail job = JobBuilder.Create<ParseCsvFileJob>()
                .WithIdentity("parseCsvJob", "group1")
                .UsingJobData("PathToCsvFiles", this._config.PathToCsvFiles)
                .UsingJobData("PathToJsonDestination", this._config.PathToJsonDestination)
                .Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("triggerCsvJob", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(20)
                    .RepeatForever())
                .Build();

            await this._scheduler.ScheduleJob(job, trigger, cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await this._scheduler.Shutdown(cancellationToken);
        }

        public async void Dispose()
        {
        }
    }
}
