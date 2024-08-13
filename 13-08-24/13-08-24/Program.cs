using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de matrices. Calcular el sueldo de una persona.
            double[,] matriz = new double[,] {
                {0.01,   472.00,  0, 0},
                {472.01, 895.24, 10,17.67},
                {895.25, 2038.10, 20,60.00},
                {2038.11,9999999,30,288.57},
            };
            //calculos de prestaciones
            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine()),
                afp = sueldo * 6.25 / 100, // Calcula la AFP (6.25% del sueldo)
                isss = sueldo * 3 / 100; // Calcula el ISSS (3% del sueldo)

            // Resta la AFP y el ISSS del sueldo bruto
            double sueldoNeto = sueldo - afp - isss;

            // Calcula el ISR
            double isr = 0;
            for (int i = 0; i < 4; i++)
            {
                if (sueldoNeto >= matriz[i, 0] && sueldoNeto <= matriz[i, 1])
                {
                    isr = (sueldoNeto - matriz[i, 0]) * matriz[i, 2] / 100 + matriz[i, 3];
                }
            }

            // Resta el ISR del sueldo neto
            sueldoNeto -= isr;

            Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}", Math.Round(sueldoNeto, 2), Math.Round(afp, 2), isss, Math.Round(isr, 2));
            Console.ReadLine();
        }
    }
}