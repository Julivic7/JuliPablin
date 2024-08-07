﻿using System.Data;
using Venar.Data;
using Venar.DTO;

namespace Venar.SVC
{
    public class MenuAdminSVC
    {
        DataServices dataServices = new DataServices();

        public void CreateMedic(MedicDto medicDto)
        {
            string userQuery = @"
        INSERT INTO Users (UserName, Password, UserType, Mail)
        VALUES (@UserName, @Password, 'MEDIC', @Mail);
        SELECT CAST(SCOPE_IDENTITY() AS int) AS UserId;
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

                    // Ahora puedes continuar con la inserción en la tabla Medics utilizando userId
                    string medicQuery = @"
                INSERT INTO Medics (UserId, Name, LastName, Dni, Specialty, MedicalRegistration)
                VALUES (@UserId, @Name, @LastName, @Dni, @Specialty, @MedicalRegistration);
            ";

                    Dictionary<string, string> medicParams = new Dictionary<string, string>
                     {
                        { "@UserId", userId.ToString() },
                        { "@Name", medicDto.Name },
                        { "@LastName", medicDto.LastName },
                        { "@Dni", medicDto.Dni },
                        { "@Specialty", medicDto.Specialty },
                        { "@MedicalRegistration", medicDto.MedicalRegistration }
                    };

                    dataServices.Execute(medicQuery, medicParams);
                }
                else
                {
                    throw new Exception("No se pudo obtener el UserId después de insertar en Users.");
                }
            }
            catch (Exception ex)
            {
                // Manejar o registrar la excepción
                throw new Exception("Error al crear el médico", ex);
            }
        }
        public List<MedicDto> GetMedics()
        {
            List<MedicDto> listMedics = null;
            string SqlSelect = @"
        SELECT M.MedicId, M.Name, M.LastName,M.Dni, M.Specialty, M.MedicalRegistration,
               U.UserName, U.Password, U.Mail
        FROM Medics M
        INNER JOIN Users U ON M.UserId = U.UserId
        WHERE M.Status = 1";

            var result = dataServices.Selection(SqlSelect, null);

            if (result != null && result.Rows.Count > 0)
            {
                listMedics = new List<MedicDto>();
                foreach (DataRow row in result.Rows)
                {
                    listMedics.Add(new MedicDto()
                    {
                        MedicId = Convert.ToInt32(row["MedicId"]),
                        UserName = row["UserName"].ToString(),
                        Name = row["Name"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Dni = row["Dni"].ToString(),
                        Mail = row["Mail"].ToString(),
                        Password = row["Password"].ToString(),
                        Specialty = row["Specialty"].ToString(),
                        MedicalRegistration = row["MedicalRegistration"].ToString()
                    });
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
                Specialty = result["Specialty"].ToString(),
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

            
            string SQLUpdateUser = @"
                UPDATE Users 
                SET UserName = @UserName, Mail = @Mail
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
    }
}
