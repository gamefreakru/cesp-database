using System;

namespace CESP.Database.Context.Users.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Contact { get; set; }

        public DateTime CreateDate { get; set; }
    }
}