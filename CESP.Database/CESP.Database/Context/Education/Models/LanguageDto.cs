using System.ComponentModel.DataAnnotations.Schema;

namespace CESP.Database.Context.Education.Models
{
    [Table("language")]
    public class LanguageDto
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("color")]
        public string Color { get; set; }
    }
}