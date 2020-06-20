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
    /// Interaction logic for ManageRide.xaml
    /// </summary>
    public partial class ManageRide : Window
    {
        private RideController pc;
        public ManageRide()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            AddRide addWindow = new AddRide();
            addWindow.Show();
            refreshTable();
        }

        private void refreshBtnClick(object sender, RoutedEventArgs e)
        {
            refreshTable();
        }
        private void deleteRide(object sender, RoutedEventArgs e)
        {
            Ride par = ((FrameworkElement)sender).DataContext as Ride;
            pc.deleteRide(par);
            refreshTable();
        }
        private void editRide(object sender, RoutedEventArgs e)
        {
            Ride par = ((FrameworkElement)sender).DataContext as Ride;
             EditRide editWindow = new EditRide(par);
            editWindow.Show();
            refreshTable();
        }
        public void refreshTable()
        {
            List<Ride> rides = pc.getAllRide();

            dataGrid.ItemsSource = rides;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string test = pc == null ? "Null" : "Not Null";
            //MessageBox.Show(test);
            pc = RideController.getInstance();
             refreshTable();
            
        }
    }
}
