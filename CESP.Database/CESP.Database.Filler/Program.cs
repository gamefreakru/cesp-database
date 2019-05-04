using System;
using CESP.Database.Context;
using CESP.Database.Filler.Filling;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CESP.Database.Filler
{
    class Program
    {
        static void Main(string[] args)
        {
            var envName = "Local";//Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
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
            context.SeedTeachers();
            context.SeedFeedback();

            context.SeedStudentGroupsAdult();
            context.SeedStudentGroupsChild();
            context.SeedStudentGroupsYoung();
            context.SeedStudentGroupsCatalan();

            context.SeedStudentGroupsStudent();

            context.SeedActivities();
            context.SeeSpeakingClub();
        }
    }
}