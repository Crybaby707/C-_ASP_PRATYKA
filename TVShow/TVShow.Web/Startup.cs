using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TVShow.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace TVShow.Web
{
    public class Startup
    {
        private IConfigurationRoot _configString;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TVShowDbContext>(options => options.UseMySQL(_configString.GetConnectionString("DefaultConnection")));
        }

        public Startup(IHostingEnvironment hostEnv)
        {

            _configString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("appsettings.json").Build();

        }
    }
}
