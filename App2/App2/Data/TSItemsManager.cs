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
    public class TSItemsManager
    {
        private SQLiteConnection dbConnect;
        private string TSItemsTable = "TSItems";
        private static object collisionLock = new object();
        public ObservableCollection<TSItems> TSItems { get; set; }

        public TSItemsManager()
        {
            dbConnect = DependencyService.Get<CustomSQLite>().GetConnection();
            dbConnect.CreateTable<TSItems>();

            this.TSItems = new ObservableCollection<TSItems>(dbConnect.Table<TSItems>());

            if (!dbConnect.Table<TSItems>().Any())
            {
                AddNewTSItems();
            } 
        }

        public void AddNewTSItems()
        {
            this.TSItems.
                Add(new TSItems
                {
                    Hours = 0,
                    Description = "Activities...",
                });
        }

        public List<TSItems> GetAllTS()
        {
            return dbConnect.Query<TSItems>("Select * From [" + TSItemsTable + "] Order by Date ASC");
        }
        public IEnumerable<TSItems> GetFilteredTS(int status)
        {
            lock (collisionLock)
            {
                var query = from tsI in dbConnect.Table<TSItems>()
                            where tsI.Status == status
                            select tsI;
                return query.AsEnumerable();
            }
        }
        public IEnumerable<TSItems> GetFilteredTS()
        {
            lock (collisionLock)
            {
                return dbConnect.
                    Query<TSItems>
                    ("SELECT * FROM Item WHERE Status = 'Confermato'").AsEnumerable();
            }
        }

        public TSItems GetTS(int i)
        {
            lock (collisionLock)
            {
                return dbConnect.Table<TSItems>().
                    FirstOrDefault(tsitem => tsitem.Status == i);
            }
        }
        public int SaveTS(TSItems ts)
        {
            return dbConnect.Insert(ts);
        }
        public int DeleteTS(TSItems ts)
        {
            return dbConnect.Delete(ts);
        }
        public int EditTS(TSItems ts)
        {
            return dbConnect.Update(ts);
        }
    }
}

