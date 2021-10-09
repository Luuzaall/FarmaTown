﻿using FarmaTown.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public TipoMedicamento TipoMedicamento { get; set; }
        public float PrecioLista { get; set; }
        public int Cantidad { get; set; }
        public bool Borrado { get; set; }
        public List<List<String>> ListaDescuentosOS { get; set; }

        MedicamentoDao oMedicamentoDao;

        public Medicamento()
        {
            oMedicamentoDao = new MedicamentoDao();
        }
        public List<Medicamento> recuperarTodos()
        {
            return oMedicamentoDao.recuperarTodos();
        }


        internal Medicamento traerMedicamento(string medicamento)
        {
            Medicamento oMedicamento = oMedicamentoDao.obtenerMedicamentoPorNom(medicamento);
            if (oMedicamento != null)
            {
                return oMedicamento;
            }
            return null;
        }

        internal bool crearMedicamento(Medicamento oMedicamento)
        {
            return this.oMedicamentoDao.insertar(oMedicamento);
        }


        internal bool actualizarMedicamento(Medicamento oMedicamento)
        {
            return this.oMedicamentoDao.actualizar(oMedicamento);
        }

        internal bool cambiarEstadoMedicamento(Medicamento oMedicamento, bool habilitado)
        {
            return this.oMedicamentoDao.cambiarEstado(oMedicamento, habilitado);
        }

        internal List<Medicamento> recurperarMedicamentoCParametros(string nom, int idTipo, bool conBorrados)
        { 
            return this.oMedicamentoDao.consultarMedicamentoCParam(nom, idTipo, conBorrados);
        }
    }
}
