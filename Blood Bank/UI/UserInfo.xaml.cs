using Blood_Bank.DataAccessObjects;
using Blood_Bank.Entities;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Blood_Bank.UI
{
    /// <summary>
    /// Interaction logic for UserInfo.xaml
    /// 
    /// Written By: Abtahi
    /// </summary>
    public partial class UserInfo : UserControl
    {
        UserEntity user = new UserEntity();
        IUserOperation userOperation = new UserOperation(); 

        public UserInfo()
        {
            InitializeComponent();

            FillDataGridWithDonorData();
        }

        private void FillDataGridWithDonorData()
        {
            DataTable userDataTable = new DataTable();

            try
            {
                userDataTable = userOperation.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            userDataGrid.ItemsSource = null;
            userDataGrid.ItemsSource = userDataTable.DefaultView;
            userDataGrid.Items.Refresh();
        }

        private void searchByEmailButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.Email = emailTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Arguments", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            DataTable usersDataTable = new DataTable();

            try
            {
                usersDataTable = userOperation.SearchUserByEmail(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (usersDataTable.Rows.Count > 0)
            {
                userDataGrid.ItemsSource = null;
                userDataGrid.ItemsSource = usersDataTable.DefaultView;
                userDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("No Records Found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchByBGButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.BloodGroup = bloodGroupComboBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Arguments", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            DataTable usersDataTable = new DataTable();

            try
            {
                usersDataTable = userOperation.SearchUsersByBloodGroup(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (usersDataTable.Rows.Count > 0)
            {
                userDataGrid.ItemsSource = null;
                userDataGrid.ItemsSource = usersDataTable.DefaultView;
                userDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("No Records Found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void logoutSubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Start());
        }

        private void donorListSubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FillDataGridWithDonorData();
        }

        private void exitSubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void aboutSubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Virtual Blood Bank V1.0.1 \n" + "https://github.com/MinhazAbtahi/", "About", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void profileSubMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new UserProfile());
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new UserProfile());
        }

        private void donorListButton_Click(object sender, RoutedEventArgs e)
        {
            FillDataGridWithDonorData();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Start());
        }
    }
}
