using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    [Keyless]
    public class LecturerSubject
    {
        [ForeignKey("VLecturerId")]
        public int LecturerId { get; set; }
        public virtual Lecturer VLecturerId { get; set; }
        [ForeignKey("VSubjectId")]
        public int SubjectId { get; set; }
        public virtual Subject VSubjectId { get; set; }
    }
}
