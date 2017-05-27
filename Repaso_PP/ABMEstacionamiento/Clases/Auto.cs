using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Auto : Vehiculo,IImprimible, IGuardable
    {
        private int _cantidadDePuertas;

        public Auto(string patente, int cantidadDePuertas, DateTime fechaIngreso)
            : base(patente,fechaIngreso)
        {
            this._cantidadDePuertas = cantidadDePuertas;
        }

        public override bool Equals(object objeto)
        {
            if (objeto is Auto) return true;
            return false;
        }

    }

    

}
