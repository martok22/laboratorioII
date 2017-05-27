using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploParcial
{
    public abstract class Vehiculo
    {
        private string _patente;

        public Vehiculo(string patente)
        {
            this._patente = patente;
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return (vehiculo1._patente == vehiculo2._patente);
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

    }
}
