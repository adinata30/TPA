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

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for HumanResource.xaml
    /// </summary>
    public partial class HumanResource : Window
    {
        public HumanResource()
        {
            InitializeComponent();
        }

        private void manageEmployee(object sender, RoutedEventArgs e)
        {
            ManageEmployeeData manageWindow = new ManageEmployeeData();
            manageWindow.Show();
        }
    }
}
