
using System.Data;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{  
    public class MedicalRecordSVC
    {
        DataServices dataService = new DataServices();
        public List<Consultation> GetConsultationsForPatient(int patientId)
        {
            List<Consultation> consultations = new List<Consultation>();
            string query = @"SELECT mh.MedicId AS IdMedic, mh.PatientId AS IdPatient,
                             mh.CreatedAt AS Date, mh.Reason, mh.Diagnosis
                             FROM MedicalHistory mh
                             WHERE mh.PatientId = @PatientId";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                {"@PatientId", patientId.ToString()}
            };

            try
            {
                var result = dataService.Selection(query, parameters);
                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        Consultation consultation = new Consultation();
                        consultation.IdMedic = Convert.ToInt32(row["IdMedic"]);
                        consultation.IdPatient = Convert.ToInt32(row["IdPatient"]);
                        consultation.Date = Convert.ToDateTime(row["Date"]);
                        consultation.Reason = Convert.ToString(row["Reason"]);
                        consultation.Diagnosis = Convert.ToString(row["Diagnosis"]);

                        consultations.Add(consultation);
                    }
                }
                else
                {
                    consultations.Add(new Consultation
                    {
                        IdMedic = 0,
                        IdPatient = patientId,
                        Date = DateTime.Now,
                        Reason = "Sin datos",
                        Diagnosis = "Sin datos"
                    });
                }
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                throw new Exception("Error al consultar la historia clínica: " + ex.Message, ex);
            }

            return consultations;
        }
    }
}
