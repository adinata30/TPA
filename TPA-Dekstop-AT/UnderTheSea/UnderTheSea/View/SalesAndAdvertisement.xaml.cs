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
    /// Interaction logic for SalesAndAdvertisement.xaml
    /// </summary>
    public partial class SalesAndAdvertisement : Window
    {
        public SalesAndAdvertisement()
        {
            InitializeComponent();
        }

        private void manageAdvertisement_Click(object sender, RoutedEventArgs e)
        {
            ManageAdvertisement manageWindow = new ManageAdvertisement();
            manageWindow.Show();
        }
    }
}
