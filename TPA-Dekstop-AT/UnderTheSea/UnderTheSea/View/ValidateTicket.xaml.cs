
using Microsoft.Win32;
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

using System.Drawing;
using Genesis.QRCodeLib;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
using UnderTheSea.Controller;

namespace UnderTheSea
{
    /// <summary>
    /// Interaction logic for ValidateTicket.xaml
    /// </summary>
    public partial class ValidateTicket : Window
    {
        public ValidateTicket()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //opf.ShowDialog();
           
            if (op.ShowDialog() == true)
            {
                try
                {
                   
                    image.Source = new BitmapImage(new Uri(op.FileName));
                    
                }
                catch
                {
                    MessageBox.Show("Please input an image file type");
                }
               

            }
        }

        private void validateBtn_Click(object sender, RoutedEventArgs e)
        {
            TicketController tc = TicketController.getInstance();
            bool validated=true;
            if (image.Source is BitmapImage)
            {
                validated = tc.validateTicket((BitmapImage)image.Source);
            }
            else
            {
                MessageBox.Show("Please Input correct Image");
                return;
            }
            if (validated == true)
            {
                MessageBox.Show("Successfully validate ticket, Welcome!");

            }
            else MessageBox.Show("Failed to Validate ticket, Please Try Again.");


        }
    }
}
