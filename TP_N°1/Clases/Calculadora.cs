using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculadora
    {
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            if (operador == "+") retorno = num1.GetNumero() + num2.GetNumero();
            if (operador == "-") retorno = num1.GetNumero() - num2.GetNumero();
            if (operador == "*") retorno = num1.GetNumero() * num2.GetNumero();
            if (operador == "/")
                if (num2.GetNumero()==0) return 0;
                else
                    retorno = num1.GetNumero() / num2.GetNumero();
            return retorno;
        }

        public string ValidarOperador(string operadorString)
        {
            if (operadorString == "+" || operadorString == "-" || operadorString == "*" || operadorString == "/") 
                return operadorString;
            else
                return "+";
        }
    }
}
