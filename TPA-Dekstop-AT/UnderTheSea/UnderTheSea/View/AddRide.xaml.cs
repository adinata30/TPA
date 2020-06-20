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
    /// Interaction logic for AddRide.xaml
    /// </summary>
    public partial class AddRide : Window
    {
        private RideController rc;
        public AddRide()
        {
            InitializeComponent();
        }

        private void AddRide_Click(object sender, RoutedEventArgs e)
        {
            int age, dur, height;
            try
            {
                age = Int32.Parse(AgeBox.Text);
                height = Int32.Parse(heightBox.Text);
                dur = Int32.Parse(durationBox.Text);
            }
            catch
            {
                MessageBox.Show("Age, Height, and Duration Must Be int");
                return;

            }
            rc.addRide(nameBox.Text, descriptionBox.Text, dur, age, height, RestrictionBox.Text);
            MessageBox.Show("Add Succesful");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rc = RideController.getInstance();
            id.Content = (rc.getLastIndex() + 1) + "";

        }
    }
}
