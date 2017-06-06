using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para escribir lineas de texto

            StreamWriter fichero;

            fichero = File.CreateText("D:\\marto\\Documents\\Proyectos\\unArchivo.txt");
            fichero.WriteLine("Una linea");
            fichero.Write("Otra Linea?");
            fichero.WriteLine("Quizas otra linea mas?");
            fichero.Close();

            // Leemos una linea de texto

            StreamReader ficheroReader;

            // File.OpenText (string) Devuelve un StreamReader
            // File.OpenRead, File.Open Devuelven un FileStream

            /*ficheroReader = File.OpenText("D:\\marto\\Documents\\Proyectos\\unArchivo.txt");
            string leido;
            leido = ficheroReader.ReadLine();
            leido = ficheroReader.
            System.Console.WriteLine(leido);
            ficheroReader.Close();*/
            

            // Como leer un archivo entero hasta el fin de archivo.
            // Fin de archivo = null

            ficheroReader = File.OpenText("D:\\marto\\Documents\\Proyectos\\unArchivo.txt");
            string leido_todo;
            do
            {
                leido_todo = ficheroReader.ReadLine();
                if (leido_todo != null)
                    Console.WriteLine(leido_todo);
            }
            while (leido_todo != null);
            ficheroReader.Close();

            System.Console.Read();

            // Agregar lineas a un archivo creado -> fichero.AppendLine()
            // Comprobar que un archivo exista -> File.Exists(string nombreDeArchivo)

            // Leer un archivo binario

            BinaryReader fichero;
            string nombre = "D:\\marto\\Documents\\Proyectos\\unArchivo.txt";
            string leido_modo_binario;
			
			



        }
    }
}
