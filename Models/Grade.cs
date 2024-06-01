using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Value { get; set; }
        [Required, ForeignKey("VSubjectId")]
        public int SubjectId { get; set; }
        public virtual Subject VSubjectId { get; set; }
        [Required, ForeignKey("VLecturerId")]
        public int LecturerId { get; set; }
        public virtual Lecturer VLecturerId { get; set; }
        [Required, ForeignKey("VStudentId")]
        public int StudentId { get; set; }
        public virtual Student VStudentId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }
    }
}
