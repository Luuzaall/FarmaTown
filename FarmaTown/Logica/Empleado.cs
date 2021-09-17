﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica

{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int NroDoc { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public Farmacia Farmacia { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }
        public Rol Rol { get; set; }

        EmpleadoDao oEmpleadoDao;

        public Empleado()
        {
            oEmpleadoDao = new EmpleadoDao();
        }
        public DataTable recuperarTodos()
        {
            return oEmpleadoDao.recuperarTodos();
        }

    }
}
