using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4SumarAlCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Suma del mismo numero pero al cuadrado");

            Console.WriteLine("\nIngrese un numero");
            double numero = int.Parse(Console.ReadLine());

            Console.ForegroundColor = cc[10];
            Console.WriteLine($"\nLa suma de {numero} + {numero}^2 es: ( {numero + Math.Pow(numero,2)} )");
            Console.ReadKey();
        }
    }
}
