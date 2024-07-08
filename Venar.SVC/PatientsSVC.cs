using System.Data;
using System.Diagnostics;
using System.Net;
using Venar.Data;
using Venar.DTO;
using Venar.Entities;
using Venar.Entities.Views;

namespace Venar.SVC
{
    public class PatientsSVC
    {
        private DataServices dataService;
        public PatientsSVC()
        {
            dataService = new DataServices();
        }
        public int CreatePatient(Patient patient, MedicDto medic)
        {
            string insertPatientQuery = @"
        INSERT INTO Patients (Name, LastName, Dni, DateOfBirth, GenderId, LocationId, MedicalCoverageId, CreatedAt) 
        VALUES (@Name, @LastName, @Dni, @DateOfBirth, @GenderId, @LocationId, @MedicalCoverageId, @CreatedAt);
        SELECT SCOPE_IDENTITY() AS PatientId";

            Dictionary<string, string> patientParams = new Dictionary<string, string>()
    {
        { "@Name", patient.Name },
        { "@LastName", patient.LastName },
        { "@Dni", patient.Dni.ToString() },
        { "@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd") },
        { "@GenderId", patient.Gender.IdGender.ToString() },
        { "@LocationId", patient.Location?.IdLocation.ToString() ?? "0" }, // Tratamiento para valores nulos
        { "@MedicalCoverageId", patient.MedicalCoverage?.IdCover.ToString() ?? "0" }, // Tratamiento para valores nulos
        { "@CreatedAt", DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss") } // Formato adecuado para SQL Server
    };

            try
            {
                DataTable patientResult = dataService.Selection(insertPatientQuery, patientParams);

                if (patientResult != null && patientResult.Rows.Count > 0)
                {
                    int patientId = Convert.ToInt32(patientResult.Rows[0]["PatientId"]);

                    // Verificar existencia de medicId en la tabla Medics
                    string checkMedicQuery = "SELECT COUNT(*) AS MedicCount FROM Medics WHERE MedicId = @MedicId";
                    Dictionary<string, string> checkMedicParams = new Dictionary<string, string>()
            {
                { "@MedicId", medic.MedicId.ToString() }
            };

                    DataTable result = dataService.Selection(checkMedicQuery, checkMedicParams);

                    int medicCount = 0;

                    if (result != null && result.Rows.Count > 0)
                    {
                        medicCount = Convert.ToInt32(result.Rows[0]["MedicCount"]);
                    }

                    if (medicCount > 0)
                    {
                        string insertRelationshipQuery = @"
                    INSERT INTO Patient_Medic (PatientId, MedicId) 
                    VALUES (@PatientId, @MedicId)";

                        Dictionary<string, string> relationshipParams = new Dictionary<string, string>()
                {
                    { "@PatientId", patientId.ToString() },
                    { "@MedicId", medic.MedicId.ToString() }
                };

                        int relationshipResult = dataService.Execute(insertRelationshipQuery, relationshipParams);

                        return relationshipResult > 0 ? patientId : 0;
                    }
                    else
                    {
                        throw new Exception($"No existe un médico con el ID {medic.MedicId} en la base de datos.");
                    }
                }
                else
                {
                    throw new Exception("No se pudo obtener el ID del paciente después de la inserción en Patients.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el paciente: " + ex.Message, ex);
            }
        }
        public bool DeletePatient(int dni, MedicDto medic)
        {
            bool result = false;

            string SQLUpdateStatus = @"
             UPDATE Patients 
             SET Status = 0 
             WHERE Dni = @Dni 
             AND PatientId IN (
             SELECT PM.PatientId
             FROM Patient_Medic PM
             WHERE PM.PatientId = Patients.PatientId
             AND PM.MedicId = @MedicId
            )";

            Dictionary<string, string> parametros = new Dictionary<string, string>();
            parametros.Add("@Dni", dni.ToString());
            parametros.Add("@MedicId", medic.MedicId.ToString());

            int rowsAffected = dataService.Execute(SQLUpdateStatus, parametros);

            result = rowsAffected > 0;

            return result;
        }
        public bool UpdatePatient(Patient patient)
        {
            bool result = false;

            string sqlUpdatePatient = @"
                UPDATE Patients 
                SET Name = @Name, 
                    LastName = @LastName, 
                    DateOfBirth = @DateOfBirth,
                    GenderId = @GenderId, 
                    LocationId = @LocationId, 
                    MedicalCoverageId = @MedicalCoverageId,
                    UpdateAt = GETDATE()
                WHERE Dni = @Dni";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Name", patient.Name);
            parameters.Add("@LastName", patient.LastName);
            parameters.Add("@DateOfBirth", patient.DateOfBirth != null ? patient.DateOfBirth.ToString("yyyy-MM-dd") : null);
            parameters.Add("@GenderId", patient.Gender != null ? patient.Gender.IdGender.ToString() : null);
            parameters.Add("@LocationId", patient.Location != null ? patient.Location.IdLocation.ToString() : null);
            parameters.Add("@MedicalCoverageId", patient.MedicalCoverage != null ? patient.MedicalCoverage.IdCover.ToString() : null);
            parameters.Add("@Dni", patient.Dni.ToString());

            int rowsAffected = dataService.Execute(sqlUpdatePatient, parameters);

            result = rowsAffected > 0;

            return result;
        }
        public List<PatientViewModel> GetPatients(int medicId)
        {
            List<PatientViewModel> patients = new List<PatientViewModel>();
            string query = @"
             SELECT P.PatientId, P.Name, P.LastName, P.Dni, P.DateOfBirth,
                    P.GenderId, G.nombre AS GenderName, P.HasMedicalHistory,
                    P.LocationId, L.Name AS LocationName,
                    MC.name AS MedicalCoverageName,
                    P.Status, P.CreatedAt, P.UpdateAt
             FROM Patients P
             INNER JOIN Patient_Medic PMR ON P.PatientId = PMR.PatientId
             INNER JOIN Medics M ON PMR.MedicId = M.MedicId
             LEFT JOIN Gender G ON P.GenderId = G.GenderId
             LEFT JOIN Location L ON P.LocationId = L.LocationId
             LEFT JOIN MedicalCoverage MC ON P.MedicalCoverageId = MC.MedicCoveId
             WHERE P.Status = 1
             AND M.MedicId = @MedicId";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@MedicId", medicId.ToString());

            var result = dataService.Selection(query, parameters);

            foreach (DataRow row in result.Rows)
            {
                PatientViewModel patient = new PatientViewModel();
                patient.PatientId = Convert.ToInt32(row["PatientId"]);
                patient.Name = row["Name"].ToString().Trim();
                patient.LastName = row["LastName"].ToString().Trim();
                patient.Dni = Convert.ToInt32(row["Dni"]);
                patient.Gender = row["GenderName"].ToString().Trim();
                patient.Location = row["LocationName"].ToString().Trim();
                patient.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                patient.MedicalCoverage = row["MedicalCoverageName"].ToString().Trim();
                patient.HasMedicalHistory = Convert.ToBoolean(row["HasMedicalHistory"]) ? "Si" : "No";

                patients.Add(patient);
            }

            return patients;
        }
        public Patient SearchPat(int dni)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string query = @"
    SELECT p.PatientId, p.Name, p.LastName, p.DateOfBirth, p.HasMedicalHistory, p.MedicalCoverageId, p.GenderId, p.LocationId,
           mh.MedicalHistoryId, mh.Diagnosis, mh.Reason, mc.name AS CoverName, g.nombre AS GenderName
    FROM Patients p
    LEFT JOIN MedicalHistory mh ON p.PatientId = mh.PatientId
    LEFT JOIN MedicalCoverage mc ON p.MedicalCoverageId = mc.MedicCoveId
    LEFT JOIN Gender g ON p.GenderId = g.GenderId
    WHERE p.Dni = @Dni";

            parameters.Add("@Dni", dni.ToString());

            try
            {
                var result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    var row = result.Rows[0];

                    Patient patient = new Patient()
                    {
                        PatientId = Convert.ToInt32(row["PatientId"]),
                        Name = row["Name"].ToString(),
                        LastName = row["LastName"].ToString(),
                        DateOfBirth = row.IsNull("DateOfBirth") ? DateTime.MinValue : Convert.ToDateTime(row["DateOfBirth"]),
                        Dni = dni,
                        MedicalCoverage = new MedicalCoverage()
                        {
                            IdCover = row.IsNull("MedicalCoverageId") ? 0 : Convert.ToInt32(row["MedicalCoverageId"]),
                            NameCover = row.IsNull("CoverName") ? string.Empty : row["CoverName"].ToString()
                        },
                        Gender = new Gender()
                        {
                            IdGender = row.IsNull("GenderId") ? 0 : Convert.ToInt32(row["GenderId"]),
                            NameGender = row.IsNull("GenderName") ? string.Empty : row["GenderName"].ToString()
                        },
                        Location = new Location()
                        {
                            IdLocation = row.IsNull("LocationId") ? 0 : Convert.ToInt32(row["LocationId"])
                        }
                    };

                    if (Convert.ToBoolean(row["HasMedicalHistory"]))
                    {
                        patient.MedicalHistory = new Consultation()
                        {
                            ReportNumber = Convert.ToInt32(row["MedicalHistoryId"]),
                            Diagnosis = row.IsNull("Diagnosis") ? string.Empty : row["Diagnosis"].ToString(),
                            Reason = row.IsNull("Reason") ? string.Empty : row["Reason"].ToString()
                        };
                    }

                    return patient;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception occurred: {ex.Message}");
                throw new Exception("Error al buscar paciente por DNI", ex);
            }
        }

        public List<Location> GetLocation()
        {
            string query = "SELECT * FROM Location";
            List<Location> Location = new List<Location>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    Location.Add(new Location()
                    {
                        IdLocation = int.Parse(row["LocationId"].ToString()),
                        LocationName = row["Name"].ToString()
                    });
                }
            }
            return Location;
        }
        public List<Gender> GetGender()
        {
            string query = "SELECT * FROM Gender";
            List<Gender> genders = new List<Gender>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    genders.Add(new Gender()
                    {
                        IdGender = int.Parse(row["GenderId"].ToString()),
                        NameGender = row["nombre"].ToString()
                    });
                }
            }

            return genders;
        }
        public List<MedicalCoverage> GetCover()
        {
            string query = "SELECT *FROM MedicalCoverage";
            List<MedicalCoverage> coverageMedicals = new List<MedicalCoverage>();
            var dates = dataService.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    coverageMedicals.Add(new MedicalCoverage()
                    {
                        IdCover = int.Parse(row["MedicCoveId"].ToString()),
                        NameCover = row["name"].ToString()
                    });
                }
            }

            return coverageMedicals;
        }

        public Patient SearchByReportNumber(int reportNumber, int patientId)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string query = @"
                SELECT mh.Diagnosis, mh.Reason, mh.MedicalHistoryId, p.*, mc.name AS CoverName, g.nombre AS GenderName
                FROM MedicalHistory mh
                JOIN Patients p ON mh.PatientId = p.PatientId
                JOIN MedicalCoverage mc ON p.MedicalCoverageId = mc.MedicCoveId
                JOIN Gender g ON p.GenderId = g.GenderId
                WHERE mh.MedicalHistoryId = @ReportNumber";

            parameters.Add("@ReportNumber", reportNumber.ToString());

            try
            {
                var result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    var row = result.Rows[0];

                    Patient patient = new Patient()
                    {
                        Name = row["Name"].ToString(),
                        LastName = row["LastName"].ToString(),
                        MedicalCoverage = new MedicalCoverage()
                        {
                            NameCover = row.IsNull("CoverName") ? string.Empty : row["CoverName"].ToString()
                        },
                        Gender = new Gender()
                        {
                            NameGender = row["GenderName"].ToString()
                        },
                        //Location = new Location()
                        //{
                        //    IdLocation = row.IsNull("LocationId") ? 0 : Convert.ToInt32(row["LocationId"])
                        //},
                        MedicalHistory = new Consultation()
                        {
                            Reason = row["Reason"].ToString(),
                            Diagnosis = row["Diagnosis"].ToString(),
                            ReportNumber = Convert.ToInt32(row["MedicalHistoryId"]),
                        }
                    };

                    // Log the patient data retrieved
                    Debug.WriteLine($"Patient found: {patient.Name} {patient.LastName}, ReportNumber: {patient.MedicalHistory.ReportNumber}");

                    return patient;
                }
                else
                {
                    Debug.WriteLine($"No patient found with ReportNumber: {reportNumber}, PatientId: {patientId}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception occurred: {ex.Message}");
                throw new Exception("Error al buscar paciente por DNI", ex);
            }
        }

    }
}
