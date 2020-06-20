using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using UnderTheSea.Controller;

namespace UnderTheSea.View
{
    /// <summary>
    /// Interaction logic for ManageTicket.xaml
    /// </summary>
    public partial class ManageTicket : Window
    {
        private TicketController tc;
        public ManageTicket()
        {
            InitializeComponent();
        }
        
     //   public void AllowUpdate(object sender, RoutedEventArgs e)
       
       // public void Delete(object sender, RoutedEventArgs e)
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tc  = TicketController.getInstance();
            List<Ticket> tickets = tc.getAllTicket();
            //List<DataGridColumn> columns = new List<DataGridColumn>();
            
            
            
            //dataGrid.Columns[0] = dataGrid.Columns[1];

            // DataGridColumn dgc = dataGrid.Columns.Where(x => x.Header.ToString() == "Delete").FirstOrDefault();
            // deleteBtn = (Button)(LogicalTreeHelper.FindLogicalNode(template.LoadContent(), "DeleteBtn"));
            // MessageBox.Show(deleteBtn.Content.ToString());
            // deleteBtn.Content = "Hello";
            // deleteBtn.Click += deleteTicket;
            //dataGrid.Items.
            refreshTable();
            

        }
        void deleteTicket(object sender, RoutedEventArgs e)
        {
            Ticket t = ((FrameworkElement)sender).DataContext as Ticket;
            tc.deleteTicket(t);
            refreshTable();
        }   
        void refreshTable()
        {
            List<Ticket> tickets = tc.getAllTicket();
            dataGrid.ItemsSource = tickets;
        }
        void editTicket(object sender, RoutedEventArgs e)
        {
            Ticket t = ((FrameworkElement)sender).DataContext as Ticket;
            EditTicket editWindow = new EditTicket(t);
            editWindow.Show();
            refreshTable();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            refreshTable();
        }
        public void generateQrCode(object sender, RoutedEventArgs e)
        {
            Ticket t = ((FrameworkElement)sender).DataContext as Ticket;
            WriteableBitmap wb = tc.generateQRCode(t);
            QrCode qrCodeWindow = new QrCode(wb);
            qrCodeWindow.Show();
        }
    }

}
