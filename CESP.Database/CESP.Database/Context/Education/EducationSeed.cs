using CESP.Database.Context.Education.Models;
using Microsoft.EntityFrameworkCore;

namespace Centroespanol.Database.Context.Education
{
    public static class EducationSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedLanguageLevelsTable(modelBuilder);
        }

        private static void SeedLanguageLevelsTable(ModelBuilder modelBuilder)
        {
            // language_levels
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 1,
                    Name = "A1",
                    Rang = 1,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 2,
                    Name = "A2.1",
                    Rang = 3,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 3,
                    Name = "A2.2",
                    Rang = 4,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 4,
                    Name = "B1.1",
                    Rang = 5,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 5,
                    Name = "B1.2",
                    Rang = 6,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 6,
                    Name = "B2.1",
                    Rang = 7,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 7,
                    Name = "B2.2",
                    Rang = 8,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 8,
                    Name = "B2.3",
                    Rang = 9,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 9,
                    Name = "C1.1",
                    Rang = 10,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 10,
                    Name = "C1.2",
                    Rang = 11,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 11,
                    Name = "C2.1",
                    Rang = 12,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 12,
                    Name = "C2.2",
                    Rang = 13,
                });
            
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 13,
                    Name = "C1+",
                    Rang = 14,
                });
            modelBuilder.Entity<LanguageLevelDto>()
                .HasData(new LanguageLevelDto
                {
                    Id = 14,
                    Name = "C2+",
                    Rang = 15,
                });
        }
    }
}