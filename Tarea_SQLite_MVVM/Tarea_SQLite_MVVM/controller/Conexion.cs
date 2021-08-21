using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tarea_SQLite_MVVM.controller
{
    public class Conexion
    {

        private string pthdb;

        public Conexion() { }

        public string Conectar()
        {
            string dbname = "db.sqlite";
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            pthdb = Path.Combine(path, dbname);
            return pthdb;

        }

        public SQLiteConnection Conn()
        {
            SQLiteConnection conn = new SQLiteConnection(App.UBICACIONDB);
            return conn;
        }


        public SQLiteAsyncConnection GetConnectionAsync()
        {
            return new SQLiteAsyncConnection(App.UBICACIONDB);
        }

    }
}
