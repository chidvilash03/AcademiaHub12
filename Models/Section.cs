using AcademiaHub.Models;
using System.ComponentModel.DataAnnotations;

public class Section
{
    [Key]
    public int SectionID { get; set; }
    public string SectionName { get; set; }

    public ICollection<Student> Students { get; set; }
}
