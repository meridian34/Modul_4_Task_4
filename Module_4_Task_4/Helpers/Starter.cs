using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Modul_4_Task_4.Helpers
{
    public class Starter
    {
        public async Task Start()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appconfig.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuider = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuider
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new ApplicationContext(options))
            {
                LazyLoading lazyLoading = new LazyLoading(db);
                await lazyLoading.FirstTask();
                await lazyLoading.SecondTask();
                await lazyLoading.ThirdTask();                
            }
        }
    }
}
