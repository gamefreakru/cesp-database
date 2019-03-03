using System;
using Centroespanol.Database.Context.Education.Models;

namespace Centroespanol.Database.Context.Education.Models
{
    public class SpeakingClubMeetingDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
        
        public int? TeacherId { get; set; }
        public TeacherDto Teacher { get; set; }
        
        public int? MinLanguageLevelId { get; set; }
        public LanguageLevelDto MinLanguageLevel { get; set; }
        
        public int? MaxLanguageLevelId { get; set; }
        public LanguageLevelDto MaxLanguageLevel { get; set; }

    }
}