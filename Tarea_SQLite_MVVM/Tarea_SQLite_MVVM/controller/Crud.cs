using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tarea_SQLite_MVVM.Model;

namespace Tarea_SQLite_MVVM.controller
{
    public class Crud
    {

        Conexion conn = new Conexion();


        public Task<List<Personas>> getReadPersonas()
        {
            return conn.GetConnectionAsync().Table<Personas>().ToListAsync();
        }

        public Task<Personas> getId(int id)
        {
            return conn
                .GetConnectionAsync()
                .Table<Personas>()
                .Where(item => item.id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> getUpdateId(Personas personas)
        {
            return conn
                .GetConnectionAsync()
                .UpdateAsync(personas);

        }

        public Task<int> Delete(Personas personas)
        {
            return conn
                .GetConnectionAsync()
                .DeleteAsync(personas);
        }


    }
}
