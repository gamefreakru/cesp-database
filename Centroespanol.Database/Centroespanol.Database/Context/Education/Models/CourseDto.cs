namespace Centroespanol.Database.Context.Education.Models
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string ShortInfo { get; set; }
        public string Info { get; set; }
        public string NativeInfo { get; set; }
        public string DurationInfo { get; set; }
        public string InstructionPdf { get; set; }
        // todo pictures
    }
}