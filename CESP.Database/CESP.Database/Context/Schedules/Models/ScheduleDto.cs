using System;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.StudentGroups.Models;

namespace CESP.Database.Context.Schedules.Models
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int StudentGroupId { get; set; }
        public StudentGroupDto StudentGroup { get; set; }
        public string Day { get; set; }
        public TimeSpan StartLessonTime { get; set; }
        public TimeSpan EndLessonTime { get; set; }
    }
}