using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Filler.Filling
{
    public static class StudentGroupCourseSeed
    {
        public static void SeedStudentGroupsStudent(this CespContext context)
        {
            var groupScheduleAndPrice = context
                .GroupBunches
                .FirstOrDefault(grb => grb.Name == "РАСПИСАНИЕ И ЦЕНЫ");

            if (context.StudentGroups.Any(
                gr => gr.GroupBunchId == groupScheduleAndPrice.Id))
            {
                return;
            }
            
            var courseIntensive = context.Courses.FirstOrDefault(c => c.Name == "Интенсивный курс испанского");
            var timeUnitAH = context.TimeUnits.FirstOrDefault(u => u.Name == "ак.ч");
            var timeUnitW = context.TimeUnits.FirstOrDefault(u => u.Name == "нед");
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseIntensive.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Интенсивный летний курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "с понедельника по четверг",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 4.5,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 19000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                    DiscountPer = 20,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion 
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseIntensive.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Интенсивный летний курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "с понедельника по четверг",
                    StartLessonTime = new TimeSpan(12, 15, 0),
                    EndLessonTime = new TimeSpan(15, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 4.5,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 19500,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                    DiscountPer = 20,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion 
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseIntensive.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Интенсивный летний курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "с понедельника по четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 4.5,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 20000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion 
            
            // Полуинтенсив            
            #region 
            {
                var group = new StudentGroupDto
                {
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Курс полуинтенсив",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "понедельник, среда, пятница",
                    StartLessonTime = new TimeSpan(12, 0, 0),
                    EndLessonTime = new TimeSpan(14, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 8,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 20000,
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
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Курс полуинтенсив",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "понедельник, среда, пятница",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 8,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price = new PriceDto
                {
                    Cost = 23000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price);
                context.SaveChanges();
            }
            #endregion 
            
            //Стандартный курс
            
            var courseStandart = context.Courses.FirstOrDefault(c => c.Name == "Стандартный курс испанского");
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "понедельник, среда",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 9,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 21000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 11750,
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
                    CourseId = courseStandart.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "вторник, четверг",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 9,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 21000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 11750,
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
                    CourseId = courseStandart.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "понедельник, среда",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 9,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

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
                    Cost = 12750,
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
                    CourseId = courseStandart.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "вторник, четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 9,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

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
                    Cost = 12750,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion 
            
            // Курс выходного дня
            var courseWeekend = context.Courses.FirstOrDefault(c => c.Name == "Курс выходного дня");
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "суббота",
                    StartLessonTime = new TimeSpan(10, 0, 0),
                    EndLessonTime = new TimeSpan(14, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 12,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 26000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 14250,
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
                    CourseId = courseWeekend.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
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
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 12,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 26000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 14250,
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
                    CourseId = courseWeekend.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
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
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 12,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 26000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 14250,
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
                    CourseId = courseWeekend.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Стандартный курс",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "воскресенье",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var durationW = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 12,
                    TimeUnitId = timeUnitW.Id, 
                };
                context.GroupDurations.Add(durationW);
                context.SaveChanges();
                var durationAH = new GroupDurationDto
                {
                    StudentGroupId = group.Id,
                    Duration = 60,
                    TimeUnitId = timeUnitAH.Id, 
                };
                context.GroupDurations.Add(durationAH);
                context.SaveChanges();

                var price1 = new PriceDto
                {
                    Cost = 26000,
                    PaymentPeriod = "курс",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 14250,
                    PaymentPeriod = "1/2 курса",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
            }
            #endregion 
            
            // Индивидуальные занятия и мини-группы
            var courseIndividual = context.Courses.FirstOrDefault(c => c.Name.Contains("Индивидуальные занятия"));
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseIndividual.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Индивидуальные занятия и мини-группы",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "будни до 18.00",
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var price1 = new PriceDto
                {
                    Cost = 1400,
                    PaymentPeriod = "1 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 800,
                    PaymentPeriod = "2 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
                var price3 = new PriceDto
                {
                    Cost = 500,
                    PaymentPeriod = "3 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price3);
                context.SaveChanges();
                var price4 = new PriceDto
                {
                    Cost = 400,
                    PaymentPeriod = "4-5 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price4);
                context.SaveChanges();
            }
            #endregion
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseIndividual.Id,
                    IsWorking = true,
                    IsAvailable = true,
                    Description = "Индивидуальные занятия и мини-группы",
                    GroupBunchId = groupScheduleAndPrice.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "будни после 18.00 и выходные",
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
                
                var price1 = new PriceDto
                {
                    Cost = 1600,
                    PaymentPeriod = "1 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price1);
                context.SaveChanges();
                var price2 = new PriceDto
                {
                    Cost = 900,
                    PaymentPeriod = "2 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price2);
                context.SaveChanges();
                var price3 = new PriceDto
                {
                    Cost = 600,
                    PaymentPeriod = "3 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price3);
                context.SaveChanges();
                var price4 = new PriceDto
                {
                    Cost = 450,
                    PaymentPeriod = "4-5 чел.",
                    CurrencyId = (int) CurrencyEnum.Rub,
                    StudentGroupId = group.Id,
                };
                context.Prices.Add(price4);
                context.SaveChanges();
            }
            #endregion
            
        }
    }
}