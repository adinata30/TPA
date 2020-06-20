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
    /// Interaction logic for ManageAdvertisement.xaml
    /// </summary>
    public partial class ManageAdvertisement : Window
    {
        private AdvertisementController ac;
        public ManageAdvertisement()
        {
            InitializeComponent();
        }

        private void refreshBtnClick(object sender, RoutedEventArgs e)
        {
            refreshTable();
        }
        public void refreshTable()
        {
            List<Advertisement> ads = ac.getAllAdvertisement();
            dataGrid.ItemsSource = ads;
        }

        private void insertNewEmployeeBtn(object sender, RoutedEventArgs e)
        {
            AddAdvertisement addWindow = new AddAdvertisement();
            addWindow.Show();
            
        }
        private void deleteAdvertisement(object sender, RoutedEventArgs e)
        {
            Advertisement ads = ((FrameworkElement)sender).DataContext as Advertisement;
            ac.deleteAdvertisement(ads);
            refreshTable();
        }
        private void editAdvertisement(object sender, RoutedEventArgs e)
        {
            Advertisement ads = ((FrameworkElement)sender).DataContext as Advertisement;
            EditAdvertisement editWindow = new EditAdvertisement(ads);
            editWindow.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ac = AdvertisementController.getInstance();
            refreshTable();
        }
    }
}
