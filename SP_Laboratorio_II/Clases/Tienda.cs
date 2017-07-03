using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IArchivo;
using Excepciones;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clases
{
    [Serializable]
    public delegate void delegadoArchivoGuardar(string archivo, Tienda tienda);
    public delegate void delegadoArchivoLeer(string archivo, out Tienda tienda);

    public class Tienda : Local, Binario<Tienda>
    {
        public event delegadoArchivoGuardar eventoArchivoGuardar;
        public event delegadoArchivoLeer eventoArchivoLeer;

        private string legajo;
        protected override string Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        public Tienda(string legajo, int ancho, string direccion) : base(direccion,ancho)
        {
            this.legajo = legajo;
            this.eventoArchivoGuardar += new delegadoArchivoGuardar(this.Guardar);
            this.eventoArchivoLeer += new delegadoArchivoLeer(this.Leer);
        }

        public void Leer(string path, out Tienda datos)
        {
            
            IFormatter formateador = new BinaryFormatter();
            FileStream lector = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            datos = (Tienda)formateador.Deserialize(lector);
            lector.Close();
            //return true;
        }

        public void Guardar(string path, Tienda datos)
        {
            IFormatter formateador = new BinaryFormatter();
            FileStream escritor = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write);
            formateador.Serialize(escritor, datos);
            escritor.Close();
            //return true;
           

        }

        public string MostrarDatos()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine(base.ToString());
            bloque.AppendLine("Legajo: " + this.Legajo);
            return bloque.ToString();
            this.eventoArchivoGuardar("Archivo.bin", this);
        }
    }
}
