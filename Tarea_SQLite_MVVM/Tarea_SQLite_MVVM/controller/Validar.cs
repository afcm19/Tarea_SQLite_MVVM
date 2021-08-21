using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_SQLite_MVVM.controller
{
    public class Validar
    {
        bool validacion;
        public bool validarPersona(string name, string apellido, int edad, string direccion)
        {

            validacion = (name == null || apellido == null || edad.Equals("") || direccion == null) ? false : true;

            return validacion;
        }

    }
}
