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
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();

            List.ItemsSource = PortfolioEntities.GetContext().Users.ToList();
            Users user = new Users() 
            {
                FirstName = "Иван",
                LastName = "Иванович",
                Login = "Ivanovich",
                Password = "12345678",
            };
        }       
    }
}
