using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [ForeignKey("VFieldOfStudyId")]
        public int FieldOfStudyId { get; set; }
        public virtual FieldOfStudy VFieldOfStudyId { get; set; }
        public int Semester { get; set; }
        [ForeignKey("VApplicationUser")]
        public string UserId { set; get; }
        public virtual ApplicationUser VApplicationUser { get; set; }
    }
}
