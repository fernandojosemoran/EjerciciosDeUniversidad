using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Tabla de multiplicacion");
            // Pedimos al usuario que ingrese un numero
            Console.WriteLine("\nIngrese un numero\n");
            int numeroToMultiplicar = int.Parse(Console.ReadLine());

            // hacemos un bucle para facilitar la multiplicacion del valor otorgado por el usuario
            for (int i = 0; i <= 10; i++)
            {
                Console.ForegroundColor = cc[i];
                // mostramos la tabla del valor otorgado por el usuario
                Console.WriteLine($"{numeroToMultiplicar} x {i} = {numeroToMultiplicar * i}");   
            }

            Console.ReadKey();  
        }
    }
}
