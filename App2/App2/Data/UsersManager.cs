using App2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App2.Data
{
    public class UsersManager
    {
        SQLiteConnection dbConnect;
        private string UsersTableName = "UsersTable";
        public ObservableCollection<Users> Users { get; set; }

        public UsersManager()
        {
            dbConnect = DependencyService.Get<CustomSQLite>().GetConnection();
            dbConnect.CreateTable<Users>();

            this.Users = new ObservableCollection<Users>(dbConnect.Table<Users>());

            if (!dbConnect.Table<Users>().Any())
            {
                AddNewUsers();
            }
        }

        public void AddNewUsers()
        {
            this.Users.Add(new Users
            {
                Mail = "andrealondero",
                Password = "wwww",
            });
        }

        /*public List<Users> GetAllU()
        {
            return dbConnect.Query<Users>("Select * From [" + UsersTable + "] Order by Id ASC");
        }
        public int SaveTS(Users u)
        {
            return dbConnect.Insert(u);
        }
        public int DeleteTS(Users u)
        {
            return dbConnect.Delete(u);
        }
        public int EditTS(Users u)
        {
            return dbConnect.Update(u);
        }*/
    }
}
