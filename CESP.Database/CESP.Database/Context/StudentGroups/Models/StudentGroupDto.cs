using System;
using CESP.Database.Context.Education.Models;

namespace CESP.Database.Context.StudentGroups.Models
{
    public class StudentGroupDto
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public CourseDto Course { get; set; }
                
        public DateTime? Start { get; set; }
        public bool IsAvailable { get; set; }

        public bool IsWorking { get; set; }
        public string Description { get; set; }
        public int? CountStudentsMin { get; set; }
        public int? CountStudentsMax { get; set; }     
        
        public int? GroupTimeId { get; set; }
        public GroupTimeDto GroupTime { get; set; }

        public int? GroupBunchId { get; set; }
        public GroupBunchDto Bunch { get; set; }

        public int? LanguageLevelId { get; set; }
        public LanguageLevelDto LanguageLevel { get; set; }
    }
}