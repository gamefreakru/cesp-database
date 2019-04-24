using System;
using System.Collections.Generic;
using CESP.Database.Context.Payments.Models;

namespace CESP.Database.Context.Education.Models
{
    public class StudentGroupDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        
        public DateTime? Start { get; set; }
        public bool IsAvailable { get; set; }

        public bool IsWorking { get; set; }
        public string Description { get; set; }
        public int? CountStudentsMin { get; set; }
        public int? CountStudentsMax { get; set; }     
    }
}