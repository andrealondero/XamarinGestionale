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
        readonly SQLiteConnection _dbTSItems;
        //public ObservableCollection<TSItems> TSItems { get; set; }

        public TSItemsManager(string dbPath)
        {
            _dbTSItems = new SQLiteConnection(dbPath);
            _dbTSItems.CreateTable<TSItems>();
        }

        public List<TSItems> GetTSItems()
        {
            return _dbTSItems.Table<TSItems>().ToList();
        }

        public int AddTimeSheet(TSItems ts)
        {
            return _dbTSItems.Insert(ts);
        } 

            /*this.TSItems = new ObservableCollection<TSItems>(_dbTSItems.Table<TSItems>());

            if (!_dbTSItems.Table<TSItems>().Any())
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
            return _dbTSItems.Query<TSItems>("Select * From [" + TSItemsTable + "] Order by Date ASC");
        }
        public IEnumerable<TSItems> GetFilteredTS(int status)
        {
            lock (collisionLock)
            {
                var query = from tsI in _dbTSItems.Table<TSItems>()
                            where tsI.Status == status
                            select tsI;
                return query.AsEnumerable();
            }
        }
        public IEnumerable<TSItems> GetFilteredTS()
        {
            lock (collisionLock)
            {
                return _dbTSItems.
                    Query<TSItems>
                    ("SELECT * FROM Item WHERE Status = 'Confermato'").AsEnumerable();
            }
        }

        public TSItems GetTS(int i)
        {
            lock (collisionLock)
            {
                return _dbTSItems.Table<TSItems>().
                    FirstOrDefault(tsitem => tsitem.Status == i);
            }
        }
        public int SaveTS(TSItems ts)
        {
            return _dbTSItems.Insert(ts);
        }
        public int DeleteTS(TSItems ts)
        {
            return _dbTSItems.Delete(ts);
        }
        public int EditTS(TSItems ts)
        {
            return _dbTSItems.Update(ts);
        }*/
    }
}

