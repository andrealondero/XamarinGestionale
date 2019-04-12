using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2.ViewModels
{
    public class UsersView : BindableObject
    {

        public int Id { get; set; }
        public int Type
        {
            get
            {
                return Type;
            }
            set
            {
                if (value == Type)
                    return;
                Type = value;

                OnPropertyChanged();
            }
        }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime CR_date { get; set; }
        public DateTime MOD_date { get; set; }
        public int User { get; set; }

        string CheckUserType( int type)
        {
            var tipoUtente = "";
            switch (type)
            {
                case 0: tipoUtente = "dipendente"; break;
                case 1: tipoUtente = "supervisore"; break;
            }

            return tipoUtente;
        }
    }
}

