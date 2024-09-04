using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaHub.Models
{
    public class Student
    {
        [Key]
        public int EnrollmentNo { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Photo { get; set; }

        // Foreign Key Properties
        public int ClassID { get; set; }
        public int SectionID { get; set; }
        public int ParentID { get; set; }
        public int GuardianID { get; set; }
        public int HostelID { get; set; }
        public int HostelerID { get; set; }

        // Navigation Properties
        public Class Class { get; set; }
        public Section Section { get; set; }
        public Parent Parent { get; set; }
        public Guardian Guardian { get; set; }
        public Hostel Hostel { get; set; }
        public Hosteler Hosteler { get; set; }

        public string MotherTongue { get; set; }
        public string Religion { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Village { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Mobile { get; set; }
        public string AadharNumber { get; set; }
        public bool IsActive { get; set; }

        // Collection Navigation Property
        public ICollection<Hosteler> Hostelers { get; set; }
    }
}
