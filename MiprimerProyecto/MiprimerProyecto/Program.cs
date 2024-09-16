using System;


    internal class Conversores
{

  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Impuesto a las Actividades Económicas");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Ingrese el monto de la actividad económica:");
            double monto = double.Parse(Console.ReadLine());

            double impuesto = CalcularImpuesto(monto);

            Console.WriteLine($"El impuesto a pagar es: ${impuesto:F2}");

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static double CalcularImpuesto(double monto)
        {
            double[] rangos = { 0.01, 500.01, 1000.01, 2000.01, 3000.01, 6000, 8000, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01, 400000.01, 500000.01, 10000000.1 };
            double[] precios = { 1.5, 1.5, 3, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255, 300, 340, 490 };
            double[] adicionales = { 0, 3, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45, 0.4, 0.30, 0.18 };

            int i = 0;
            while (monto > rangos[i])
            {
                i++;
            }

            double exceso = monto - rangos[i - 1];
            double impuesto = (exceso / 1000) * adicionales[i - 1] + precios[i - 1];

            return impuesto;
        }
    }
}