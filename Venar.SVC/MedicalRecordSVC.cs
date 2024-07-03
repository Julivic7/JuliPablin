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

        //public string GetInfoMedic(int medicId)
        //{
        //    string query = @"
        //    SELECT Name, LastName
        //    FROM Medics
        //    WHERE MedicId = @MedicId
        //    ";

        //    Dictionary<string, string> parameters = new Dictionary<string, string>
        //        {
        //            { "@MedicId", medicId.ToString() }
        //        };

        //    DataTable result = dataService.Selection(query, parameters);

        //    if (result != null && result.Rows.Count > 0)
        //    {
        //        string name = result.Rows[0]["Name"].ToString().Trim();
        //        string lastName = result.Rows[0]["LastName"].ToString().Trim();

        //        return $"{name} {lastName}";
        //    }
        //    else
        //    {
        //        throw new Exception($"No se encontró información para el MedicId {medicId}");
        //    }
        //}

        public int CreateMedicalHistory(MedicalHistory medicalHistory)
        {
            string queryHistory = @"
                INSERT INTO MedicalHistory (MedicId, PatientsId, Diagnosis, Reason)
                VALUES (@IdMedic, @IdPatient, @Diagnosis, @Reason);
                SELECT SCOPE_IDENTITY();";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@IdMedic", medicalHistory.MedicId.ToString() },
                { "@IdPatient", medicalHistory.PatientsId.ToString() },
                { "@Diagnosis", medicalHistory.Diagnosis.Trim() },
                { "@Reason", medicalHistory.Reason.Trim() }
            };

            // Debugging output to check parameter values
            foreach (var param in parameters)
            {
                System.Diagnostics.Debug.WriteLine($"{param.Key}: '{param.Value}'");
            }

            // Execute the query and get the result
            var historyResult = dataService.Selection(queryHistory, parameters);

            // Check if the result is not null and has at least one row
            if (historyResult != null && historyResult.Rows.Count > 0)
            {
                var firstColumnValue = historyResult.Rows[0][0];
                System.Diagnostics.Debug.WriteLine($"First column value: {firstColumnValue}");

                if (int.TryParse(firstColumnValue.ToString(), out int medicalHistoryId))
                {
                    bool success = MedicalHistoryToPatient(medicalHistory.PatientsId, medicalHistoryId);
                    if (!success)
                    {
                        medicalHistoryId = 0;
                    }
                    return medicalHistoryId;
                }
                else
                {
                    throw new InvalidCastException($"Cannot convert '{firstColumnValue}' to an integer.");
                }
            }
            else
            {
                throw new Exception("No result returned from database.");
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
