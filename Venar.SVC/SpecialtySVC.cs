using Venar.Entities;
using Venar.Data;

namespace Venar.SVC
{
    public class SpecialtySVC
    {
        private DataServices dataServices; 
        public SpecialtySVC()
        {
            dataServices = new DataServices(); 
        }

        public void InsertSpecialty(Specialty specialty)
        {
            string sqlInsert = "INSERT INTO Specialty (SpecialityName, Description) " +
                               "VALUES (@SpecialtyName, @Description)";

            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "@SpecialtyName", specialty.SpecialtyName },
                { "@Description", specialty.Description }
            };

            try
            {
                int rowsAffected = dataServices.Execute(sqlInsert, parameters);

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
                throw new Exception("Error al insertar especialidad: " + ex.Message, ex);
            }
        }
    }
}
