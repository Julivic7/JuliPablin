namespace Venar.Entities
{
    public class ResetPassword
    {
        public string Temporal {  get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
        public string SetMail { get; set; }
    }
}
