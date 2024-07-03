using System.Data;
using Venar.Data;

namespace Venar.SVC
{
    public class GetUserId
    {
        private DataServices dataService;

        public GetUserId()
        {
            dataService = new DataServices();
        }

        public int GetAdminId(int userId)
        {
            int adminId = 0;
            string query = "SELECT AdminId FROM Admins WHERE UserId = @UserId";
            Dictionary<string, string> parameters = new Dictionary<string, string>()
            {
                { "@UserId", userId.ToString() }
            };

            DataTable result = dataService.Selection(query, parameters);

            if (result != null && result.Rows.Count > 0)
            {
                adminId = Convert.ToInt32(result.Rows[0]["AdminId"]);
            }

            return adminId;
        }

        public int GetMedicId(int userId)
        {
            int medicId = 0;
            string query = "SELECT MedicId FROM Medics WHERE UserId = @UserId";
            Dictionary<string, string> parameters = new Dictionary<string, string>()
             {
                 { "@UserId", userId.ToString() }
             };

            try
            {
                DataTable result = dataService.Selection(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    medicId = Convert.ToInt32(result.Rows[0]["MedicId"]);
                }
                else
                {
                    // Puedes agregar un mensaje de log para verificar qué está pasando
                    Console.WriteLine($"No se encontró ningún MedicId para UserId: {userId}");
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al obtener MedicId para UserId {userId}: {ex.Message}");
                throw;
            }

            return medicId;
        }

    }
}

