using Blood_Bank.DataAccessObjects;
using Blood_Bank.Entities;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Blood_Bank.UI
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// 
    /// Written By: Abtahi
    /// </summary>
    public partial class UserProfile : UserControl
    {
        UserEntity user = new UserEntity();
        IUserOperation userOperation = new UserOperation();
 
        public UserProfile()
        {
            InitializeComponent();

            FillUserInfo();
        }

        private void FillUserInfo()
        {
            user.Email = Login.activeUserEmail;

            DataTable userDataTable = new DataTable();

            try
            {
                userDataTable = userOperation.SearchUserByEmail(user);

                firstNameTextBlock.Text = userDataTable.Rows[0]["FIRSTNAME"].ToString();
                lastNameTextBlock.Text = userDataTable.Rows[0]["LASTNAME"].ToString();
                bloodGroupTextBlock.Text = userDataTable.Rows[0]["BLOOD_GROUP"].ToString();
                emailTextBlock.Text = userDataTable.Rows[0]["EMAIL"].ToString();
                contactNoTextBlock.Text = userDataTable.Rows[0]["CONTACT_NO"].ToString();
                addressTextBlock.Text = userDataTable.Rows[0]["ADDRESS"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new UserInfo());
        }
    }
}
