using AcademiaHub.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Hosteler
{
    [Key]
    public int HostelerID { get; set; }

    [ForeignKey("Hostel")]
    public int HostelID { get; set; }
    public Hostel Hostel { get; set; }

    [ForeignKey("Student")]
    public int EnrollmentNo { get; set; }
    public Student Student { get; set; }

    public DateTime CheckInDate { get; set; }
    public DateTime? CheckOutDate { get; set; } // Nullable to account for current hostelers
    public string Notes { get; set; }
    public bool IsActive { get; set; }
}
