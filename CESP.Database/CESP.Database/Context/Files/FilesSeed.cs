using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Files.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Common
{
    public static class FilesSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedTeachers(modelBuilder);
        }

        private static void SeedTeachers(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 1,
                    Info = "Йосу",
                    Name = "teachers/josu-foto.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 2,
                    Info = "Анхель",
                    Name = "teachers/anhel-photo.jpeg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 3,
                    Info = "Рафаэль",
                    Name = "teachers/rafael_200x193.png",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 4,
                    Info = "Альберто",
                    Name = "teachers/alberto.jpg",
                });

            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 5,
                    Info = "Хулио",
                    Name = "teachers/julio.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 6,
                    Info = "Алехо",
                    Name = "teachers/alejo.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 7,
                    Info = "Пабло",
                    Name = "teachers/pablo.jpeg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 8,
                    Info = "Джонатан",
                    Name = "teachers/jonatan.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 9,
                    Info = "Юлия",
                    Name = "teachers/julia.png",
                });
        }
    }
}