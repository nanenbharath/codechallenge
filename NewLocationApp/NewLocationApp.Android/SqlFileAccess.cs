using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NewLocationApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqlFileAccess))]
namespace NewLocationApp.Droid
{
    public class SqlFileAccess : ISQLite
    {
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var filename = "Location.db3";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }
}