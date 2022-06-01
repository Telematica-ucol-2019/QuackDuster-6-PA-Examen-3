using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExamenPA.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }

        [ForeignKey (typeof(Marca))]
        public int FKMarcaId { get; set; }
    }
}
