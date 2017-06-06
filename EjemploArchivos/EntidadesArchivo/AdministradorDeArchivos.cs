using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesArchivo
{
    public class AdministradorDeArchivos
    {
        // Una forma de escribir PATHS. Hay que 'escapar' los \
        private const string RUTA_ARCHIVO = "D:\\Gonzalez\\datos.txt";

        public static void Saludar()
        {
            try
            {
                // Otra forma de escribir PATHS. Añadir @ antes de todo el PATH.
                // using hace que no necesitemos utilizar el método Dispose() 
                // para el StreamWriter/Reader
                using (StreamWriter escritor = new StreamWriter(@"D:\Gonzalez\datos.txt"))
                {
                    
                    escritor.WriteLine("Esta es una linea");
                    escritor.WriteLine("Otra mas");
                    escritor.WriteLine("Tercera");
                    escritor.WriteLine("---");
                    escritor.Write(DateTime.Now);
                }

                using (StreamReader lector = new StreamReader(RUTA_ARCHIVO))
                {
                    string linea;

                    while ((linea = lector.ReadLine()) != null)
                    {
                        System.Console.WriteLine(linea);
                    }
                    System.Console.WriteLine("---");
                    System.Console.WriteLine("Datos leidos de archivo.");
                }
            }
            catch (Exception excp)
            {
                throw new Exception(excp.Message);
            }
            finally
            {
                System.Console.WriteLine("---");
                System.Console.WriteLine("El archivo se escribió con éxito.");
                System.Console.Read();
            }
        }
    }
}
