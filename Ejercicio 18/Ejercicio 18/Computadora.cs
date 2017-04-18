using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18_clases
{
    class Computadora
    {
        private bool estaEncendida;
        private Ejercicio_18_enum.EMarca marca;
        private Ejercicio_18_enum.EProcesador procesador;
        private float peso;

        public Computadora(bool estaEncendida, Ejercicio_18_enum.EMarca marca, Ejercicio_18_enum.EProcesador procesador, float peso)
        {
            SetEstaEncendida(estaEncendida);
            SetMarca(marca);
            Setpeso(peso);
            SetProcesador(procesador);
        }

        public void Informar()
        {
            System.Console.WriteLine("La PC es de la marca "+GetMarca()+" , posee un procesador "+GetProcesador()+" ,tiene un peso+"GetPeso());
            if(GetEstaEncendida()) System.Console.WriteLine("La pc está encendida");
            else
                System.Console.WriteLine("La pc está apagada");
        }

        public void Encender()
        {
            if (!estaEncendida) estaEncendida = true;
        }

        public void Apagar()
        {
            if (estaEncendida) estaEncendida = false;
        }

        public bool GetEstaEncendida()
        {
            return this.estaEncendida;
        }

        public Ejercicio_18_enum.EMarca GetMarca()
        {
            return this.marca;
        }

        public Ejercicio_18_enum.EProcesador GetProcesador()
        {
            return this.procesador;
        }

        public float GetPeso()
        {
            return this.peso;
        }

        public void SetEstaEncendida(bool estaEncendida)
        {
            this.estaEncendida = estaEncendida;
        }

        public void SetMarca(Ejercicio_18_enum.EMarca marca)
        {
            this.marca = marca;
        }

        public void SetProcesador(Ejercicio_18_enum.EProcesador procesador)
        {
            this.marca = procesador;
        }

        public void Setpeso(float peso)
        {
            this.peso = peso;
        }


    }
}
