using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class DetalleVenta
    {
        // Propiedades

        public Medicamento Medicamento { get; set; }
        public int Cantidad { get; set; }
        public Double PrecioUnitario { get; set; }
        public Double Reintegro { get; set; }
        public Double PrecioUnitarioShort
        {
            get
            {
                return Math.Round(PrecioUnitario, 2);
            }
        }

        public int IdMedicamento
        {
            get
            {
                return Medicamento.IdMedicamento;
            }
        }
        public string Nombre
        {
            get
            {
                return Medicamento.Nombre;
            }
        }

        public Double Importe
        {
            get
            {
                if (Reintegro == 0)
                    return Math.Round( (Cantidad * PrecioUnitario), 2);
                else
                {
                    double subTotal = Cantidad * PrecioUnitario;
                    return Math.Round( (subTotal - (subTotal * Reintegro)) , 2 );
                }
            }
        }

    }
}
