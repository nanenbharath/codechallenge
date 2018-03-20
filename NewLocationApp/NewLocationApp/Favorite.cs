using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NewLocationApp
{
   public class Favorite
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Temperature { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string WindSpeed { get; set; }
        public string Humidity { get; set; }
    }
}
