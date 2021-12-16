using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyTested.AspNetCore.Mvc;
using TVShows.Data;
using TVShows.Web.Tests.InMemory;

namespace TVShows.Web.Tests
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        public void ConfigureTestServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.ReplaceScoped<ITVShowsDbContext, MockTVShowsDbContext>();
            // Replace only your own custom services. The ASP.NET Core ones 
            // are already replaced by MyTested.AspNetCore.Mvc. 
            //services.ReplaceScoped<IRoleBL, MockRoleBL>();
        }
    }
}
