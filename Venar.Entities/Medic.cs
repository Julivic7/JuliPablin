namespace Venar.Entities
{
    public class Medic : User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Specialty SpecialityId { get; set; }
        public string MedicalRegistration { get; set; }

    }
}
