using Autofac;
using Covid19Api.Controllers;
using Covid19Api.Repositories;
using Covid19Api.Repositories.Interfaces;
using Covid19Api.Services;
using Covid19Api.Services.Interfaces;

namespace Covid19Api.autofac
{
    public class CsvModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CsvRepository>().As<ICsvRepository>();
            builder.RegisterType<CsvService>().As<ICsvService>();
        }
    }
}