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
    /// Interaction logic for ManageEmployeeData.xaml
    /// </summary>
    public partial class ManageEmployeeData : Window
    {
        EmployeeController ec;
        public ManageEmployeeData()
        {
            
            InitializeComponent();
        }

        private void refreshBtnClick(object sender, RoutedEventArgs e)
        {
            refreshTable();
        }

        private void insertNewEmployeeBtn(object sender, RoutedEventArgs e)
        {
            AddEmployee addWindow = new AddEmployee();
            addWindow.Show();
            
        }
        private void deleteEmployee(object sender, RoutedEventArgs e)
        {
            Employee em = ((FrameworkElement)sender).DataContext as Employee;
            ec.deleteEmployee(em);
            refreshTable();
        }
        private void editEmployee(object sender, RoutedEventArgs e)
        {
            Employee em = ((FrameworkElement)sender).DataContext as Employee;
            EditEmployee editWindow = new EditEmployee(em);
            editWindow.Show();
            refreshTable();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ec = EmployeeController.getInstance();
            refreshTable();
        }
        public void refreshTable()
        {
            List<Employee> employees = ec.getAllEmployee();
            dataGrid.ItemsSource = employees; 
        }
    }
}
