using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App2.Data;
using Foundation;
using SQLite;
using UIKit;

namespace App2.iOS.Connections
{
    public class CustomSQLiteIOS : CustomSQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "GestionaleXamarinDB.db";
            string personalFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "GestionaleXamarinDB.db", "Library");
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }
    }
}