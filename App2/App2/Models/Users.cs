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
        public int Id { get; set; }

        [NotNull]
        public int Type { get; set; }

        [NotNull, Unique, MaxLength(20)]
        public string Mail { get; set; }

        [NotNull, Unique, MaxLength(20)]
        public string Password { get; set; }
        public DateTime CR_date { get; set; }
        public DateTime MOD_date { get; set; }

    }

    public class User : Users

    {
        public User(string UserName, string Password)
        {
            this.Mail = UserName;
            this.Password = Password;
        }

        public bool CheckInfo()
        {
            if (this.Mail.Equals("andrealondero") && this.Password.Equals("abab"))
                return true;
            else
                return false;
        }
    }

}
