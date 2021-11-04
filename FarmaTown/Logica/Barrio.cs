﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Barrio
    {
        public int IdBarrio { get; set; }
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
        public bool Borrado { get; set; }

        BarrioDao oBarrioDao;
        public Barrio()
        {
            oBarrioDao = new BarrioDao();
        }
        public List<Barrio> recuperarCParam(string nombre)
        {
            return this.oBarrioDao.recuperarCParam(nombre);
        }
        public List<Barrio> recuperarCParamOtro(string nombre, string localidad)
        {
            return this.oBarrioDao.recuperarCParamOtro(nombre, localidad);
        }
        public List<Barrio> recuperarTodos()
        {
            return this.oBarrioDao.recuperarTodos();
        }

        public List<Barrio> recuperarSoloUsadosClientes()
        {
            return this.oBarrioDao.recuperarSoloUsadosClientes();
        }
        public Barrio traerBarrio(int idBarrio)
        {
            return this.oBarrioDao.traer(idBarrio);
        }

        public Barrio traerBarrio(string nombre)
        {
            return this.oBarrioDao.traer(nombre);
        }

        public bool crearBarrio(Barrio nuevoBarrio)
        {
            return validar(this.oBarrioDao.crear(nuevoBarrio));

        }

        public bool actualizar(Barrio oBarrio)
        {
            return validar(this.oBarrioDao.actualizar(oBarrio));

        }

        public bool cambiarEstado(Barrio oBarrio, bool seHabilita)
        {
            return validar(this.oBarrioDao.cambiarEstado(oBarrio, false));

        }

        private bool validar(int resultado)
        {
            if (resultado == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
