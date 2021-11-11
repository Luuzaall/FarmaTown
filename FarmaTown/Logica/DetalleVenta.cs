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
        public Estado EstadoActual { get; set; }
        public Double PrecioUnitarioShort
            
        {
            get
            {
                // redondea el precio unitario para
                // mostrar.
                return Math.Round(PrecioUnitario, 2);
            }
        }

        public int IdMedicamento
        {
            get
            {
                //Accede al ID del medicamento.
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
                //Calcula el subtotal de el detalle
                // con o sin descuento para la cantidad
                // registrada.
                if (Reintegro == 0)
                    // Si tuvo descuento...
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
