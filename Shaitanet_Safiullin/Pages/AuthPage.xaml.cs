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

namespace Shaitanet_Safiullin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {

            if (App.db.User.ToList().Any(x => x.Login == LoginTb.Text && x.Password == PassTb.Text))
            {
                
                App.currentUser = App.db.User.ToList().First(x => x.Login == LoginTb.Text && x.Password == PassTb.Text);
                if (App.currentUser.Id_Role == 1)
                {
                NavigationService.Navigate(new ProductsPage());
                    MessageBox.Show("Добро пожаловать Модератор " + App.currentUser.Name + " " + App.currentUser.Surname);
                }
                else
                {
                    MessageBox.Show("Вы не модератор, интерфейс для вашей роли еще не разработан");
                    LoginTb.Text = "";
                    PassTb.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Вход не успешный!");
            }
       
    }
    }
}
