using System;

namespace CESP.Database.Context.Press.Models
{
    public class PressDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string BlogUrl { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        // todo photo
    }
}