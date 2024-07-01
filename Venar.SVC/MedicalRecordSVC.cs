using System.Data;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class MedicalRecordSVC
    {
        DataServices dataService = new DataServices();
        MedicalHistory medicalHistory;
        private int medicalHistoryId = 0;

        public string GetInfoMedic(int medicId)
        {
            string query = @"
            SELECT Name, LastName
            FROM Medics
            WHERE MedicId = @MedicId
            ";

            Dictionary<string, string> parameters = new Dictionary<string, string>
                {
                    { "@MedicId", medicId.ToString() }
                };

            DataTable result = dataService.Selection(query, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                string name = result.Rows[0]["Name"].ToString();
                string lastName = result.Rows[0]["LastName"].ToString();

                return $"{name} {lastName}";
            }
            else
            {
                throw new Exception($"No se encontró información para el MedicId {medicId}");
            }
        }

        public int CreateMedicalHistory(MedicalHistory medicalHistory)
        {
            string query = @"
            INSERT INTO MedicalHistory (IdMedic, IdPatient, Date, Diagnosis, Reason, CreatAt)
            VALUES (@IdMedic, @IdPatient, @Date, @Diagnosis, @Reason, GETDATE());
            SELECT SCOPE_IDENTITY();";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@IdMedic", medicalHistory.IdMedic.ToString() },
                { "@IdPatient", medicalHistory.IdPatient.ToString() },
                { "@Date", medicalHistory.Date.ToString() },
                { "@Diagnosis", medicalHistory.Diagnosis },
                { "@Reason", medicalHistory.Reason }
            };
            var result = dataService.Selection(query, parameters);
            if (result != null && result.Rows.Count > 0)
            {
                medicalHistoryId = Convert.ToInt32(result.Rows[0][0]);
            }

            bool success = MedicalHistoryToPatient(medicalHistory.IdPatient, medicalHistoryId);
            if (!success)
            {
                medicalHistoryId = 0;
            }
            return medicalHistoryId;
        }

        private bool MedicalHistoryToPatient(int patientId, int medicalHistoryId)
        {
            bool success = false;

            string query = @"
                UPDATE Patients
                SET MedicalHistoryId = @MedicalHistoryId
                WHERE PatientId = @PatientId;";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                  { "@MedicalHistoryId", medicalHistoryId.ToString() },
                  { "@PatientId", patientId.ToString() }
            };
            int rowsAffected = dataService.Execute(query, parameters);

            if (rowsAffected > 0)
            {
                success = true;
            }
            return success;
        }



    }
}
