using Venar.DTO;

namespace Venar.SVC
{
    public class ValidCreateMedic
    {
        MenuAdminSVC createMedicSVC = new MenuAdminSVC();

        public void ValidatedUser(ResultDto result, MedicDto obj)
        {
            obj.Name = obj.Name.Trim();
            obj.LastName = obj.LastName.Trim();
            obj.Dni = obj.Dni.Trim();
            obj.Mail = obj.Mail.Trim();
            obj.MedicalRegistration = obj.MedicalRegistration.Trim();
            obj.UserName = obj.UserName.Trim();
            obj.Password = obj.Password.Trim();

            if (string.IsNullOrEmpty(obj.Name))
            {
                result.Errors.Add("El Nombre es obligatorio.");
            }
            if (string.IsNullOrEmpty(obj.LastName))
            {
                result.Errors.Add("El Apellido es obligatorio.");
            }
            if (string.IsNullOrEmpty(obj.Dni))
            {
                result.Errors.Add("El Dni es obligatorio.");
            }
            if (string.IsNullOrEmpty(obj.Mail))
            {
                result.Errors.Add("Debe ingresar el Mail.");
            }
            if (obj.SpecialtyId == 0)
            {
                result.Errors.Add("Debe seleccionar una especialidad.");
            }
            if (string.IsNullOrEmpty(obj.MedicalRegistration))
            {
                result.Errors.Add("Debe ingresar una Matricula medica.");
            }
            if (string.IsNullOrEmpty(obj.UserName))
            {
                result.Errors.Add("El Nombre de usuario es Obligatorio.");
            }
            if (string.IsNullOrEmpty(obj.Password))
            {
                result.Errors.Add("Debe ingresar una contraseña.");
            }
        }
        public ResultDto CreateReallyUser(MedicDto obj)
        {
            var resultDto = new ResultDto();

            // Perform validation
            ValidatedUser(resultDto, obj);

            if (resultDto.IsSuccess)
            {
                try
                {
                    // Attempt to create the medic if validation passed
                    createMedicSVC.CreateMedic(obj);
                    resultDto.Message = "Medic created successfully.";
                }
                catch (Exception ex)
                {
                    resultDto.Errors.Add("Error al crear el médico: " + ex.Message);
                }
            }

            return resultDto;
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
