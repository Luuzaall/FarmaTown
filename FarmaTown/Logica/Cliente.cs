﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int NroDoc { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public Barrio Barrio { get; set; }
        public bool Borrado { get; set; }

        ClienteDao oCliente;

        public Cliente()
        {
            oCliente = new ClienteDao();
        }

        public List<Cliente> recuperarTodos(bool esCBorrados)
        {
            return this.oCliente.recuperarTodos(esCBorrados);
        }

        public List<Cliente> recuperarConParam(string nom, string apellido, string nroDoc, int idTipoDoc, string calle, int numCalle, int idCliente)
        {
            return oCliente.recuperarConParam(nom, apellido, nroDoc, idTipoDoc, calle, numCalle, idCliente);
        }
    }
}
