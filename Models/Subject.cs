using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }
        [ForeignKey("VFieldOfStudyId")]
        public int FieldOfStudyId { get; set; }
        public virtual FieldOfStudy VFieldOfStudyId { get; set; }

    }
}
