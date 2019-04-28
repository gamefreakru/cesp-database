using System;
using System.Linq;
using CESP.Database.Context;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Filler.Filling
{
    public static class StudentGroupAdultSeed
    {
        public static void SeedStudentGroupsAdult(this CespContext context)
        {
            var groupAdult = context
                .GroupBunches
                .FirstOrDefault(grb => grb.Name == "Взрослые группы");
            
            if (context.StudentGroups.Any(
               gr => gr.GroupBunchId == groupAdult.Id))
            {
                return;
            }

            var timeGroupMorning = context
                .GroupTimes
                .FirstOrDefault(gt => gt.Name == "Утренний курс");
            var timeGroupDay = context
                .GroupTimes
                .FirstOrDefault(gt => gt.Name == "Дневной курс");
            var timeGroupEvening = context
                .GroupTimes
                .FirstOrDefault(gt => gt.Name == "Вечерний курс");
            var timeGroupWeekend= context
                .GroupTimes
                .FirstOrDefault(gt => gt.Name == "Курс выходного дня");
            
            
            // Испанский язык — Начальный уровень (A1)
            var levelA1 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A1");
            var courseStandart = context.Courses.FirstOrDefault(c => c.Name == "Стандартный курс испанского");
            var courseWeekend = context.Courses.FirstOrDefault(c => c.Name == "Курс выходного дня");
            
            #region 
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 29),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Пятница",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion

            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 2, 13),
                    IsWorking = true,
                    IsAvailable = false,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 2, 19),
                    IsWorking = true,
                    IsAvailable = false,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupDay.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(12, 15, 0),
                    EndLessonTime = new TimeSpan(15, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 18),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 2, 16),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(12, 0, 0),
                    EndLessonTime = new TimeSpan(16, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 3, 16),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA1.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Воскресенье",
                    StartLessonTime = new TimeSpan(14, 30, 0),
                    EndLessonTime = new TimeSpan(18, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            //Испанский язык — Базовый уровень (A2.1, А2.2)
            var levelA21 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A2.1");
            var levelA22 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "A2.2");
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 4),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupDay.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(12, 00, 0),
                    EndLessonTime = new TimeSpan(14, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 16),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupDay.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(12, 15, 0),
                    EndLessonTime = new TimeSpan(15, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 4, 8),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 4, 17),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Среда, Пятница",
                    StartLessonTime = new TimeSpan(9, 0, 0),
                    EndLessonTime = new TimeSpan(11, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 2, 12),
                    IsWorking = true,
                    IsAvailable = false,
                    LanguageLevelId = levelA21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 21),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 21),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 4, 23),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 14),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Воскресенье",
                    StartLessonTime = new TimeSpan(10, 30, 0),
                    EndLessonTime = new TimeSpan(14, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 14),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelA22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Воскресенье",
                    StartLessonTime = new TimeSpan(11, 0, 0),
                    EndLessonTime = new TimeSpan(14, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            // Испанский язык — Продвинутый уровень (B1, B2)
            var levelB11 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "B1.1");
            var levelB21 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "B2.1");
            var levelB22 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "B2.2");
            
            var levelB23 = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "B2.3");
            
            var levelC = context
                .LanguageLevels
                .FirstOrDefault(l => l.Name == "C1.1");
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 2, 12),
                    IsWorking = true,
                    IsAvailable = false,
                    LanguageLevelId = levelB11.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(11, 0, 0),
                    EndLessonTime = new TimeSpan(13, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 4, 3),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB11.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 13),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(10, 30, 0),
                    EndLessonTime = new TimeSpan(14, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
  
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 12),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, четверг",
                    StartLessonTime = new TimeSpan(11, 0, 0),
                    EndLessonTime = new TimeSpan(13, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 3, 25),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupEvening.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Понедельник, Среда",
                    StartLessonTime = new TimeSpan(19, 0, 0),
                    EndLessonTime = new TimeSpan(21, 45, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseStandart.Id,
                    Start = new DateTime(2019, 2, 26),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupMorning.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Вторник, Четверг",
                    StartLessonTime = new TimeSpan(9, 30, 0),
                    EndLessonTime = new TimeSpan(12, 15, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 1, 19),
                    IsWorking = true,
                    IsAvailable = false,
                    LanguageLevelId = levelB21.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(10, 30, 0),
                    EndLessonTime = new TimeSpan(14, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 20),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(10, 30, 0),
                    EndLessonTime = new TimeSpan(14, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 3, 16),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB22.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 3, 16),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelB23.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Суббота",
                    StartLessonTime = new TimeSpan(15, 0, 0),
                    EndLessonTime = new TimeSpan(19, 0, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
            
            #region
            {
                var group = new StudentGroupDto
                {
                    CourseId = courseWeekend.Id,
                    Start = new DateTime(2019, 4, 12),
                    IsWorking = true,
                    IsAvailable = true,
                    LanguageLevelId = levelC.Id,
                    GroupBunchId = groupAdult.Id,
                    GroupTimeId = timeGroupWeekend.Id,
                };
                context.StudentGroups.Add(group);
                context.SaveChanges();

                var schedule = new ScheduleDto
                {
                    StudentGroupId = group.Id,
                    Day = "Пятница",
                    StartLessonTime = new TimeSpan(19, 30, 0),
                    EndLessonTime = new TimeSpan(21, 30, 0),
                };
                context.Schedules.Add(schedule);
                context.SaveChanges();
            }
            #endregion
        }
    }
}