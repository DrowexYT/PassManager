using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls;

namespace projekt_PassManager
{
    public partial class PasswordManagerWindow : Window
    {
        public ObservableCollection<PasswordEntry> PasswordEntries { get; set; } = new ObservableCollection<PasswordEntry>();

        private Account loggedInAccount;

        public PasswordManagerWindow(Account account)
        {
            InitializeComponent();
            loggedInAccount = account;

            // Add some placeholder entries for demonstration
            PasswordEntries.Add(new PasswordEntry("Google", "user@gmail.com", "password123"));
            PasswordEntries.Add(new PasswordEntry("Facebook", "fb_user", "securePass!"));
            PasswordEntries.Add(new PasswordEntry("Instagram", "insta_user", "hiddenSecret"));

            PasswordDataGrid.ItemsSource = PasswordEntries;
        }

        private void RemoveService_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Service serviceToRemove)
            {
                PasswordEntries.Remove(serviceToRemove);

                // Refresh the DataGrid
                PasswordDataGrid.ItemsSource = null;
                PasswordDataGrid.ItemsSource = PasswordEntries;
            }
        }

        private void ShowPassword_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Service service)
            {
                MessageBox.Show($"Password: {service.ServicePassword}", "Show Password", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }




        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
