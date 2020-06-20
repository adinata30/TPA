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

namespace UnderTheSea
{
    /// <summary>
    /// Interaction logic for QrCode.xaml
    /// </summary>
    public partial class QrCode : Window
    {
        WriteableBitmap img;
        public QrCode(WriteableBitmap image)
        {
            this.img = image;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                image.Source = img;
            }
            catch
            {
                MessageBox.Show("Failed To Generate QR Code");
            }
        }
    }
}
