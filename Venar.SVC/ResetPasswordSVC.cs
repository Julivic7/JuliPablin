using Venar.Data;
using Venar.Entities;

namespace Venar.SVC
{
    public class ResetPasswordSVC
    {
        DataServices dataServices = new DataServices();
        public string ResetPass(ResetPassword resetPassword)
        {
            if (resetPassword.Password == resetPassword.Temporal)
            {
                if (resetPassword.NewPassword == resetPassword.NewPasswordConfirm)
                {
                    Dictionary<string, string> parameters = new Dictionary<string, string>
                    {
                        { "@Password", resetPassword.NewPassword },
                        { "@setMail", resetPassword.SetMail }
                    };
                    string resetQuery = "UPDATE Users SET Password = @Password,  UpdatedAt = getdate() WHERE Mail = @setMail";

                    dataServices.Execute(resetQuery, parameters);

                    string message1 = "Contraseña actualizada correctamente.";

                    return message1;
                }
                else
                {
                    return "Las nuevas contraseñas no coinciden.";
                }
            }
            else
            {
                return "La contraseña temporal es incorrecta.";
            }
        }
    }
}
