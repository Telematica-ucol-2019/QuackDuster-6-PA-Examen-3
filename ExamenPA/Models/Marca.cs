using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExamenPA.Models
{
    [Table("Marcas")]
    public class Marca
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public ObservableCollection<Vehiculo> Vehiculos { get; set; }
    }
}
