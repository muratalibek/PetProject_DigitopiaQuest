namespace DigitopiaQuest.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
        public string EmailConfirmed { get; set; } = string.Empty;
        public string PasswordConfirmed { get; set; } = string.Empty;
    }
}
