using System.Data;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class MedicalRecordSVC
    {
        DataServices dataService = new DataServices();
        MedicalHistory medicalHistory;
        private int medicalHistoryId;

        public Medic GetInfoMedic(int medicId)
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
                string name = result.Rows[0]["Name"].ToString().Trim();
                string lastName = result.Rows[0]["LastName"].ToString().Trim();
                Medic medic = new Medic
                {
                    Name = name,
                    LastName = lastName
                };

                return medic;
            }
            else
            {
                throw new Exception($"No se encontró información para el MedicId {medicId}");
            }
        }
        public int CreateMedicalHistory(MedicalHistory medicalHistory)
        { 
            string query = @"
        INSERT INTO MedicalHistory (MedicId, PatientsId, Diagnosis, Reason, CreatedAt)
        VALUES (@MedicId, @PatientsId, @Diagnosis, @Reason, GETDATE());
        SELECT SCOPE_IDENTITY();";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@MedicId", medicalHistory.IdMedic.ToString() },
                { "@PatientsId", medicalHistory.IdPatient.ToString() },
                { "@Diagnosis", medicalHistory.Diagnosis },
                { "@Reason", medicalHistory.Reason }
            };
            try
            {
                DataTable result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    if (result.Rows[0][0] != DBNull.Value)
                    {
                        medicalHistoryId = Convert.ToInt32(result.Rows[0][0]);
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener el ID de la historia clínica después de la inserción.");
                    }
                }
                else
                {
                    throw new Exception("No se obtuvo ningún resultado después de la inserción en MedicalHistory.");
                }

                bool success = MedicalHistoryToPatient(medicalHistory.IdPatient, medicalHistoryId);

                if (!success)
                {
                    medicalHistoryId = 0;
                }
                return medicalHistoryId;
            }
            catch (FormatException ex)
            {
                throw new Exception("Error de formato al crear la historia clínica: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la historia clínica: " + ex.Message, ex);
            }
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
