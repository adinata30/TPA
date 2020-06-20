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
    /// Interaction logic for EditParade.xaml
    /// </summary>
    public partial class EditParade : Window
    {
        private Parade p,newP;
        private ParadeController pc;
        public EditParade(Parade p)
        {
            this.p = p;
            newP = p;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pc = ParadeController.getInstance();

            id.Content = p.ActivityID + "";
            nameBox.Text = p.ActivityName;
            descriptionBox.Text = p.ActivityDescription;
            type.Content = p.ActivityType;
            status.Content = p.Status;
            countBox.Text = p.PeopleCount+"";
            durationBox.Text = p.ActivityDuration + "";
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            int duration = 0;
            try
            {
                count = Int32.Parse(countBox.Text);
                duration = Int32.Parse(durationBox.Text);
            }
            catch
            {
                MessageBox.Show("People involved and duration must be a number");
                return;
            }
            newP.ActivityDescription = descriptionBox.Text;
            newP.ActivityDuration = duration;
            newP.ActivityName = nameBox.Text;
            newP.PeopleCount = count;
            pc.updateParade(p, newP);
            MessageBox.Show("Update succesful!");
            this.Close();
        }
    }
}
