using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea un programa en C# que solicite al usuario 5 números enteros y muestre en pantalla las siguientes estadísticas matemáticas:

    - La suma de los 5 números
    - La media aritmética
    - El número máximo
    - El número mínimo
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio3
    {
        static public void EjercicioTres()
        {
            Console.Title = "solicite al usuario 5 números enteros para hacer operaciones matematicas";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                ,----------------,              ,---------,            ");
            Console.WriteLine("            ,-----------------------,          ,", "       |             ");
            Console.WriteLine("          ,", "|        ,", "  |      ,             |                    ");
            Console.WriteLine("         +-----------------------+  |      ,", "           |             ");
            Console.WriteLine("         |  .-----------------.  |  |     +---------+      |             ");
            Console.WriteLine("         |  |                 |  |  |     | -==----'|      |             ");
            Console.WriteLine("         |  |  I LOVE C#!     |  |  |     |         |      |             ");
            Console.WriteLine("         |  |  Bad command or |  |  |/----|`---=    |      |             ");
            Console.WriteLine("         |  |  C:\\>_          |  |  |   ,/|==== ooo |      ;            ");
            Console.WriteLine("         |  |                 |  |  |  // |(((( [33]|    ,'              ");
            Console.WriteLine("         |  `-----------------'  |   ,'.;'| |((((   |  ,'                ");
            Console.WriteLine("         +-----------------------+  ;;  | |         |,' - Fernando Jose- ");
            Console.WriteLine("            /_)______________(_/  //'   | +---------+                    ");
            Console.WriteLine("       ___________________________/___  `,                               ");
            Console.WriteLine("      /  oooooooooooooooo  .o.  oooo /,   \\,'-----------                ");
            Console.WriteLine("     / ==ooooooooooooooo==.o.  ooo= //   ,`\\--{)B     ,'                ");
            Console.WriteLine("    /_==__==========__==_ooo__ooo=_/'   /___________,                    ");
            Console.WriteLine("    `-----------------------------'                                    \n");

            // declaramos nuestras variables
            double[] numbers = new double[5];
            double suma = 0;
            double mediaAritmetica;


            Console.ForegroundColor= ConsoleColor.Gray;
            // creamos un bucle for para pedir al usuario los valores numericos
            for (int i = 0; i != 5; i++)
            {
                // pedimos que nos de numeros
                Console.WriteLine($"\nIngrese el siguiente numero indice ({i + 1})");
                // los convertimos el texto a un valor numerico
                double numero = double.Parse(Console.ReadLine());
                // agregamos los valores ingresados por el usuario a nuestro array
                numbers[i] = numero;
                // sumamos las valos ingresados por el usuario
                suma += numero;
            }

            // hacemos los calculos de la media aritmetica
            mediaAritmetica = suma / numbers.Length;

            // agregamos algunas cabezeras para nuestros datos
            Console.WriteLine("\nSuma\tMedia Aritmetica\tNumero Maximo\tNumero Minimo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            // mostramos los valores correspondientes
            Console.WriteLine($"{suma}\t{mediaAritmetica}\t\t\t{numbers.Max()}\t\t{numbers.Min()}");

            Console.ReadKey();
        }
    }
}
