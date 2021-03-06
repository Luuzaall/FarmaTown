using FarmaTown.Datos;
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
        public int CantidadStock { get; set; }
        public bool Borrado { get; set; }
        public List<List<String>> ListaDescuentosOS { get; set; }

        MedicamentoDao oMedicamentoDao;


        public Medicamento()
        {
            oMedicamentoDao = new MedicamentoDao();
        }
        public List<Medicamento> recuperarTodos()
        {
            /*
             * Recupera sin parámetros.
             */
            return oMedicamentoDao.recuperarTodos();
        }

        public Medicamento traerMedicamento(string medicamento)
        {
            /*
             * Recupera un medicamento con su nombre.
             */
            Medicamento oMedicamento = oMedicamentoDao.obtenerMedicamentoPorNom(medicamento);
            if (oMedicamento != null)
            {
                return oMedicamento;
            }
            return null;
        }

        internal bool crearMedicamento(Medicamento oMedicamento)
        {
            /*
             * Persiste un nuevo medicamento,
             *  recibido por parámetro
             *  
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo persistirlo.
             */
            return validar(this.oMedicamentoDao.insertar(oMedicamento));
        }

        internal bool actualizarMedicamento(Medicamento oMedicamento)
        {
            /*
             * Cambia los datos del medicamento recibido
             * por los nuevos.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo cambiar los datos.
             */
            return this.oMedicamentoDao.actualizar(oMedicamento);
        }

        internal bool cambiarEstadoMedicamento(Medicamento oMedicamento)
        {
            /*
             * Deshabilita el medicamento recibido.
             * 
             *  Devuelve:
             *  -TRUE: Si lo consiguió.
             *  -FALSE: Si no pudo deshabilitarlo.
             */
            return this.oMedicamentoDao.cambiarEstado(oMedicamento);
        }

        internal List<Medicamento> recurperarMedicamentoCParametros(string nom, int idTipo)
        {
            /*
             * Recupera todos los medicamentos con parámetros.
             */
            return this.oMedicamentoDao.consultarMedicamentoCParam(nom, idTipo);
        }

        public Object obtenerDatosReporte(int cantidadMinima, int cantidadMaxima, string idTipoMed)
        {
            /*
             * Recupera todos los medicamentos
             * según los parámetros
             * y los devuelve en DataTable para
             * el ReportViewer.
             */
            return this.oMedicamentoDao.obtenerDatosReporte(cantidadMinima, cantidadMaxima, idTipoMed);
        }
        private bool validar(int resultado)
        {
            /*
             * Determina si se pudo 
             * llevar a cabo la tarea, o no.
             */
            if (resultado == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
