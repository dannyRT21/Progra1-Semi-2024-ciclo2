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
            //Ejercicio: pedir el nombre y la edad y determinar segun la edad la clasificacion en la que se encuentra el usuario.
        
            while (continuar == "s")
            {
                Console.Write("Nombre: ");
                String nombre = Console.ReadLine();

                Console.Write("Edad: ");
               
                int edad = int.Parse(Console.ReadLine()); //"5"=> 5

                Console.WriteLine("Hola, {0} bienvenido a Progra I, estas en la mejor epoca con apenas {1} años para aprender a programar.",
                    nombre, edad);
                Console.WriteLine("Continuar = s; Salir = cualquier tecla ");
                string msg = "";

                if (edad < 0 || edad > 125)
                {
                    msg = "Por favor, ingrese su edad en un rango de 0 a 125";
                }
                else if (edad <= 2)
                {
                    msg = "{0}, Eres un bebe";
                }
                else if (edad <= 11)
                {
                    msg = "{0}, Eres un niño";
                }
                else if (edad <= 17)
                {
                    msg = "{0}, Eres un adolescente";
                }
                else if (edad <= 65)
                {
                    msg = "{0},Eres un adulto";
                }
                else if (edad <= 125)
                {
                    msg = "{0}, Larga vida";
                }
                Console.WriteLine(msg, nombre);

                Console.WriteLine("Continuar = s; Salir = Cualquier tecla. ");
                continuar = Console.ReadLine();
            }
        }
    }
}