using Venar.Entities;
using Venar.Data;

namespace Venar.SVC
{
    public class LocationSVC
    {
        private DataServices dataService = new DataServices();

        public LocationSVC()
        {
        }

        public void InsertLocation(Location location)
        {
            
            string sqlInsert = "INSERT INTO Location (Name, Province, PostalCode) " +
                               "VALUES (@Name, @Province, @PostalCode)";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@Name", location.LocationName },
                { "@Province", location.Province },
                { "@PostalCode", location.PostalCode }
            };

            try
            {
                int rowsAffected = dataService.Execute(sqlInsert, parameters);

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Inserción exitosa");
                }
                else
                {
                    Console.WriteLine("La inserción no tuvo éxito.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar ubicación: " + ex.Message, ex);
            }
        }
    }
}
