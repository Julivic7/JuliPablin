using Venar.Entities;

public class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Dni { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public Location Location { get; set; }
    public MedicalCoverage MedicalCoverage{ get; set; }
    public string MedicalHistory { get;set; }


}