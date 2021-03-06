using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EntidadesArchivo;
using Entidades;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ConsolaArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Saludar();
            //AdministradorDeArchivos.Saludar();
            Persona p1 = new Persona("Natalia", "Natalia");
            Persona p2 = new Persona("Jorge", "Jorge");
            Persona p3 = new Persona("Maria", "Maria");
            try
            {
                Program.SerializarPersonaXML(p1);
                System.Console.WriteLine(p2._nombre);
                p2=Program.DeserializarPersonaXML(p2);
                Program.SerializarPersonaBinaria(p3);
                Program.DeserializarPersonaBinaria(p3);
            }
            catch (Exception excp)
            {
                throw new Exception(excp.Message);
            }
            finally
            {
                System.Console.WriteLine("Nombre p2: {0}", p2._nombre);
                System.Console.WriteLine("Apellido p2: {0}", p2._apellido);
                System.Console.WriteLine("Nombre p3: {0}", p3._nombre);
                System.Console.Read();
            }

        }

        public static void Saludar()
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter("datosProgram.txt"))
                {
                    escritor.Write("Hola");
                }
            }
            catch (Exception excp)
            {
                throw new Exception(excp.Message);
            }
        }

        public static void SerializarPersonaXML(Persona p)
        {
            XmlSerializer Serializador = new XmlSerializer(typeof(Persona));
            StreamWriter escritor = new StreamWriter("Persona.xml");
            Serializador.Serialize(escritor, p);
            escritor.Close();
        }

        public static Persona DeserializarPersonaXML(Persona p)
        {
            XmlSerializer Serializador = new XmlSerializer(typeof(Persona));
            StreamReader reader = new StreamReader("Persona.xml");
            p = (Persona)Serializador.Deserialize(reader);
            reader.Close();
            return p;
        }

        public static void SerializarPersonaBinaria(Persona p)
        {
            //Persona persona = new Persona();
            IFormatter formateador = new BinaryFormatter();
            using (Stream archivo = new FileStream("Persona.bin", FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                formateador.Serialize(archivo, p);
            }
        }

        public static void DeserializarPersonaBinaria(Persona p)
        {
            IFormatter formateador = new BinaryFormatter();
            using (Stream archivo = new FileStream("Persona.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                //Persona aux;
                p = (Persona)formateador.Deserialize(archivo);
            }
            //return p;
        }
    }
}
