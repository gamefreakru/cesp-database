namespace CESP.Database.Context.StudentGroups.Models
{
    public class GroupDurationDto
    {
        public int Id { get; set; }

        public double Duration { get; set; }

        public int TimeUnitId { get; set; }
        public TimeUnitDto TimeUnit { get; set; }

        public int  StudentGroupId { get; set; }
        public StudentGroupDto Group { get; set; }
    }
}