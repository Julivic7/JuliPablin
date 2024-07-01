﻿using System.Data;
using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class PatientsSVC
    {
        private DataServices dataService;       

        public PatientsSVC()
        {
            dataService = new DataServices();
        }
        public int CreatePatient(Patient patient, int medicId)
        {
            Dictionary<string, string> Parts = new Dictionary<string, string>();

            string query = @"
                INSERT INTO Patients (Name, LastName, Dni, DateOfBirth, GenderId, LocationId, MedicalCoverageId) 
                VALUES (@Name, @LastName, @Dni, @DateOfBirth, @GenderId, @LocationId, @MedicalCoverageId);
                SELECT SCOPE_IDENTITY();"; 
                
            Parts.Add("@Name", patient.Name);
            Parts.Add("@LastName", patient.LastName);
            Parts.Add("@Dni", patient.Dni.ToString());
            Parts.Add("@DateOfBirth", patient.DateOfBirth.ToString("yyyy-MM-dd"));
            Parts.Add("@GenderId", patient.Gender.IdGender.ToString());
            Parts.Add("@LocationId", patient.Location.IdLocation.ToString());
            Parts.Add("@MedicalCoverageId", patient.MedicalCoverage.IdCover.ToString());
            
            int patientId = 0;
            var result = dataService.Selection(query, Parts);

            if (result != null && result.Rows.Count > 0)
            {
                patientId = Convert.ToInt32(result.Rows[0][0]);
            }
            if (patientId > 0)
            {                
                string relationshipQuery = @"
                        INSERT INTO PatientMedicRelationship (PatientId, MedicId) 
                        VALUES (@PatientId, @MedicId)";

                Dictionary<string, string> relationshipParams = new Dictionary<string, string>()
                {
                    { "@PatientId", patientId.ToString() },
                    { "@MedicId", medicId.ToString() }
                };

                int relationshipResult = dataService.Execute(relationshipQuery, relationshipParams);

                return relationshipResult > 0 ? patientId : 0; 
            }
            return 0;
        }
        public bool DeletePatient(int dni, int medicId)
        {
            bool result = false;

            string SQLUpdateStatus = @"
             UPDATE Patients 
             SET Status = 0 
             WHERE Dni = @Dni 
             AND PatientId IN (
             SELECT PM.PatientId
             FROM PatientMedicRelationship PM
             WHERE PM.PatientId = Patients.PatientId
             AND PM.MedicId = @MedicId
            )";

            Dictionary<string, string> parametros = new Dictionary<string, string>();
            parametros.Add("@Dni", dni.ToString());
            parametros.Add("@MedicId", medicId.ToString());

            int rowsAffected = dataService.Execute(SQLUpdateStatus, parametros);

            result = rowsAffected > 0;

            return result;
        }
        public bool UpdatePatient(Patient patient, int medicId)
        {
            bool result = false;

            string sqlUpdatePatient = @"
                UPDATE Patients 
                SET Name = @Name, 
                    LastName = @LastName, 
                    DateOfBirth = @DateOfBirth, 
                    Dni = @DniNuevo,
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
        public List<Patient> GetPatients(int medicId)
        {
            List<Patient> patients = new List<Patient>();
            string query = @"
             SELECT P.PatientId, P.Name, P.LastName, P.Dni, P.DateOfBirth,
                    P.GenderId, G.nombre AS GenderName,
                    P.LocationId, L.Name AS LocationName,
                    P.MedicalCoverageId, MC.name AS MedicalCoverageName,
                    P.Status, P.CreatedAt, P.UpdateAt, P.MedicalHistoryId
             FROM Patients P
             INNER JOIN PatientMedicRelationship PMR ON P.PatientId = PMR.PatientId
             INNER JOIN Medics M ON PMR.MedicId = M.MedicId
             LEFT JOIN Gender G ON P.GenderId = G.GenderId
             LEFT JOIN Location L ON P.LocationId = L.LocationId
             LEFT JOIN MedicalCoverage MC ON P.MedicalCoverageId = MC.MedicCoveId
             LEFT JOIN MedicalHistory MH ON P.MedicalHistoryId = MH.MedicalHistoryId
             WHERE P.Status = 1
             AND M.MedicId = @MedicId";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@MedicId", medicId.ToString());

            var result = dataService.Selection(query, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {
                    Patient patient = new Patient()
                    {
                        PatientId = Convert.ToInt32(row["PatientId"]),
                        Dni = Convert.ToInt32(row["Dni"]),
                        Name = row["Name"].ToString(),
                        LastName = row["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                        MedicalHistory = row["MedicalHistoryId"].ToString()
                    };

                    // Gender
                    if (row["GenderId"] != DBNull.Value)
                    {
                        patient.Gender = new Gender()
                        {
                            IdGender = Convert.ToInt32(row["GenderId"]),
                            NameGender = row["GenderName"].ToString()
                        };
                    }

                    // Location
                    if (row["LocationId"] != DBNull.Value)
                    {
                        patient.Location = new Location()
                        {
                            IdLocation = Convert.ToInt32(row["LocationId"]),
                            LocationName = row["LocationName"].ToString()
                        };
                    }

                    // MedicalCoverage
                    if (row["MedicalCoverageId"] != DBNull.Value)
                    {
                        patient.MedicalCoverage = new MedicalCoverage()
                        {
                            IdCover = Convert.ToInt32(row["MedicalCoverageId"]),
                            NameCover = row["MedicalCoverageName"].ToString()
                        };
                    }

                    patients.Add(patient);
                }
            }

            return patients;
        }
        public Patient SearchPat(int dni)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string query = "SELECT PatientId, Name, LastName, DateOfBirth, MedicalCoverageId, GenderId, LocationId FROM Patients WHERE Dni = @Dni";

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
                            IdCover = row.IsNull("MedicalCoverageId") ? 0 : Convert.ToInt32(row["MedicalCoverageId"])
                        },
                        Gender = new Gender()
                        {
                            IdGender = row.IsNull("GenderId") ? 0 : Convert.ToInt32(row["GenderId"])
                        },
                        Location = new Location()
                        {
                            IdLocation = row.IsNull("LocationId") ? 0 : Convert.ToInt32(row["LocationId"])
                        }
                    };

                    return patient;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
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
    }
}
