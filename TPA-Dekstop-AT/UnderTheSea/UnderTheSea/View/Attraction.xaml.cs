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
using UnderTheSea.View;

namespace UnderTheSea
{
    /// <summary>
    /// Interaction logic for Attraction.xaml
    /// </summary>
    public partial class Attraction : Window
    {
        public Attraction()
        {
            InitializeComponent();
        }

        private void manageTicket_Click(object sender, RoutedEventArgs e)
        {
            Window manageTicketWindow = new ManageTicket();
            manageTicketWindow.Show();
        }

        private void generateTicket_Click(object sender, RoutedEventArgs e)
        {
            Window generateTicketWindow = new GenerateTicket();
            generateTicketWindow.Show();
            
        }

        private void validateTicket_Click(object sender, RoutedEventArgs e)
        {
            Window validateTicketWindow = new ValidateTicket();
            validateTicketWindow.Show();

        }
    }
}
