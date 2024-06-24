using System.Data;
using Venar.Data;
using Venar.DTO;

namespace Venar.SVC
{
    public class MedicSVC
    {
        DataServices dataServices = new DataServices();
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
            //{ "@UserId",userId.ToString() },
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







    }
}
