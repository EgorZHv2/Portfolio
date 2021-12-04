using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Portfolio.Pages
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void BTMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            bt.Background = new SolidColorBrush(Color.FromRgb(66, 106, 30)); 
            
        }

        private void BTMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            bt.Background = new SolidColorBrush(Color.FromRgb(100, 161, 46));
        }

        private void BTRegistration_Click(object sender, RoutedEventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            NavigationService.Navigate(registrationPage);
            
        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }
    }
   
}
