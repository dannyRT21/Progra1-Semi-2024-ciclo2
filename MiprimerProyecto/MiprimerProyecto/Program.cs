using System;

class Program
{
    static void Main()
    {
        string continuar = "s";

        while (continuar.ToLower() == "s")
        {
            Console.Clear();

            Console.Write("Número de día (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Día inválido");
                    break;
            }

            Console.Write("¿Desea continuar? (s/n): ");
            continuar = Console.ReadLine();
        }
    }
}