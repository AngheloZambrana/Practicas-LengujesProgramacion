using System;

namespace Practice_metodos2
{
    class Program
    {
        static void Main(string[] args)
        {
            sumaNumeros(7, 9);
        }

        static void sumaNumeros(int num1, int num2)
        {
            System.Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
        }
    }
}