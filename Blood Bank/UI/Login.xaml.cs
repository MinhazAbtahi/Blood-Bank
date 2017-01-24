using Blood_Bank.DataAccessObjects;
using Blood_Bank.Entities;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Blood_Bank.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// 
    /// Written By: Abtahi
    /// </summary>
    public partial class Login : UserControl
    {
        public static string activeUserEmail = null;

        private UserEntity user = new UserEntity();
        private IUserOperation userOperation = new UserOperation();

        public Login()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable userDataTable = new DataTable();

            try
            {
                user.Email = emailTextBox.Text;
                user.Password = passwordBox.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Arguments!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                userDataTable = userOperation.ValidateUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (userDataTable.Rows.Count > 0)
            {
                activeUserEmail = user.Email;
                Switcher.Switch(new UserInfo());
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Start());
        }
    }
}
