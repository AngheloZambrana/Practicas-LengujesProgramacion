using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;

            System.Console.WriteLine("Introduce la medida del radio: ");

            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = (Math.Pow(radio, 2)) * PI;

            System.Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}
