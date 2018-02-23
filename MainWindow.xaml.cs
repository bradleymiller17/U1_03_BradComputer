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

namespace U1_03_BradleyComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cpu_btn_Click(object sender, RoutedEventArgs e)
        {
            cpu_btn.Visibility = System.Windows.Visibility.Visible;
            cpu_img.Visibility = System.Windows.Visibility.Visible;         
        }

        private void motherboard_btn_Click(object sender, RoutedEventArgs e)
        {
            motherboard_btn.Visibility = System.Windows.Visibility.Visible;
            motherboard_img.Visibility = System.Windows.Visibility.Visible;
        }

        private void ram_btn_Click(object sender, RoutedEventArgs e)
        {
            ram_btn.Visibility = System.Windows.Visibility.Visible;
            ram_img.Visibility = System.Windows.Visibility.Visible;
        }

        private void storage_btn_Click(object sender, RoutedEventArgs e)
        {
            storage_btn.Visibility = System.Windows.Visibility.Visible;
            storage_img.Visibility = System.Windows.Visibility.Visible;
        }

        private void case_btn_Click(object sender, RoutedEventArgs e)
        {
            case_btn.Visibility = System.Windows.Visibility.Visible;
            case_img.Visibility = System.Windows.Visibility.Visible;
        }

        private void power_supply_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
