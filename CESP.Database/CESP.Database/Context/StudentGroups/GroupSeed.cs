using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.StudentGroups.Models;
using Microsoft.EntityFrameworkCore;

namespace CESP.Database.Context.StudentGroups
{
    public static class GroupSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedGroupTimesTable(modelBuilder);
            SeedGroupBunchTable(modelBuilder);
           // SeedTimeUnitTable(modelBuilder);
        }

//        private static void SeedTimeUnitTable(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<TimeUnitDto>()
//                .HasData(new TimeUnitDto
//                {
//                    Id = 1,
//                    Name = "ак.ч",
//                });
//
//            modelBuilder.Entity<TimeUnitDto>()
//                .HasData(new TimeUnitDto
//                {
//                    Id = 2,
//                    Name = "нед",
//                });
//
//            modelBuilder.Entity<TimeUnitDto>()
//                .HasData(new TimeUnitDto
//                {
//                    Id = 3,
//                    Name = "мес",
//                });
//        }

        private static void SeedGroupBunchTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupBunchDto>()
                .HasData(new GroupBunchDto
                {
                    Id = 1,
                    Name = "Взрослые группы",
                    SysName = "adult",
                });

            modelBuilder.Entity<GroupBunchDto>()
                .HasData(new GroupBunchDto
                {
                    Id = 2,
                    Name = "Детские группы",
                    SysName = "children",
                });

            modelBuilder.Entity<GroupBunchDto>()
                .HasData(new GroupBunchDto
                {
                    Id = 3,
                    Name = "Молодежные и подростковые группы",
                    SysName = "teen",
                });

            modelBuilder.Entity<GroupBunchDto>()
                .HasData(new GroupBunchDto
                {
                    Id = 4,
                    Name = "Группы каталонского языка",
                    SysName = "catalan",
                });
            modelBuilder.Entity<GroupBunchDto>()
                .HasData(new GroupBunchDto
                {
                    Id = 5,
                    Name = "Расписание и цены",
                    SysName = "schedules",
                });
        }

        private static void SeedGroupTimesTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupTimeDto>()
                .HasData(new GroupTimeDto
                {
                    Id = 1,
                    Name = "Утренний курс",
                });

            modelBuilder.Entity<GroupTimeDto>()
                .HasData(new GroupTimeDto
                {
                    Id = 2,
                    Name = "Дневной курс",
                });

            modelBuilder.Entity<GroupTimeDto>()
                .HasData(new GroupTimeDto
                {
                    Id = 3,
                    Name = "Вечерний курс",
                });

            modelBuilder.Entity<GroupTimeDto>()
                .HasData(new GroupTimeDto
                {
                    Id = 4,
                    Name = "Курс выходного дня",
                });
        }
    }
}