using System;
using CESP.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static CESP.Resources.Database.CoursesSeed;

namespace CESP.Resources
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{envName}.json", true)
                .AddEnvironmentVariables()
                .Build();

            var cespConnectionString = config
                .GetSection("ConnectionStrings")
                .GetValue<string>("CespDb");

#if DEBUG
            Console.WriteLine($"EnvName = '{envName}'");
            Console.WriteLine($"ConnectionString = '{cespConnectionString}'");
#endif

            var optionsBuilder = new DbContextOptionsBuilder<CespContext>();
            optionsBuilder.UseNpgsql(cespConnectionString);

            var context = new CespContext(optionsBuilder.Options);

            context.SeedCourses(); 
        }
    }
}