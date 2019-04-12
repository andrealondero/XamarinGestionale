using App2.Data;
using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TSCompilerPage : ContentPage
    {
        private TSItemsManager dataAccess;
        public TSCompilerPage()
        {
            InitializeComponent();
            this.dataAccess = new TSItemsManager();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.BindingContext = this.dataAccess;
        }

        public void OnAdd(object sender, EventArgs e)
        {
            this.dataAccess.AddNewTSItems();
        }


    private void OnEsc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DashboardPage());
        }
    }
}