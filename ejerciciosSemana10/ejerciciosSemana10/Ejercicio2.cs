using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escriba un programa en C# que solicite un número (a) y una cantidad (b). Muestre ese número (a) las veces del valor de (b).

namespace ejerciciosSemana10
{
    internal class Ejercicio2
    {
        static public void EjercicioDos()
        {
            Console.Title = "Solicite un número (a) y una cantidad (b). Muestre ese número (a) las veces del valor de (b).";
            ConsoleColor[] cc = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            Console.ForegroundColor = cc[10];
            Console.WriteLine("\n  _______  _______  _______  _______ ");
            Console.WriteLine(" |       ||       ||       ||       |");
            Console.WriteLine(" |   _ _ ||   _   ||   _   ||    ___|");
            Console.WriteLine(" |  |     |  | |  ||  | |  ||   |___ ");
            Console.WriteLine(" |  |_ _  |  |_|  ||  |_|  ||    ___|");
            Console.WriteLine(" |       ||       ||       ||   |___ ");
            Console.WriteLine(" |_______||_______||_______||_______|\n");

            Console.ForegroundColor= ConsoleColor.Gray;
            // pedimos al usuario que ingrese un numero
            Console.WriteLine("Ingrese un primer numero");
            double numeroA = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // pedimos al usuario que ingrese cuantas veces quiere que se repita
            Console.WriteLine("\nCuantas veces quieres que se repita el numero {0}", numeroA);
            double numeroB = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Repeticiones\t\tNumero");
            // usamos un bucle for para imprimir el numero de veces que se repitira el numero
            for (double i = 1; i != numeroB + 1; i++)
            {
                Console.ForegroundColor = cc[12];
                // mostramos el resultado final
                Console.WriteLine("Se repitio: {0}\t\t[ {1} ]",i,numeroA);
            }

            Console.ReadKey();
        }
    }
}
