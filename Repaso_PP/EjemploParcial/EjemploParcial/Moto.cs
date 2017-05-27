using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploParcial
{
    public class Moto : Vehiculo
    {
        private int _cilindrada;

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this._cilindrada = cilindrada;
        }
    }
}
