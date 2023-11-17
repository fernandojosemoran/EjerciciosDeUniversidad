using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5MultiplicarTresFactores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));

            Console.WriteLine("Multiplicar factores entre ellos");

            // pedimos al usuario el primer numero
            Console.WriteLine("\nIngrese el primer numero");
            int primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // pedimos al usuario el segundo numero
            Console.WriteLine("Ingrese el segundo numero");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // pedimos al usuario el tercer numero
            Console.WriteLine("Ingrese el tercer numero");
            int tercerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // hacemos la multiplicacion de los valores otorgados por el usuario
            double MultiplicarFactores = primerNumero * segundoNumero * tercerNumero;

            Console.ForegroundColor = cc[10];
            // Mostramos los valores de la multiplicacion
            Console.WriteLine($"\n[+] La multiplicacion de {primerNumero} x {segundoNumero} x {tercerNumero} es: ({MultiplicarFactores})");
            Console.ReadKey();  
        }
    }
}
