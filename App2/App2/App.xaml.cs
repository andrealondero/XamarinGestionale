using App2.Data;
using App2.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class App : Application
    {
        static UsersManager usdatabase;
        static TSItemsManager tsdatabase;

        public static UsersManager UsersManager
        {
            get
            {
                if (usdatabase == null)
                {
                    usdatabase = new UsersManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GestionaleXamarinDB.db"));
                }
                return usdatabase;
            }
        }

        public static TSItemsManager TSItemsManager
        {
            get
            {
                if (tsdatabase == null)
                {
                    tsdatabase = new TSItemsManager(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GestionaleXamarinDB.db"));
                }
                return tsdatabase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new HomePageLogin());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
