﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardaExcepcion : Exception
    {
        public NoGuardaExcepcion() : base() { }
        public NoGuardaExcepcion(string mensaje, Exception e) : base(mensaje, e) { }

    }
}