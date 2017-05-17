using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploParcial
{
    public class Auto : Vehiculo
    {
        private int _cantidadDePuertas;

        public Auto(string patente, int cantidadDePuertas) : base(patente)
        {
            this._cantidadDePuertas = cantidadDePuertas;
        }
    }
}
