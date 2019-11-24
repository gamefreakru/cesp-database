using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Filler.Filling
{
    public static class StudentGroupYoungSeed
    {
        public static void SeedStudentGroupsYoung(this CespContext context)
        {
            var groupYoung = context
                .GroupBunches
                .FirstOrDefault(grb => grb.Name == "Молодежные и подростковые группы");
            
            if (context.StudentGroups.Any(
                gr => gr.GroupBunchId == groupYoung.Id))
            {
                return;
            }
            
            var timeGroupWeekend= context
                .GroupTimes
                .FirstOrDefault(gt => gt.Name == "Курс выходного дня");
            var course = context.Courses.FirstOrDefault(c => c.Name == "Испанский для детей");
            var levelA1 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A1");
            var levelA2 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A2.1");
//            var timeUnitAH = context.TimeUnits.FirstOrDefault(u => u.Name == "ак.ч");
//            var timeUnitW = context.TimeUnits.FirstOrDefault(u => u.Name == "нед");
//            var timeUnitM = context.TimeUnits.FirstOrDefault(u => u.Name == "мес");
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 24),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Испанский язык для подростков (12-15 лет)",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id, 
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id, 
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id, 
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion 
        
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 24),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA2.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Испанский язык для подростков (12-15 лет)",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id, 
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id, 
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id, 
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion

            #region

            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 18),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Молодежная группа испанского языка (15-22 годя) ",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(10, 0, 0),
                    EndLessonTime = new TimeSpan(14, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();

//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id,
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id,
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id,
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }

            #endregion
                                  
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 18),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA2.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Молодежная группа испанского языка (15-22 годя) ",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(10, 0, 0),
                    EndLessonTime = new TimeSpan(14, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id, 
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id, 
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id, 
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 24),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Молодежная группа испанского языка (15-22 годя) ",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id, 
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id, 
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id, 
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = course.Id,
                    Start = new DateTime(2019, 9, 24),
                    IsWorking = false,
                    IsAvailable = true,
                    LanguageLevelId = levelA2.Id,
                    GroupBunchId = groupYoung.Id,
                    Description = "Молодежная группа испанского языка (15-22 годя) ",
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
//                var durationAH = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 60,
//                    TimeUnitId = timeUnitAH.Id, 
//                };
//                context.GroupDurations.Add(durationAH);
//                context.SaveChanges();
//                var durationW = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 12,
//                    TimeUnitId = timeUnitW.Id, 
//                };
//                context.GroupDurations.Add(durationW);
//                context.SaveChanges();
//                var durationM = new GroupDurationDto
//                {
//                    StudentGroupId = group.Id,
//                    Duration = 3,
//                    TimeUnitId = timeUnitM.Id, 
//                };
//                context.GroupDurations.Add(durationM);
//                context.SaveChanges();


                var price1 = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 12500,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion
        }
    }
}