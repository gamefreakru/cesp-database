using CESP.Database.Context.Files.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.Files
{
    public static class TeachersFilesSeed
    {
        public static void SeedTeachers(ModelBuilder modelBuilder)
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
                    Info = "Алехо",
                    Name = "teachers/alejo.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 6,
                    Info = "Пабло",
                    Name = "teachers/pablo.jpeg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 7,
                    Info = "Джонатан",
                    Name = "teachers/jonatan.jpg",
                });
            modelBuilder.Entity<FileDto>()
                .HasData(new FileDto
                {
                    Id = 8,
                    Info = "Юлия",
                    Name = "teachers/julia.png",
                });
        }
    }
}