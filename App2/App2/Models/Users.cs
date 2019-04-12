using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    [Table("UsersTable")]
    public class Users
    {
        [PrimaryKey, AutoIncrement, NotNull, Unique]
        public int Id { get; set;}

        [NotNull]
        public int Type { get; set;}

        [NotNull, Unique, MaxLength(20)]
        public string Mail { get; set;}

        [NotNull, Unique, MaxLength(20)]
        public string Password { get; set;}
        public DateTime CR_date { get; set; }
        public DateTime MOD_date { get; set; }

        /*public Users() { }
        public Users(int dipendente, string andrealondero, string aaaa)
        {
            this.Type = dipendente;
            this.Mail = andrealondero;
            this.Password = aaaa;
        }

        public bool CheckInfo()
        {
            if (this.Mail.Equals("andrealondero") && this.Password.Equals("wwww"))
                return true;
            else
                return false;
        }*/
    }
}
