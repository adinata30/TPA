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
    /// Interaction logic for AddParade.xaml
    /// </summary>
    public partial class AddParade : Window
    {
        private ParadeController pc;
        public AddParade()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            //Add
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
            pc.addParade(nameBox.Text, descriptionBox.Text, duration, count);
            MessageBox.Show("Add Succesful!");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pc = ParadeController.getInstance();
            id.Content = (pc.getLastIndex() + 1)+"";
            type.Content = "Parade";
            status.Content = "Active";
        }
    }
}
