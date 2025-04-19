using Shaitanet_Safiullin.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Shaitanet_Safiullin
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Shaitanet_Entities db = new Shaitanet_Entities();
        public static User currentUser;


    }
}
