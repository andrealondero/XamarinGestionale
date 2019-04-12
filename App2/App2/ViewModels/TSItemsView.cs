using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class TSItemsView : BindableObject
    {

        public int Id { get; set; }
        public string UserID { get; set; }
        public int Status
        {
            get
            {
                return Status;
            }
            set
            {
                if (value == Status)
                    return;
                Status = value;

                OnPropertyChanged();
            }
        }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hours { get; set; }
        public DateTime CR_date { get; set; }
        public DateTime MOD_date { get; set; }
        public int User { get; set; }

        string CheckUserStatus(int status)
        {
            var statoTS = "";
            switch (status)
            {
                case 0: statoTS = "confermato"; break;
                case 1: statoTS = "rifiutato"; break;
                case 2: statoTS = "in sospeso"; break;
            }

            return statoTS;
        }
    }
}
