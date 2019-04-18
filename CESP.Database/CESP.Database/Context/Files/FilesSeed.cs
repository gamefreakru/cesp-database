using Microsoft.EntityFrameworkCore;
using static CESP.Database.Context.Files.TeachersFilesSeed;

namespace CESP.Database.Context.Files
{
    public static class FilesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedTeachers(modelBuilder);
        }
    }
}