using System.ComponentModel.DataAnnotations;

namespace AcademiaHub.Models
{
    public class Parent
    {
        [Key]
        public int ParentID { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherMobile { get; set; }
        public string FatherEmail { get; set; }
        public string FatherAddress { get; set; }
        public string MotherName { get; set; }
        public string MotherOccupation { get; set; }
        public string MotherMobile { get; set; }
        public string MotherEmail { get; set; }
        public string MotherAddress { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}
