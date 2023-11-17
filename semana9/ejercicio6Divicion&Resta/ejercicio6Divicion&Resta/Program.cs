using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6Divicion_Resta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Obtener divicion y residuo\n");

            // Pedimos el primer numero al usuario
            Console.WriteLine("Ingrese el primer numero");
            // convertimos el texto a un numero
            int primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Pedimos el segundo numero al usuario
            Console.WriteLine("Ingrese el segundo numero");
            // convertimos el texto a un numero
            int segundoNumero = int.Parse(Console.ReadLine());  
            Console.WriteLine("\n");

            // dividimos
            double divicion = primerNumero / segundoNumero;
            // obtenemos el residuo
            double residuo = primerNumero % segundoNumero;

            Console.BackgroundColor = cc[1];
            // Aclaramos la funcion del programa
            Console.WriteLine($"\nLa divicion y residuo de {primerNumero},{segundoNumero} es:\n");
            Console.ForegroundColor = cc[12];
            Console.BackgroundColor = cc[0];
            // mostramos los valores 
            Console.WriteLine($"[+] La divicion es: ({divicion})");
            Console.WriteLine($"[+] El residuo es: ({residuo})");
            Console.ReadKey();
        }
    }
}
