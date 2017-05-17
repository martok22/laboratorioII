using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Estacionamiento:IGuardable,IImprimible
    {
        private string _nombre;
        private List<IGuardable> _listado;

        public List<IGuardable> Listado
        {
            get { return _listado; }
        }

        public Estacionamiento()
        {
            this._listado = new List<IGuardable>();
        }

        public Estacionamiento(string nombre)
            : this()
        {
            this._nombre = nombre;
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, IGuardable vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                return estacionamiento;
            }

            estacionamiento._listado.Add(vehiculo);

            return estacionamiento;
        }

       
        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento._listado.RemoveAt(Estacionamiento.retornarIndice(estacionamiento, vehiculo));

            }

            return estacionamiento;
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculoRecorrido in estacionamiento._listado)
            {
                if (vehiculoRecorrido == vehiculo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static implicit operator Estacionamiento(string nombre)
        {
            return new Estacionamiento(nombre);
        }

        public static int retornarIndice(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            int indice = -1;
            int contador = 0;

            foreach (Vehiculo item in estacionamiento._listado)
            {
                if (item == vehiculo)
                {
                    indice = contador;
                    break;
                }
                contador++;
            }

            return indice;
        }


        string IImprimible.DevolverTicket()
        {
            return "$20";
        }

        void IImprimible.Mostrar()
        {
            foreach (IImprimible item in this.Listado)
            {
                item.Mostrar();
            }
        }
    }
}
