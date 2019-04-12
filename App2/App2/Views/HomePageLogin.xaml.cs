using App2.Data;
using App2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePageLogin : ContentPage
    {
        //string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "GestionaleXamarinDB.db");

        public HomePageLogin()
        {
            InitializeComponent();
            Init(); 
        }

        void Init()
        {
            entryUser.Completed += (s, e) => entryPassword.Focus();
            entryPassword.Completed += (s, e) => log(s, e);
        }

        private void log(object s, EventArgs e)
        {
            Navigation.PushAsync(new DashboardPage());
        }
    }
}