using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Lecturer
    {
        [Key]
        public int Id { get; set; }
        public string AcademicTitle { get; set; }
        [ForeignKey("VApplicationUser")]
        public string UserId { set; get; }
        public virtual ApplicationUser VApplicationUser { get; set; }
    }
}
