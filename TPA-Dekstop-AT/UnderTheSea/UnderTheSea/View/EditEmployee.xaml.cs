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
    /// Interaction logic for EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        private Employee em;
        private Employee newEm;
        private EmployeeController ec;
        public EditEmployee(Employee e)
        {
            em = e;
            newEm = e;
            InitializeComponent();
        }

        private void updateBtn(object sender, RoutedEventArgs e)
        {
            ec = EmployeeController.getInstance();
            newEm.EmployeeAddress = addresss.Text;
            newEm.EmployeeStatus = status.Text;
            newEm.EmployeePosition = position.Text;
            try
            {
                newEm.EmployeeSalary = Int32.Parse(salary.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect format for Salary");
                return;
            }
            ec.updateEmployee(em, newEm);
            MessageBox.Show("Succesfully Update!");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            id.Content = em.EmployeeId + "";
            name.Content = em.EmployeeName;
            gender.Content = em.EmployeeGender;
            passwordBox.Password = em.EmployeePassword;
            addresss.Text = em.EmployeeAddress;
            status.Text = em.EmployeeStatus;
            position.Text = em.EmployeePosition;
            salary.Text = em.EmployeeSalary+"";

            
        }
    }
}
