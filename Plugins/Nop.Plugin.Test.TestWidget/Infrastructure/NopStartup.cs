using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Test.TestWidget.Services;

namespace Nop.Plugin.Tax.CountryStateZip.Infrastructure
{
    public class NopStartup : INopStartup
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ITestDataService, TestDataService>();
        }

        public void Configure(IApplicationBuilder application)
        {

        }

        public int Order
        {
            get { return 1; }
        }
    }
}
