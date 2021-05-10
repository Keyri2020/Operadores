using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string sexo;
            string respuesta;

            do
            {

                Console.WriteLine("¿Cuál es su nombre?");
                nombre = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("¿Qué edad tienes?");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("¿Eres Masculino o Femenino? si es masculino escriba M y si es femenino, F");
                sexo = Console.ReadLine();

                if (sexo == "M" || sexo == "m")
                {
                    Console.WriteLine("");
                    System.Console.WriteLine("El Sr. " + nombre + " ha sido registrado.");
                }
                else
                {
                    Console.WriteLine("");
                    System.Console.WriteLine("La Sra. " + nombre + " ha sido registrada.");
                }

                Console.WriteLine("\n");
                Console.WriteLine("¿Desea ingresar nuevos datos?");
                respuesta = Console.ReadLine();

            } while (respuesta == "si" || respuesta == "Si");

                Console.WriteLine("Programa finalizado");
                Console.ReadKey();
        }
    }
}