using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App2.Data;
using SQLite;

namespace App2.Droid.Connections
{
    public class CustomSQLiteAndroid : CustomSQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "GestionaleXamarinDB.db";
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}