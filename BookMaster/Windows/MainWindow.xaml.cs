using BookMaster.Windows;
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

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Visible;
        }

        private void LoginMi_Click(object sender, RoutedEventArgs e)
        {
            //Для реализации оконной навигации нужно:
            //1) Сщдать экземпляра
            LoginWindow loginWindow = new LoginWindow();

            //2) У экземпляр окно, которое требуется открыть
            loginWindow.ShowDialog();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageCustomersMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BrowseCatalogMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
