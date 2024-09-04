using System.ComponentModel.DataAnnotations;

namespace AcademiaHub.Models
{
    public class Guardian
    {
        [Key]
        public int GuardianID { get; set; }
        public string GuardianName { get; set; }
        public string GuardianOccupation { get; set; }
        public string GuardianMobile { get; set; }
        public string GuardianEmail { get; set; }
        public string GuardianAddress { get; set; }
        public string RelationshipWithChild { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}
