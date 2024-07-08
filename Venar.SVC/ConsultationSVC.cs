using System.Data;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class ConsultationSVC
    {
        DataServices dataService = new DataServices();
        Consultation consultation;

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
        public bool CreateConsultation(Consultation consultation)
        {
            string query = @"
         BEGIN TRANSACTION;

         INSERT INTO MedicalHistory (MedicId, PatientId, Diagnosis, Reason, CreatedAt)
         VALUES (@MedicId, @PatientId, @Diagnosis, @Reason, GETDATE());

         DECLARE @NewId INT;
         SET @NewId = SCOPE_IDENTITY();

         UPDATE Patients
         SET HasMedicalHistory = 1
         WHERE PatientId = @PatientId;

         COMMIT TRANSACTION;

         SELECT @NewId;";

            Dictionary<string, string> parameters = new Dictionary<string, string>
    {
        { "@MedicId", consultation.IdMedic.ToString() },
        { "@PatientId", consultation.IdPatient.ToString() },
        { "@Diagnosis", consultation.Diagnosis },
        { "@Reason", consultation.Reason }
    };

            try
            {
                DataTable result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    if (result.Rows[0][0] != DBNull.Value)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new Exception("No se obtuvo ningún resultado después de la inserción en MedicalHistory.");
                }
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

    }
}
