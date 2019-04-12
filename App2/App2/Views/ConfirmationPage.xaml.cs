using App2.Data;
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
    public partial class ConfirmationPage : ContentPage
    {
        //private TSItemsManager dataAccess;
        public ConfirmationPage()
        {
            InitializeComponent();
            //this.dataAccess = new TSItemsManager();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


            //this.BindingContext = this.dataAccess;
        }
    }
}