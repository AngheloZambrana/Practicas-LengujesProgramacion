using System;

namespace Practice_metodos3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(sumaNumeros(10, 7));
            System.Console.WriteLine(dividirNmeros(18, 7)); 
            System.Console.WriteLine(multiplicarNumeros(7, 10));

        }

        static int sumaNumeros(int num1, int num2)=> num1 + num2; //solo cuando tiene una instruccion podemos hacer esto
        static double dividirNmeros(double num1, int num2)
        {
            return num1 / num2;
        }

        static int multiplicarNumeros(int num1, int num2)
        {
            int resultado;

            resultado = num1 * num2;

            return resultado;
        }
    }
}