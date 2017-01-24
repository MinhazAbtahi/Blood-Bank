using System.Windows;
using System.Windows.Controls;

namespace Blood_Bank.UI
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// 
    /// Written By: Abtahi
    /// </summary>
    public partial class Start : UserControl
    {
        public Start()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Login());
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Register());
        }
    }
}
