using System.Data;
using Venar.Data;
using Venar.DTO;
using Venar.Entities;
using Venar.Entities.Views;

namespace Venar.SVC
{
    public class MenuAdminSVC
    {
        DataServices dataServices = new DataServices();
        public void CreateMedic(MedicDto medicDto)
        {
            medicDto.UserName = medicDto.UserName.Trim();
            medicDto.Password = medicDto.Password.Trim();
            medicDto.Mail = medicDto.Mail.Trim();
            medicDto.Name = medicDto.Name.Trim();
            medicDto.LastName = medicDto.LastName.Trim();
            medicDto.Dni = medicDto.Dni.Trim();
            medicDto.MedicalRegistration = medicDto.MedicalRegistration.Trim();


            string userQuery = @"
            INSERT INTO Users (UserName, Password, UserType, Mail)
            VALUES (@UserName, @Password, 'MEDIC' , @Mail);
            SELECT SCOPE_IDENTITY() AS UserId;
            ";

            Dictionary<string, string> userParams = new Dictionary<string, string>
            {
                { "@UserName", medicDto.UserName },
                { "@Password", medicDto.Password },
                { "@Mail", medicDto.Mail }
            };

            try
            {

                DataTable userResult = dataServices.Selection(userQuery, userParams);

                if (userResult != null && userResult.Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(userResult.Rows[0]["UserId"]);
                    if (userId == 0)
                    {
                        throw new Exception("SCOPE_IDENTITY() returned 0.");
                    }

                    string medicQuery = @"
                     INSERT INTO Medics (UserId, Name, LastName, Dni, SpecialtyId, MedicalRegistration, CreatedAt)
                     VALUES (@UserId, @Name, @LastName, @Dni, @SpecialtyId, @MedicalRegistration, @CreatedAt);
                     ";

                    Dictionary<string, string> medicParams = new Dictionary<string, string>
                     {
                         { "@UserId", userId.ToString() },
                         { "@Name", medicDto.Name },
                         { "@LastName", medicDto.LastName },
                         { "@Dni", medicDto.Dni },
                         { "@SpecialtyId", medicDto.SpecialtyId.ToString() },
                         { "@MedicalRegistration", medicDto.MedicalRegistration },
                         { "@CreatedAt", DateTime.Today.ToString()}
                     };

                    dataServices.Execute(medicQuery, medicParams);
                }
                else
                {
                    throw new Exception("No se obtuvo el UserId después de insertar en Users o la consulta no devolvió resultados.");
                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Validation failed: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el médico: " + ex.Message, ex);
            }
        }
        public List<MedicViewModel> GetMedics()
        {
            List<MedicViewModel> listMedics = new List<MedicViewModel>();

            string SqlSelect = @"
    SELECT M.MedicId, M.Name, M.LastName, M.SpecialtyId, M.MedicalRegistration,
           U.UserName, U.Mail, S.SpecialityName
    FROM Medics M
    INNER JOIN Users U ON M.UserId = U.UserId
    INNER JOIN Specialty S ON M.SpecialtyId = S.SpecialtyId
    WHERE M.Status = 1";


            var result = dataServices.Selection(SqlSelect, null);

            if (result != null && result.Rows.Count > 0)
            {
                foreach (DataRow row in result.Rows)
                {

                    MedicViewModel medic = new MedicViewModel();
                    medic.MedicId = row["MedicId"].ToString();
                    medic.Name = row["Name"].ToString();
                    medic.LastName = row["LastName"].ToString();
                    medic.SpecialtyName = row["SpecialityName"].ToString();
                    medic.MedicalRegistration = row["MedicalRegistration"].ToString();

                    listMedics.Add(medic);
                }
            }

            return listMedics;
        }
        public bool DeleteMedic(int medic)
        {
            bool Result = false;
            string SQLDelete = "UPDATE Medics SET Status = 0 WHERE MedicId = @MedicId";

            //Código para enviar a dar de baja lógica en la capa de datos
            Dictionary<string, string> Parametros = new Dictionary<string, string>();

            Parametros.Add("@MedicId", medic.ToString());

            var Execute = dataServices.Execute(SQLDelete, Parametros);

            return Result = Execute > 0 ? true : false;

        }
        public MedicDto GetMedicForId(int idMedic)
        {
            Dictionary<string, string> parametros = new Dictionary<string, string>();
            string sqlSelect = @"
        SELECT M.*, U.Mail, U.UserName 
        FROM Medics M
        INNER JOIN Users U ON M.UserId = U.UserId
        WHERE M.MedicId = @MedicId";

            parametros.Add("@MedicId", idMedic.ToString());

            var result = dataServices.Selection(sqlSelect, parametros).Rows[0];

            return new MedicDto()
            {
                MedicId = int.Parse(result["MedicId"].ToString()),
                Name = result["Name"].ToString(),
                LastName = result["LastName"].ToString(),
                Dni = result["Dni"].ToString(),
                SpecialtyId = int.Parse(result["SpecialtyId"].ToString()),
                MedicalRegistration = result["MedicalRegistration"].ToString(),
                Mail = result["Mail"].ToString(), // Agregar Mail desde Users
                UserName = result["UserName"].ToString() // Agregar UserName desde Users
            };
        }
        public bool UpdateMedic(MedicDto medic)
        {
            bool Result = false;

            // Actualización del médico en la tabla Medics
            string SQLUpdateMedic = @"
               UPDATE Medics 
               SET Name = @Name, 
                   LastName = @LastName, 
                   Dni = @Dni,
                   SpecialtyId = @SpecialtyId, 
                   MedicalRegistration = @MedicalRegistration,
                   UpdatedAt = GETDATE()
               WHERE MedicId = @MedicId";

            Dictionary<string, string> ParametrosMedic = new Dictionary<string, string>();
            ParametrosMedic.Add("@MedicId", medic.MedicId.ToString());
            ParametrosMedic.Add("@Name", medic.Name);
            ParametrosMedic.Add("@LastName", medic.LastName);
            ParametrosMedic.Add("@Dni", medic.Dni);
            ParametrosMedic.Add("@SpecialtyId", medic.SpecialtyId.ToString()); // Aquí se cambia a SpecialtyId
            ParametrosMedic.Add("@MedicalRegistration", medic.MedicalRegistration);

            var rowsAffectedMedic = dataServices.Execute(SQLUpdateMedic, ParametrosMedic);

            // Actualización del usuario en la tabla Users
            string SQLUpdateUser = @"
             UPDATE Users 
             SET UserName = @UserName, 
                 Mail = @Mail
             WHERE UserId = (
                 SELECT UserId FROM Medics WHERE MedicId = @MedicId
             )";

            Dictionary<string, string> ParametrosUser = new Dictionary<string, string>();
            ParametrosUser.Add("@MedicId", medic.MedicId.ToString());
            ParametrosUser.Add("@UserName", medic.UserName);
            ParametrosUser.Add("@Mail", medic.Mail);

            var rowsAffectedUser = dataServices.Execute(SQLUpdateUser, ParametrosUser);

            // Se considera exitoso si ambas actualizaciones tienen éxito
            Result = rowsAffectedMedic > 0 && rowsAffectedUser > 0;

            return Result;
        }
        public List<Specialty> GetSpecialty()
        {
            string query = "SELECT * FROM Specialty";
            List<Specialty> Specialty = new List<Specialty>();
            var dates = dataServices.Selection(query, null);

            if (dates != null && dates.Rows.Count > 0)
            {
                foreach (DataRow row in dates.Rows)
                {
                    Specialty.Add(new Specialty()
                    {
                        SpecialtyId = int.Parse(row["SpecialtyId"].ToString()),
                        SpecialtyName = row["SpecialityName"].ToString()
                    });
                }
            }
            return Specialty;
        }
        public List<Patient> GetPatient()
        {
            string query = "SELECT * FROM Patients";
            List<Patient> patients = new List<Patient>();
            var list = dataServices.Selection(query, null);

            if (list != null && list.Rows.Count > 0)
            {
                foreach (DataRow row in list.Rows)
                {
                    patients.Add(new Patient()
                    {
                        PatientId = int.Parse(row["PatientId"].ToString()),
                        Name = row["Name"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Dni = int.Parse(row["Dni"].ToString()),
                        DateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString()),
                        MedicalCoverage = new MedicalCoverage()
                        {
                            IdCover = row.IsNull("MedicalCoverageId") ? 0 : Convert.ToInt32(row["MedicalCoverageId"]),

                        },
                        Gender = new Gender()
                        {
                            IdGender = row.IsNull("GenderId") ? 0 : Convert.ToInt32(row["GenderId"]),

                        },
                        Location = new Location()
                        {
                            IdLocation = row.IsNull("LocationId") ? 0 : Convert.ToInt32(row["LocationId"])
                        }
                    });
                }
            }
            return patients;
        }
        public int CountPatients()
        {
            string query = "SELECT COUNT(*) FROM Patients";
            var result = dataServices.Selection(query, null);

            if (result != null && result.Rows.Count > 0)
            {
                return int.Parse(result.Rows[0][0].ToString());
            }

            return 0;
        }
    }
}
