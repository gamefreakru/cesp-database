namespace CESP.Database.Context.StudentGroups.Models
{
    public class GroupBunchDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }

        public int? Priority { get; set; }

        public string SysName { get; set; }
    }
}