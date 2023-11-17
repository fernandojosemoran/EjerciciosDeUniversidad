using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8MediaAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Media Aritmetica");
            // Pedimos al usuario ingresar el primer numero
            Console.WriteLine("\nIngrese el primer numero");
            int primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Pedimos al usuario ingresar el segundo numero
            Console.WriteLine("\nIngrese el segundo numero");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Pedimos al usuario ingresar el tercer numero
            Console.WriteLine("\nIngrese el tercer numero");
            int tercerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Pedimos al usuario ingresar el cuarto numero
            Console.WriteLine("\nIngrese el cuarto numero");
            int cuartoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Calculamos la media aritmetica
            double mediaAritmetica = ((primerNumero + segundoNumero) + (tercerNumero + cuartoNumero)) / 4;

            Console.ForegroundColor = cc[12];
            // Mostramos el resultado
            Console.WriteLine($"[+] La media Aritmetica es: ({mediaAritmetica})");
            Console.ReadKey();  
        }
    }
}
