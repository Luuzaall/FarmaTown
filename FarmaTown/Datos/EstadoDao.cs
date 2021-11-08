using FarmaTown.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Datos
{
    class EstadoDao
    {
        public Estado traer(int idEstado)
        {
            switch (idEstado)
            {
                case 1:
                    {
                        ActivaDao oEstado = new ActivaDao();
                        return oEstado.traer();
                    }
                case 2:
                    {
                        CanceladaDao oEstado = new CanceladaDao();
                        return oEstado.traer();
                    }
            }

            return null;
        }
    }

}
