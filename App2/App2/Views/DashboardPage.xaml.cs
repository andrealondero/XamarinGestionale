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
    public partial class DashboardPage : ContentPage
    {
        string path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "GestionaleXamarinDB.db");
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void Timesheetcompiler_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TSCompilerPage());
        }

        private void Timesheetviewer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TSViewerPage());
        }

        private void Confirmation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ConfirmationPage());
        }
    }
}