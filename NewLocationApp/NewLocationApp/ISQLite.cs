using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewLocationApp
{
  public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
