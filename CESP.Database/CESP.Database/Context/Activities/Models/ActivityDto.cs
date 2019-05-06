using System;
using CESP.Database.Context.Files.Models;

namespace CESP.Database.Context.Activities.Models
{
    public class ActivityDto
    {
        public int Id { get; set; }
        
        public string SysName { get; set; }
        public string Name { get; set; }
        public string ShortInfo { get; set; }
        public string Info { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        
        public int? PhotoId { get; set; }
        public FileDto Photo { get; set; }
    }
}