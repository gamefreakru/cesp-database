using System;

namespace CESP.Database.Context.Activities.Models
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortInfo { get; set; }
        public string Info { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        // todo photes
    }
}