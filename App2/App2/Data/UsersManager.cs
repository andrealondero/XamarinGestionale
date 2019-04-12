using App2.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Data
{
    public class UsersManager
    {
        readonly SQLiteConnection _dbUsers;
        public ObservableCollection<Users> Users { get; set; }

        public UsersManager(string dbPath)
        {
            _dbUsers = new SQLiteConnection(dbPath);
            _dbUsers.CreateTable<Users>();

            //this.Users = new ObservableCollection<Users>(_dbUsers.Table<Users>());

            /*if (!_dbUsers.Table<Users>().Any())
            {
                AddNewUsers();
            }*/
        }

        public List<Users> GetAllU()
        {
            return _dbUsers.Table<Users>().ToList();
        }
        public int SaveUsers(Users users)
        {
            return _dbUsers.Insert(users);
        }

        /*public void AddNewUsers()
        {
            this.Users.Add(new Users
            {
                Mail = "username...",
                Password = "password...",
            });
        }*/
    }
}
