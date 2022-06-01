using ExamenPA.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenPA.Repositories
{
    public  class MarcaRepository
    {
        SQLiteConnection connection;

        public MarcaRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Marca>();

        }

        public void Init()
        {
            connection.CreateTable<Marca>();


        }


        //private void AddFromStart(string name, string alias)
        //{
        //    Marca marca = GetByName(name);

        //    if (marca == null)
        //    {
        //        InsertOrUpdate(new Marca() { Name = name, Alias = alias });
        //    }

        //}

        public void InsertOrUpdate(Marca marca)
        {
            if (marca.Id == 0)
            {

                //connection.InsertWithChildren(actor);
                connection.Insert(marca);

            }
            else
            {

                connection.Update(marca);
                //App.ProducerDB.InsertOrUpdate(movie.Producer);

            }
        }

        public Marca GetById(int Id)
        {
            return connection.Table<Marca>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();
        }

        public Marca GetByName(string Name)
        {
            return connection.Table<Marca>().FirstOrDefault(item => item.Name == Name);
        }

        public List<Marca> GetAll()
        {

            return connection.GetAllWithChildren<Marca>().ToList();
        }

        //public TableQuery<Actor> GetAllActors(Movie movie)
        //{

        //    //return connection.GetAllWithChildren<Actor>().ToList();
        //    var ActorTable = connection.Table<Actor>().Where(m => m.Id == movie.Id);
        //    return MovieTable;

        //}



        public void DeleteItem(int Id)
        {
            Marca marca = GetById(Id);
            connection.Delete(marca);
        }
    }
}
