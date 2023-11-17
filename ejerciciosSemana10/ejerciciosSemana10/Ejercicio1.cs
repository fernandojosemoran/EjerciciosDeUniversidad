using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosSemana10
{
    class Ejercicio1
    {
       public static void EjercicioUno()
       {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n  _________________                        *\\_/*|________              ");
            Console.WriteLine("  |  ___________  |     .-.     .-.      ||_/-\\_|______  |\\            ");
            Console.WriteLine("  | |           | |    .****. .****.     | |           | |\\            ");
            Console.WriteLine("  | |   0   0   | |    .*****.*****.     | |   0   0   | |\\            ");
            Console.WriteLine("  | |     -     | |     .*********.      | |     -     | |\\            ");
            Console.WriteLine("  | |   \\___/   | |      .*******.       | |   \\___/   | |\\          ");
            Console.WriteLine("  | |___     ___| |       .*****.        | |___________| |\\            ");
            Console.WriteLine("  |_____|\\_/|_____|        .***.         |_______________|             ");
            Console.WriteLine("    _|__|/ \\|_|_.............*.............._|________|_               ");
            Console.WriteLine("   / ********** \\                          / ********** \\             ");
            Console.WriteLine(" /  ************  \\                      /  ************  \\           ");
            Console.WriteLine("--------------------                    --------------------            \n");

            Console.ForegroundColor = ConsoleColor.Gray;
            // creamos un bucle while para pedir constantemente al usuario un numero
            while (true)
            {
                // le pedimos al usuario un numero
                Console.WriteLine("Ingrese un numero");
                double numero = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // si el numero es cero el programa termina
                if (numero == 0)
                {
                    // cancelamos el bucle
                    break;
                }

                // mostramos los datos
                Console.WriteLine($"La multiplicacion del valor ingresado es: {numero * 15}\n");
            }
       }
    }
}
