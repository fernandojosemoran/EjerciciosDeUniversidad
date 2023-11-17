using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9MostrarValoresDeUnaFuncion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Funcion y = x^2 - 2x + 1");

            // Indicamos al usaurio que indique el valor minimo de x
            Console.WriteLine("\nIngrese el valor mínimo de x");
            int xMin = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Indicamos al usuario que ingrese el valor maximo de x
            Console.WriteLine("Ingrese el valor máximo de x");
            int xMax = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // Mostramos los valores ingresados por el usuario
            Console.WriteLine($"Valores de la función para x [{xMin}, {xMax}]\n");
            // Colocamos dos cabezeras para que tenga mas sentido los valores
            Console.WriteLine("x\t y");
            // hacemos un bucle for para hacer los calculos correspondientes
            // inicializamos la variable iteradora con el valor minimo de x que le pedimos al usuario, la cual va ir en decremento si la condicion 
            // de valor minimo es menor o igual al valor maximo.
            for (int x = xMin; x <= xMax; x++)
            {
                Console.ForegroundColor = cc[12];
                // hacemos nuestros calculos
                int y = (x * x) - (2 * x) + 1;
                // ahora mostramos los resultados
                Console.WriteLine(x + "\t" + y);
            }
            Console.ReadKey();
        }
    }
}
