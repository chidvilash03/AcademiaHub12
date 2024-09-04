using System.ComponentModel.DataAnnotations;

public class Hostel
{
    [Key]
    public int HostelID { get; set; }
    public string HostelName { get; set; }
    public string HostelGender { get; set; }
    public string Notes { get; set; }

    public ICollection<Hosteler> Hostelers { get; set; }
}

