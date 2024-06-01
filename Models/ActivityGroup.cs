using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class ActivityGroup
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("VStudentId"), Required]
        public int StudentId { get; set; }
        public virtual Student VStudentId { get; set; }
        [ForeignKey("VLecturerId"), Required]
        public int LecturerId { get; set; }
        public virtual Lecturer VLecturerId { get; set; }
        [ForeignKey("VSubjectId"), Required]
        public int SubjectId { get; set; }
        public virtual Subject VSubjectId { get; set; }
        [Required]
        public int GroupNumber { get; set; }
        [Range(1, 7), Required]
        public int ClassDay { get; set; }
        [Required]
        public TimeSpan TimeOfClasses { get; set; }
    }
}
