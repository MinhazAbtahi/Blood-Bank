using Blood_Bank.DataAccessObjects;
using Blood_Bank.Entities;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Blood_Bank.UI
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// 
    /// Written By: Abtahi
    /// </summary>
    public partial class Register : UserControl
    {
        private UserEntity user = new UserEntity();
        private IUserOperation userOperation = new UserOperation();
        private DataTable userDataTable = new DataTable();

        public Register()
        {
            InitializeComponent();

            dobDatePicker.SelectedDate = DateTime.Now;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.FirstName = firstNameTextBox.Text;
                user.LastName = lastNameTextBox.Text;
                user.Password = passwordBox.Password;
                user.BloodGroup = bloodGroupComboBox.Text;
                user.Gender = genderComboBox.Text;
                user.Dob = dobDatePicker.Text;
                user.Email = emailTextBox.Text;
                user.ContactNo = Convert.ToInt32(contactNoTextBox.Text);
                user.Address = addressTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Arguments", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            int rowsAffected = 0;
            try
            {
                rowsAffected = userOperation.InsertUser(user);
            }
            catch (Exception)
            {
                MessageBox.Show("SQLError!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (rowsAffected < 0)
            {
                MessageBox.Show("User Registration Successfull!", "User Registration", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("User Registration Failed!", "User Registration", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Start());
        }
    }
}
