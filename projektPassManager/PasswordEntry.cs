namespace projekt_PassManager
{
    public class PasswordEntry
    {
        public string Service { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string HiddenPassword => IsPasswordVisible ? Password : "********";

        private bool IsPasswordVisible { get; set; }

        public PasswordEntry(string service, string username, string password)
        {
            Service = service;
            Username = username;
            Password = password;
            IsPasswordVisible = false;
        }

        public void TogglePasswordVisibility()
        {
            IsPasswordVisible = !IsPasswordVisible;
        }
    }
}
