using System.Windows;
using System;

namespace HospitalManagementSystem.Views.Windows
{
    /// <summary>
    /// Interaction logic for DoctorDashboardWindow.xaml
    /// </summary>
    public partial class DoctorDashboardWindow : Window
    {
        public DoctorDashboardWindow()
        {
            
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // In a real application, you would clear the session/authentication token here.

            // Open the login window and close the dashboard
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
