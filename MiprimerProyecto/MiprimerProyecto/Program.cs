using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiprimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Nombre: ");
                String nombre = Console.ReadLine();

                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    Console.WriteLine("Hola, {0} bienvenido a Progra I, estas en la mejor epoca {1} de aprender a programar.",
                        nombre, edad);

                    Console.Write("Continuar = s; Salir = cualquier tecla");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("La edad debe ser un número.");
                    continuar = "s";
                }
            }
        }
    }
}