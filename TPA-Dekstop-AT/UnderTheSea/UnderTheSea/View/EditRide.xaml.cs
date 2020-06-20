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
    /// Interaction logic for EditRide.xaml
    /// </summary>
    public partial class EditRide : Window
    {
        private Ride r,newR;
        private RideController rc;
        public EditRide(Ride r)
        {
            this.r = r;
            newR = r;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rc = RideController.getInstance();
            id.Content = r.ActivityID+"";
            status.Text = r.Status;
            type.Content = r.ActivityType;
            nameBox.Text = r.ActivityName;
            durationBox.Text = r.ActivityDuration+"";
            descriptionBox.Text = r.ActivityDescription;
            heightBox.Text = r.MinHeight + "";
            AgeBox.Text = r.MinAge + "";
            RestrictionBox.Text = r.Restriction;

        }

        private void UpdateRide_Click(object sender, RoutedEventArgs e)
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
            newR.Status = status.Text;
            newR.ActivityName = nameBox.Text;
            newR.ActivityDuration = dur;
            newR.ActivityDescription = descriptionBox.Text;
            newR.MinHeight = height;
            newR.MinAge = age;
            newR.Restriction = RestrictionBox.Text;
            rc.updateRide(r, newR);
            MessageBox.Show("Update Succesful");
            this.Close();
        }
    }
}
