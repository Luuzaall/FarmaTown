﻿using FarmaTown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTown.Logica
{
    public class Sesion
    {
        public int IdSesion { get; set; }
        public Usuario IdUsuario { get; set; }
        public bool Borrado { get; set; }

    }
}