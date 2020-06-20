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
    /// Interaction logic for RideAndAttraction.xaml
    /// </summary>
    public partial class RideAndAttraction : Window
    {
        public RideAndAttraction()
        {
            InitializeComponent();
        }

        private void ManageParade_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ManageRide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void manageRideBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageRide manageWindow = new ManageRide();
            manageWindow.Show();
        }

        private void manageParadeBtn_Click(object sender, RoutedEventArgs e)
        {
            ManageParade manageWindow = new ManageParade();
            manageWindow.Show();
        }
    }
}
