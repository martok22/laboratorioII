using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double num)
        {
            this.numero = num;
        }

        public Numero(string num)
        {
            ValidarNumero(num);
        }

        private double ValidarNumero(string numString)
        {
            double retorno;
            double.TryParse(numString, out retorno);
            return retorno;
        }

        private void SetNumero(double num)
        {
            this.numero = num;
        }

        public double GetNumero()
        {
            return this.numero;
        }
    }
}
