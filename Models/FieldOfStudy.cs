using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class FieldOfStudy
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }
    }
}
