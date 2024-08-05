using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiprimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de suma de dos numeros iontroducidos por el usuario.
            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            //Ejercicio de pedir el nombre y la edad y dar un saludo
            Console.Write("Nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            int res = num1 + num2;

            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, res);
            Console.WriteLine("Hola, {0} bienvenido a Progra I, estas en la mejor epoca {1} de aprender a programar.",
                nombre, edad);

            Console.ReadLine();
        }
    }
}
