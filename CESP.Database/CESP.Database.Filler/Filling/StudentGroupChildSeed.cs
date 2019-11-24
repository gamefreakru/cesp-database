using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Filler.Filling
{
    public static class StudentGroupChildSeed
    {
        public static void SeedStudentGroupsChild(this CespContext context)
        {
            var groupChild = context
                .GroupBunches
                .FirstOrDefault(grb => grb.Name == "Детские группы");

            if (context.StudentGroups.Any(
                gr => gr.GroupBunchId == groupChild.Id))
            {
                return;
            }

            var course = context.Courses.FirstOrDefault(c => c.Name == "Испанский для детей");
            var levelA1 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A1");
            var levelA2 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A2.1");
           // var timeUnit = context.TimeUnits.FirstOrDefault(u => u.Name == "ак.ч");
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2018, 9, 18),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupChild.Id,
                    Description = "9 - 11 лет",
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(14, 0, 0),
                    EndLessonTime = new TimeSpan(16, 10, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var duration = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 2.5,
//                    TimeUnitId = timeUnit.Id, 
//                };
//                context.GroupDurations.Add(duration);
//                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 1300,
                    PaymentPeriod = "урок",
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
                    Start = new DateTime(2018, 9, 18),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA2.Id,
                    GroupBunchId = groupChild.Id,
                    Description = "9 - 11 лет",
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(14, 30, 0),
                    EndLessonTime = new TimeSpan(16, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var duration = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 2.5,
//                    TimeUnitId = timeUnit.Id, 
//                };
//                context.GroupDurations.Add(duration);
//                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 1300,
                    PaymentPeriod = "урок",
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
                    Start = new DateTime(2018, 9, 18),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA2.Id,
                    GroupBunchId = groupChild.Id,
                    Description = "7 - 8 лет",
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(14, 30, 0),
                    EndLessonTime = new TimeSpan(16, 10, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var duration = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 2,
//                    TimeUnitId = timeUnit.Id, 
//                };
//                context.GroupDurations.Add(duration);
//                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 1300,
                    PaymentPeriod = "урок",
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