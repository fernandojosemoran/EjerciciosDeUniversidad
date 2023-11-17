using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7MostrarResultadosDeOperaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Mostrar Resultados de Operaciones\n");

            // Pedimos al usuario que ingrese un numero
            Console.WriteLine("Ingrese un numero");
            // convertimos el texto a un numero
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.ForegroundColor = cc[12];
            // Mostramos los resultados con sus respectivas operaciones
            Console.WriteLine($"[+] El resultado de -6 + {numero} * 5 es: ({-6 + numero * 5})\n");
            Console.WriteLine($"[+] El resultado de (13-2) * {numero} es: ({(13 - 2) * numero})\n");
            Console.WriteLine($"[+] El resultado de ({numero} + -2) * (20 / 10) es: {(numero + -2) * (20 / 10)}\n");
            Console.WriteLine($"[+] El resultado de (12 + {numero}) / (5 - 4) es: {(12 + numero) / (5 - 4)}");
            Console.ReadKey();
        }
    }
}
