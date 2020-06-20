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
    /// Interaction logic for ManageParade.xaml
    /// </summary>
    public partial class ManageParade : Window
    {
        private ParadeController pc;
        public ManageParade()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            AddParade addWindow = new AddParade();
            addWindow.Show();
            refreshTable();
        }

        private void refreshBtnClick(object sender, RoutedEventArgs e)
        {
            refreshTable();
        }
        private void deleteParade(object sender, RoutedEventArgs e)
        {
            Parade par = ((FrameworkElement)sender).DataContext as Parade;
            pc.deleteParade(par);
            refreshTable();
        }
        private void editParade(object sender, RoutedEventArgs e)
        {
            Parade par = ((FrameworkElement)sender).DataContext as Parade;
            EditParade editWindow = new EditParade(par);
            editWindow.Show();
            refreshTable();
        }
        public void refreshTable()
        {
            List<Parade> parades = pc.getAllParade();
            
            dataGrid.ItemsSource = parades;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pc = ParadeController.getInstance();
            refreshTable();
        }
    }
}
