using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_SQLite_MVVM.Model
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string apellido { get; set; }
        public double edad { get; set; }
        [MaxLength(100)]
        public string direccion { get; set; }
        [MaxLength(100)]
        public string puesto { get; set; }


    }
}
