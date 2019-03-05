using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CESP.Database.Context
{
    public class CespContextFactory: IDesignTimeDbContextFactory<CespContext>
    {
        public CespContext CreateDbContext(string[] args)
        {
            var envName = "Local"; //Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
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
            var migrationsAssemblyName = Assembly.GetAssembly(typeof(CespContextFactory)).FullName;
            
            var optionsBuilder = new DbContextOptionsBuilder<CespContext>();
            optionsBuilder.UseNpgsql(cespConnectionString,
                b => b.MigrationsAssembly(migrationsAssemblyName));

            return new CespContext(optionsBuilder.Options);
        }
    }
}