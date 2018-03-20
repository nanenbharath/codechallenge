using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewLocationApp
{
   public class FavouriteDB
    {
            private SQLiteConnection _sqlconnection;

            public FavouriteDB()
            {

                //Getting conection and Creating table
                _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
                _sqlconnection.CreateTable<Favorite>();
            }

            //Get all students
            //public IEnumerable<Favorite> GetStudents()
            //{
            //    return (from t in _sqlconnection.Table<Favorite>() select t).ToList();
            //}

            //Get specific student
            //public Favorite GetStudent(int id)
            //{
            //    return _sqlconnection.Table<Favorite>().FirstOrDefault(t => t.Id == id);
            //}

            //Delete specific student
            public void DeleteStudent(int id)
            {
                _sqlconnection.Delete<Favorite>(id);
            }

            //Add new student to DB
            public void AddStusent(Favorite favorite)
            {
                _sqlconnection.Insert(favorite);
            }
        }
    }

