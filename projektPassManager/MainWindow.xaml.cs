using System.Linq;
using System.Windows;

namespace projekt_PassManager
{
    public partial class MainWindow : Window
    {
        private AccountManager accountManager = new AccountManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            string usernameInput = username.Text.Trim();
            string passwordInput = password.Text.Trim();

            var account = accountManager.Accounts.FirstOrDefault(a => a.Username == usernameInput && a.Password == passwordInput);
            if (account != null)
            {
                MessageBox.Show("You have logged in successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Open Password Manager window
                PasswordManagerWindow passwordManager = new PasswordManagerWindow(account);
                passwordManager.Show();

                // Hide the main window
                this.Hide();

                // When the password manager window is closed, show the main window again
                passwordManager.Closed += (s, args) => this.Show();

                // Clear input fields
                username.Text = string.Empty;
                password.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            string usernameInput = registerUsername.Text.Trim();
            string passwordInput = registerPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usernameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!accountManager.IsUsernameUnique(usernameInput))
            {
                MessageBox.Show("This username is already taken. Please choose another one.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Add account and update the account list
            accountManager.AddAccount(new Account(usernameInput, passwordInput));
            AccountList.ItemsSource = null; // Reset binding
            AccountList.ItemsSource = accountManager.Accounts;

            MessageBox.Show("Account registered successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear input fields
            registerUsername.Text = string.Empty;
            registerPassword.Text = string.Empty;
        }
    }
}
