using System.ComponentModel.DataAnnotations;

namespace AcademiaHub.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
