using ShoppingCenter.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingCenter.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 0;
            gridTabContentNewInvoice.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 1;
            gridTabContentOpenInvoiceId.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 2;
            gridTabContentOpenInvoicesByEmployee.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 3;
            gridTabContentOpenInvoiceDate.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 4;
            gridTabContentAddEmployee.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 5;
            gridTabContentAddItem.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 6;
            gridTabContentRequests.Visibility = Visibility.Visible;
        }
    }
}
