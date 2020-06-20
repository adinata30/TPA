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
    /// Interaction logic for AddAdvertisement.xaml
    /// </summary>
    public partial class AddAdvertisement : Window
    {
        private AdvertisementController ac;
        public AddAdvertisement()
        {
            InitializeComponent();
        }

        private void AddAdvertisement_Click(object sender, RoutedEventArgs e)
        {
            ac.addAdvertisement(nameBox.Text, descriptionBox.Text);
            MessageBox.Show("Insert Succesfully");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ac = AdvertisementController.getInstance();
            id.Content = ac.getLastIndex() + 1;            
        }
    }
}
