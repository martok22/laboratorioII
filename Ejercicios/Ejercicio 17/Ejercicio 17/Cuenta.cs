using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_b
{
    class Cuenta
    {
        private string nombre;
        private long numeroCuenta;
        private double interes;
        private ETipoInteres tipoInteres;

        public string GetNombre()
        {
            return this.nombre;
        }
        public long NumeroCuenta()
        {
            return this.numeroCuenta;
        }
        public double Interes()
        {
            return this.interes;
        }
        public ETipoInteres TipoInteres()
        {
            return this.tipoInteres;
        }


    }
}
