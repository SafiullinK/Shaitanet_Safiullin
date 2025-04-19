using Shaitanet_Safiullin.DB;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Shaitanet_Safiullin.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public static List<Product> prod = new List<Product>();
        public ProductsPage()
        {
            InitializeComponent();
            prod = App.db.Product.ToList();
            ProductLv.ItemsSource = prod;
        }

    

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
       

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ProductLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ProductLv.SelectedItem;
            var prod = ProductLv.SelectedItem as Product;
            NavigationService.Navigate(new AddEditProductPage(prod));
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
