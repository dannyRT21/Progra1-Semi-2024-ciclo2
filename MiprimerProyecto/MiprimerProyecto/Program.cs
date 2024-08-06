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
            //Ejercicio de pedir el nombre y la edad y dar un saludo
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Nombre: ");
                String nombre = Console.ReadLine();
                
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
             
                Console.WriteLine("Hola, {0} bienvenido a Progra I, estas en la mejor epoca con apenas {1} años para aprender a programar.",
                    nombre, edad);

                Console.Write("Continuar = s; Salir = cualquier tecla");
                Console.WriteLine("Continuar = s; Salir = cualquier tecla ");
                continuar = Console.ReadLine();
            }
        }
    }
}
