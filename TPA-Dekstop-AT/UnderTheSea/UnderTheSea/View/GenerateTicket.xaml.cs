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
    /// Interaction logic for GenerateTicket.xaml
    /// </summary>
    public partial class GenerateTicket : Window
    {
        public GenerateTicket()
        {
            InitializeComponent();
        }

        private void generateTicket_Click(object sender, RoutedEventArgs e)
        {
            TicketController tc = TicketController.getInstance();
            tc.generateTicket(kidComboBox.SelectedIndex, adultComboBox.SelectedIndex, elderComboBox.SelectedIndex, DateTime.Now);
            MessageBox.Show("Generate a total of " + (kidComboBox.SelectedIndex+ adultComboBox.SelectedIndex+ elderComboBox.SelectedIndex)+" ticket(s)");
        }
    }
}
