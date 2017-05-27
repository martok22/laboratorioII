using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Moto : Vehiculo,IGuardable
    {
        private int _cilindrada;

        public Moto(string patente, int cilindrada, DateTime fechaIngreso)
            : base(patente,fechaIngreso)
        {
            this._cilindrada = cilindrada;
        }

        public override bool Equals(object obj)
        {
            if (obj is Moto) return true;
            return false;
        }
    }
}
