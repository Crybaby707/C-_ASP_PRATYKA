using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyTested.AspNetCore.Mvc;
using TVShow.Data;
using TVShow.Web.Tests.InMemory;

namespace TVShow.Web.Tests
{
    public class TestStartup //: Startup
    {
        //public TestStartup(IConfiguration configString) : base(configString)
        //{
        //}

        //public void ConfigureTestServices(IServiceCollection services)
        //{
        //    base.ConfigureServices(services);

        //    services.ReplaceScoped<ITVShowDbContext, MockTVShowDbContext>();
        //    // Replace only your own custom services. The ASP.NET Core ones 
        //    // are already replaced by MyTested.AspNetCore.Mvc. 
        //    //services.ReplaceScoped<IRoleBL, MockRoleBL>();
        //}
    }
}
