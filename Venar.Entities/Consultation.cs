namespace Venar.Entities
{
    public class Consultation
    {
        public int IdMedic { get; set; }
        public int IdPatient { get; set; }
        public string MedicName { get; set; }
        public string MedicLastName { get; set; }
        public string MedicSpecialty { get; set; }
        public string MedicRegistration { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string ResultSymtoms { get; set; }
        public int ReportNumber { get; set; }
    }
}
