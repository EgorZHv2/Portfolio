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
using Portfolio.AppData;

namespace Portfolio.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
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
            bool error = false;
            if (BoxFirstName.Text == "" | BoxLastName.Text == "" | BoxLogin.Text == "" | BoxPass.Password == "")
            {
                NotAllFields();
                error = true;
            }
            for (int i = 1; i <= PortfolioEntities.GetContext().Users.Count(); i++)
            {
                
                if (PortfolioEntities.GetContext().Users.Find(i).Login.ToLower() == BoxLogin.Text.ToLower())
                {
                    error = true;
                    DoubleLogin();
                }
               
            }


            
        }
        async void NotAllFields()
        {
            BoxNotAllFields.Visibility = Visibility.Visible;
            await Task.Delay(3000);
            BoxNotAllFields.Visibility = Visibility.Hidden;
        }
        async void DoubleLogin()
        {
            BoxDoubleLogin.Visibility = Visibility.Visible;
            await Task.Delay(3000);
            BoxDoubleLogin.Visibility = Visibility.Hidden;
        }
        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);
        }
    }
}
