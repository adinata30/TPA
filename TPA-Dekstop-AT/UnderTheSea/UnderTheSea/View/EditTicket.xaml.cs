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
    /// Interaction logic for EditTicket.xaml
    /// </summary>
    public partial class EditTicket : Window
    {
        private Ticket oldTicket;
        private Ticket newTicket;
        public EditTicket(Ticket oldTicket)
        {
            InitializeComponent();
            this.oldTicket = oldTicket;
            this.newTicket = this.oldTicket;
        }

        private void updateTIcket(object sender, RoutedEventArgs e)
        {
            TicketController tc = TicketController.getInstance();
            newTicket.TicketDate = DateTime.Now;
            newTicket.TicketPrice = Int32.Parse(price.Content+"");
            newTicket.TicketStatus = "Modified";
            newTicket.TicketType = comboBox.SelectedIndex == 0 ? "Kid" : comboBox.SelectedIndex == 1 ? "Adult" : "Elder";
            MessageBox.Show(newTicket.TicketType);
            tc.updateTicket(oldTicket, newTicket);
            MessageBox.Show("Update Succesfully");
            this.Close();
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            id.Content = oldTicket.TicketID;
            if (oldTicket.TicketType == "Kid") comboBox.SelectedIndex = 0;
            else if (oldTicket.TicketType == "Adult") comboBox.SelectedIndex = 1;
            else comboBox.SelectedIndex = 2;
            price.Content = oldTicket.TicketPrice+"";
            date.Content = oldTicket.TicketDate.ToString();
            status.Content = oldTicket.TicketStatus;
            

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.IsLoaded == false) return;

            if (comboBox.SelectedIndex == 0)
            {
                price.Content = "15000";
            }
            else if (comboBox.SelectedIndex == 1) price.Content = "40000";
            else price.Content = "30000";
        }
    }
}
