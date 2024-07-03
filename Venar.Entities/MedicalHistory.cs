namespace Venar.Entities
{
    public class MedicalHistory
    {
        public int IdMedic { get; set; }
        public int IdPatient { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string ResultSymtoms { get; set; }


    }
}
