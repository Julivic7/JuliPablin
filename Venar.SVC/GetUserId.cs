using System.Data;
using Venar.Data;
using Venar.DTO;
using Venar.Entities;

namespace Venar.SVC
{
    public class GetUserId
    {
        private DataServices dataService;
        MedicDto medicDto;

        public GetUserId()
        {
            dataService = new DataServices();
        }
        public Admin GetAdminId(int userId)
        {
            Admin admin = null;
            string query = "SELECT AdminId, Name FROM Admins WHERE UserId = @UserId";
            Dictionary<string, string> parameters = new Dictionary<string, string>()
    {
        { "@UserId", userId.ToString() }
    };

            try
            {
                DataTable result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    admin = new Admin();
                    admin.UserId = Convert.ToInt32(result.Rows[0]["AdminId"]);
                    admin.Name = result.Rows[0]["Name"].ToString();
                }
                else
                {
                    Console.WriteLine($"No se encontró ningún registro de administrador para UserId: {userId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos de administrador para UserId {userId}: {ex.Message}");
                throw;
            }

            return admin;
        }
        public MedicDto GetMedicId(int userId)
        {
            MedicDto medicDto = null;
            string query = "SELECT MedicId, Name , LastName , MedicalRegistration FROM Medics WHERE UserId = @UserId";
            Dictionary<string, string> parameters = new Dictionary<string, string>()
    {
        { "@UserId", userId.ToString() }
    };

            try
            {
                DataTable result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    medicDto = new MedicDto();
                    medicDto.MedicId = Convert.ToInt32(result.Rows[0]["MedicId"]);
                    medicDto.Name = result.Rows[0]["Name"].ToString();
                    medicDto.LastName = result.Rows[0]["LastName"].ToString();
                    medicDto.MedicalRegistration = result.Rows[0]["MedicalRegistration"].ToString();
                }
                else
                {
                    Console.WriteLine($"No se encontró ningún registro de médico para UserId: {userId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos de médico para UserId {userId}: {ex.Message}");
                throw;
            }

            return medicDto;

        }
    }
}

