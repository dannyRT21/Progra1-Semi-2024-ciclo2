using System;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Clasificación de edad");
                Console.WriteLine("2. Promedio de notas");
                Console.WriteLine("3. Promedio de serie de números");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ClasificacionEdad();
                        break;
                    case 2:
                        PromedioNotas();
                        break;
                    case 3:
                        PromedioSerieNumeros();
                        break;
                    case 4:
                        continuar = "n";
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta \n\n");
                        break;
                }

                Console.Write("Desea continuar? (s/n): ");
                continuar = Console.ReadLine();
            }
        }

        static void ClasificacionEdad()
        {
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("Edad incorrecta.");
            }
            else if (edad <= 2)
            {
                Console.WriteLine("Eres un bebé");
            }
            else if (edad < 12)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad < 18)
            {
                Console.WriteLine("Eres un adolescente.");
            }
            else if (edad <= 65)
            {
                Console.WriteLine("Bienvenido al mundo de las responsabilidades.");
            }
            else if (edad <= 80)
            {
                Console.WriteLine("Eres un adulto mayor");
            }
            else
            {
                Console.WriteLine("Larga vida");
            }
        }

        static void PromedioNotas()
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine());

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine()); //7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);
        }

        static void PromedioSerieNumeros()
        {
            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
            int suma = 0;
            foreach (int num in serie)
            {
                suma += num;
            }
            decimal prom = suma / serie.Length;
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);
        }
    }
}