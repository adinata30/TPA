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
using System.Windows.Shapes;
using UnderTheSea.Controller;
using UnderTheSea.View;

namespace UnderTheSea
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginController lc = LoginController.getInstance();
            int employeeID = 0;
            try
            {
                employeeID = Int32.Parse(idField.Text);
            }
            catch
            {
                employeeID = -1;
            }
            
            Employee loggedIn = lc.doLogin(employeeID, passwordField.Password);
            if(loggedIn != null)
            {
                Window newWindow;
                //MessageBox.Show(loggedIn.EmployeePosition);
                if (loggedIn.EmployeePosition == "Attraction")
                {
                    newWindow = new Attraction();
                    newWindow.Show();
                }
                else if(loggedIn.EmployeePosition == "Front Office")
                {
                    newWindow = new FrontOffice();
                    newWindow.Show();
                }
                else if(loggedIn.EmployeePosition=="Ride")
                {
                    newWindow = new RideAndAttraction();
                    newWindow.Show();
                }
                else if(loggedIn.EmployeePosition == "Sales And Advertisement")
                {
                    newWindow = new SalesAndAdvertisement();
                    newWindow.Show();
                }
                else if (loggedIn.EmployeePosition == "Human Resource")
                {
                    newWindow = new HumanResource();
                    newWindow.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("ID or password is incorrect. Please try again.");
            }
        }
    }
}
