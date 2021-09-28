﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Farmacia
    {
        public int IdFarmacia { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Barrio Barrio { get; set; }
        public bool Borrado { get; set; }

        FarmaciaDao oFarmaciaDao;
        public Farmacia()
        {
            oFarmaciaDao = new FarmaciaDao();
        }

        public DataTable recuperarTodos()
        {
            return oFarmaciaDao.recuperarTodos();
        }

        public DataTable recuperarCParam(string nombre, string calle, string num, string barrio, string localidad)
        {
            return this.oFarmaciaDao.recuperarCParam(nombre, calle, num, barrio, localidad);
        }

        public Farmacia traerFarmacia(int id)
        {
            return oFarmaciaDao.traerFarmacia(id);
        }
    }
}
