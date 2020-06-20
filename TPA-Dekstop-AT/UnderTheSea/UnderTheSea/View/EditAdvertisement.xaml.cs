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
    /// Interaction logic for EditAdvertisement.xaml
    /// </summary>
    public partial class EditAdvertisement : Window
    {
        private AdvertisementController ac;
        private Advertisement oldAds, newAds;
        public EditAdvertisement(Advertisement ads)
        {
            oldAds = newAds = ads;
            InitializeComponent();
        }

        private void EditAdvertisement_Click(object sender, RoutedEventArgs e)
        {
            newAds.AdvertisementName = nameBox.Text;
            newAds.AdvertisementDescription = descriptionBox.Text;
            ac.updateAdvertisement(oldAds, newAds);
            MessageBox.Show("Update Succesful!");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ac = AdvertisementController.getInstance();
            id.Content = oldAds.AdvertisementID;
            nameBox.Text = oldAds.AdvertisementName;
            descriptionBox.Text = oldAds.AdvertisementDescription;
        }
    }
}
