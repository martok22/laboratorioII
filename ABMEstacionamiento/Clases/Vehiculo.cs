using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Vehiculo:IGuardable,IImprimible
    {
        private string _patente;
        private DateTime _fechaIngreso;

        /*public abstract DateTime fechaIngreso
        {
            get;
        }*/

        public Vehiculo(string patente, DateTime fechaIngreso)
        {
            this._patente = patente;
            this._fechaIngreso = fechaIngreso;
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if(vehiculo1.Equals(vehiculo2) && 
                vehiculo1._patente == vehiculo2._patente)
                    return true;
            return false;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        public string DevolverTicket()
        {
            return "$20";
        }

        public void Mostrar()
        {
            System.Console.WriteLine("Patente: "+this._patente,
                ", FechaIngreso: "+this._fechaIngreso);
        }
    }
}
