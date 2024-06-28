﻿//using System.Data;
//using Venar.Data;
//using Venar.DTO;

//namespace Venar.SVC
//{
//    public class MedicSVC
//    {
//        DataServices dataServices = new DataServices();
//        public List<MedicDto> GetMedics()
//        {
//            var medics = new List<MedicDto>();

//            DataTable result = dataServices.Selection("SELECT userName, Name, LastName, Dni, Mail, Password, Specialty, MedicalRegistration FROM Medics", null);

//            foreach (DataRow row in result.Rows)
//            {
//                var medicDto = new MedicDto
//                {
//                    UserName = row["userName"].ToString(),
//                    Name = row["Name"].ToString(),
//                    LastName = row["LastName"].ToString(),
//                    Dni = row["Dni"].ToString(),
//                    Mail = row["Mail"].ToString(),
//                    Password = row["Password"].ToString(),
//                    Specialty = row["Specialty"].ToString(),
//                    MedicalRegistration = row["MedicalRegistration"].ToString()
//                };
//                medics.Add(medicDto);
//            }
//            return medics;
//        }
//        public void CreateMedic(MedicDto medicDto)
//        {

//            string userQuery = @"
//        INSERT INTO Users (UserName, Password, UserType, Email)
//        VALUES (@UserName, @Password, 'MEDIC', @Mail);
//        SELECT SCOPE_IDENTITY() AS UserId;
//    ";

//            Dictionary<string, string> userParams = new Dictionary<string, string>
//    {
//        { "@UserName", medicDto.UserName },
//        { "@Password", medicDto.Password },
//        { "@Mail", medicDto.Mail }
//    };

//            DataTable userResult = dataServices.Selection(userQuery, userParams);

//            if (userResult.Rows.Count > 0)
//            {
//                int userId = Convert.ToInt32(userResult.Rows[0]["UserId"]);


//                string medicQuery = @"
//            INSERT INTO Medics (Name, LastName, Dni, Mail, Specialty, MedicalRegistration)
//            VALUES (@Name, @LastName, @Dni, @Mail, @Specialty, @MedicalRegistration);
//        ";

//                Dictionary<string, string> medicParams = new Dictionary<string, string>
//        {
//            //{ "@UserId",userId.ToString() },
//            { "@Name", medicDto.Name },
//            { "@LastName", medicDto.LastName },
//            { "@Dni", medicDto.Dni },
//            { "@Mail", medicDto.Mail },
//            { "@Specialty", medicDto.Specialty },
//            { "@MedicalRegistration", medicDto.MedicalRegistration }
//        };

//                dataServices.Execute(medicQuery, medicParams);
//            }
//            else
//            {
//                // Manejar el caso donde no se pudo obtener el UserId
//                throw new Exception("No se pudo obtener el UserId después de insertar en Users.");
//            }
//        }







//    }
//}

using System.Data;
using System.Xml.Linq;
using Venar.Data;
using Venar.DTO;

namespace Venar.SVC
{
    public class MedicSVC
    {
        DataServices dataServices = new DataServices();

        public void CreateMedic(MedicDto medicDto)
        {

            string userQuery = @"
                    INSERT INTO Users (UserName, Password, UserType, Email)
                    VALUES (@UserName, @Password, 'MEDIC', @Mail);
                    SELECT SCOPE_IDENTITY() AS UserId;
                ";

            Dictionary<string, string> userParams = new Dictionary<string, string>
                    {
                        { "@UserName", medicDto.UserName },
                        { "@Password", medicDto.Password },
                        { "@Mail", medicDto.Mail }
                    };

            DataTable userResult = dataServices.Selection(userQuery, userParams);

            if (userResult.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(userResult.Rows[0]["UserId"]);


                string medicQuery = @"
            INSERT INTO Medics (Name, LastName, Dni, Mail, Specialty, MedicalRegistration)
            VALUES (@Name, @LastName, @Dni, @Mail, @Specialty, @MedicalRegistration);
        ";

            Dictionary<string, string> medicParams = new Dictionary<string, string>
            {
                { "@Name", medicDto.Name },
                { "@LastName", medicDto.LastName },
                { "@Dni", medicDto.Dni },
                { "@Mail", medicDto.Mail },
                { "@Specialty", medicDto.Specialty },
                { "@MedicalRegistration", medicDto.MedicalRegistration }
            };

                dataServices.Execute(medicQuery, medicParams);
            }
            else
            {
                // Manejar el caso donde no se pudo obtener el UserId
                throw new Exception("No se pudo obtener el UserId después de insertar en Users.");
            }
        }
        public List<MedicDto> GetMedics()
        {
            var medics = new List<MedicDto>();

            DataTable result = dataServices.Selection("SELECT userName, Name, LastName, Dni, Mail, Password, Specialty, MedicalRegistration FROM Medics", null);

            foreach (DataRow row in result.Rows)
            {
                var medicDto = new MedicDto
                {
                    UserName = row["userName"].ToString(),
                    Name = row["Name"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Dni = row["Dni"].ToString(),
                    Mail = row["Mail"].ToString(),
                    Password = row["Password"].ToString(),
                    Specialty = row["Specialty"].ToString(),
                    MedicalRegistration = row["MedicalRegistration"].ToString()
                };
                medics.Add(medicDto);
            }
            return medics;
        }
        public bool DeleteMedic(MedicDto medic)
        {
            bool Result = false;
            string SQLDelete = "UPDATE Materias SET Status = 0 WHERE MedicId = @MedicId";

            //Código para enviar a dar de baja lógica en la capa de datos
            Dictionary<string, string> Parametros = new Dictionary<string, string>();

            Parametros.Add("@MedicId", medic.ToString());

            var Execute = dataServices.Execute(SQLDelete, Parametros);

            return Result = Execute > 0 ? true : false;

        }
        public MedicDto GetMedicForId(int idMedic)
        {
            Dictionary<string, string> Parametros = new Dictionary<string, string>();
            string SQLSelect = "SELECT * FROM MEDICS WHERE MedicId = @MedicId";
            Parametros.Add("@MedicId", idMedic.ToString());

            var Result = dataServices.Selection(SQLSelect, Parametros).Rows[0];

            return new MedicDto()
            {
                MedicId = int.Parse(Result["MedicId"].ToString()),
                Name = Result["Name"].ToString(),
                LastName = Result["LastName"].ToString(),
                Dni = Result["Dni"].ToString(),
                Mail = Result["Mail"].ToString(),
                Specialty = Result["Speciality"].ToString(),
                MedicalRegistration = Result["MedicalRegistration"].ToString()
            };
        }
        public bool EditMedic(MedicDto medic)
        {
            bool Result = false;

            // Actualización del médico en la tabla Medics
            string SQLUpdateMedic = @"
        UPDATE Medics 
        SET Name = @Name, 
            LastName = @LastName, 
            Dni = @Dni, 
            Specialty = @Specialty, 
            MedicalRegistration = @MedicalRegistration,
            UpdatedAt = GETDATE()
        WHERE MedicId = @MedicId";

            Dictionary<string, string> ParametrosMedic = new Dictionary<string, string>();
            ParametrosMedic.Add("@MedicId", medic.MedicId.ToString());
            ParametrosMedic.Add("@Name", medic.Name);
            ParametrosMedic.Add("@LastName", medic.LastName);
            ParametrosMedic.Add("@Dni", medic.Dni);
            ParametrosMedic.Add("@Specialty", medic.Specialty);
            ParametrosMedic.Add("@MedicalRegistration", medic.MedicalRegistration);

            var rowsAffectedMedic = dataServices.Execute(SQLUpdateMedic, ParametrosMedic);

            // Actualización del nombre de usuario en la tabla Users
            string SQLUpdateUser = @"
        UPDATE Users 
        SET UserName = @UserName
        WHERE UserId = (
            SELECT UserId FROM Medics WHERE MedicId = @MedicId
        )";

            Dictionary<string, string> ParametrosUser = new Dictionary<string, string>();
            ParametrosUser.Add("@MedicId", medic.MedicId.ToString());
            ParametrosUser.Add("@UserName", medic.UserName); // Nuevo nombre de usuario

            var rowsAffectedUser = dataServices.Execute(SQLUpdateUser, ParametrosUser);

            // Se considera exitoso si ambas actualizaciones tienen éxito
            Result = rowsAffectedMedic > 0 && rowsAffectedUser > 0;

            return Result;
        }
    }
}
