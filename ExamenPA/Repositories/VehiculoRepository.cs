using ExamenPA.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExamenPA.Repositories
{
    public class VehiculoRepository
    {
        SQLiteConnection connection;

        public VehiculoRepository()
        {
            connection = new SQLiteConnection(Constants.Constants.DatabasePath, Constants.Constants.Flags);
            connection.CreateTable<Vehiculo>();
        }


        public void Init()
        {
            connection.CreateTable<Vehiculo>();
        }
        public void InsertOrUpdate(Vehiculo vehiculo)
        {
            if (vehiculo.Id == 0)
            {
                Debug.WriteLine($"Id before register {vehiculo.Id}");
                connection.Insert(vehiculo);
                Debug.WriteLine($"Id after register {vehiculo.Id}");
            }
            else
            {
                Debug.WriteLine($"Id before updating {vehiculo.Id}");
                connection.Update(vehiculo);
                Debug.WriteLine($"Id after updating {vehiculo.Id}");
            }
        }

        public Vehiculo GetByName(string Modelo)
        {
            return connection.Table<Vehiculo>().FirstOrDefault(item => item.Modelo == Modelo);
        }
        public Vehiculo GetById(int Id)
        {
            return connection.Table<Vehiculo>().FirstOrDefault(item => item.Id == Id);
            //return connection.GetAllWithChildren<Contacto>(item => item.Id == Id).FirstOrDefault();
        }

        public List<Vehiculo> GetAll()
        {

            return connection.GetAllWithChildren<Vehiculo>().ToList();
        }


        public void DeleteItem(int Id)
        {
            Vehiculo vehiculo = GetById(Id);
            connection.Delete(vehiculo);
        }
    }
}
