namespace Venar.Entities
{
    public class MedicalHistory
    {
        public int MedicId { get; set; }
        public int PatientsId { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        

    }
}
