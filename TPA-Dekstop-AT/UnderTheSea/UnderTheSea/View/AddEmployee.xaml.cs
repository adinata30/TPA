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

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {

        private EmployeeController ec;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void addEmployee(object sender, RoutedEventArgs e)
        {
           
            int sal = 0;
            try
            {
                sal = Int32.Parse(salary.Text);
            }
            catch
            {
                MessageBox.Show("Salary must be Integer");
                return;
            }
            string gender = genderButton.IsChecked == true ? "Male" : genderButton1.IsChecked == true ? "Female" : null;
            if (gender == null)
            {
                MessageBox.Show("Gender Must be chosen");
                return;
            }
            ec.addEmployee(name.Text, addresss.Text, gender, sal, position.Text, passwordBox.Password);
            MessageBox.Show("Insert Succesfully");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ec = EmployeeController.getInstance();
            id.Content = (ec.getEmployeeLastId() + 1)+"";
        }
    }
}
