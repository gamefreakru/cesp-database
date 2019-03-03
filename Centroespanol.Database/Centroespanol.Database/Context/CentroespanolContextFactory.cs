using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Centroespanol.Database.Context
{
    public class CentroespanolContextFactory: IDesignTimeDbContextFactory<CentroespanolContext>
    {
        public CentroespanolContext CreateDbContext(string[] args)
        {
            var envName = "Local";//Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{envName}.json", true)
                .AddEnvironmentVariables()
                .Build();

            var supplierConnectionString = config
                .GetSection("ConnectionStrings")
                .GetValue<string>("CentroespDb");

#if DEBUG
            Console.WriteLine($"EnvName = '{envName}'");
            Console.WriteLine($"ConnectionString = '{supplierConnectionString}'");
#endif
            var migrationsAssemblyName = Assembly.GetAssembly(typeof(CentroespanolContextFactory)).FullName;
            
            var optionsBuilder = new DbContextOptionsBuilder<CentroespanolContext>();
            optionsBuilder.UseNpgsql(supplierConnectionString,
                b => b.MigrationsAssembly(migrationsAssemblyName));

            return new CentroespanolContext(optionsBuilder.Options);
        }
    }
}