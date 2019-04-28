using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Filler.Filling
{
    public static class StudentGroupCatalanSeed
    {
        public static void SeedStudentGroupsCatalan(this CespContext context)
        {
            var bunch = context
                .GroupBunches
                .FirstOrDefault(grb => grb.Name == "Группы каталонского языка");
            
            
            if (context.StudentGroups.Any(
                gr => gr.GroupBunchId == bunch.Id))
            {
                return;
            }
            
            var course = context.Courses.FirstOrDefault(c => c.Name == "Каталонский язык");
            
            var levelA1 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A1");
            var levelB1 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "B1.1");
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = bunch.Id,
                    Description = "(30-36 ак.ч.)",
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Пятница",
                    StartLessonTime = new TimeSpan(18, 45, 0),
                    EndLessonTime = new TimeSpan(21, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
 
                var price = new PriceDto
                {
                    Cost = 18000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion  
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB1.Id,
                    GroupBunchId = bunch.Id,
                    Description = "(30-36 ак.ч.)",
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(14, 0, 0),
                    EndLessonTime = new TimeSpan(17, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
 
                var price = new PriceDto
                {
                    Cost = 18000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion  
            
        }
    }
}