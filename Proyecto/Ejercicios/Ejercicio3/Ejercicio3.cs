using System;

namespace Practice_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajePantalla();

            System.Console.WriteLine("Mensaje desde el Main");
        }

        static void mensajePantalla()
        {
            System.Console.WriteLine("Mensaje desde el metodo mensajePantalla");
        }
    }
}