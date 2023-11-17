using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escriba un programa en C# que solicite al usuario dos números enteros (a, b) y muestre el rango de esos números (Incluidos los que ingreso el usuario), de tres maneras diferentes:

   - Usando la instrucción for.
   - Usando la instrucción while.
   - Usando la instrucción do while. 
*/


// tengo entendido que no es un rango de estadisticas ya que seria una formula

namespace ejerciciosSemana10
{
    internal class Ejercicio5
    {
        static public void EjercicioCinco()
        {
            Console.Title = "Mostrar rango con for,while.do while.";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n                       .--.  .--. 						");
            Console.WriteLine("                      /    \\/    \\ 					");
            Console.WriteLine("                     /   .-.  .-. |					    ");
            Console.WriteLine("                    /   |  _\\|  _\\|					");
            Console.WriteLine("              .----'    |/` ||/` ||					    ");
            Console.WriteLine("            _/    ,--    \\_0/ \\_0/|					");
            Console.WriteLine("         .-'     / `)              \\       .-'''''''--.	");
            Console.WriteLine("        /          /              .-'-----/           \\	");
            Console.WriteLine("       /          /`\\                          () ()  /	");
            Console.WriteLine("      /          |   '-.___.                          |	");
            Console.WriteLine("     ;           \\      |/ `\\                         /");
            Console.WriteLine("    /             |.---.`.-. '.___              ___.-'	");
            Console.WriteLine("  /'              |     \\   \\ \\ |/`'-.,____..-``|/	");
            Console.WriteLine("                  \\  ,   \\   \\ \\`,       |/     `	");
            Console.WriteLine("                   \\/|    \\   \\ /|       `			");
            Console.WriteLine("                    \\/     `   ;-`'.   ,				");
            Console.WriteLine(" 	                 `'-.   ,   '.  '-/|    ,			");
            Console.WriteLine("                         './|     '-. ``;--/|-.			");
            Console.WriteLine("                           '`'--.,___) /|.-''` )			");
            Console.WriteLine("                     '--._          `'`    .-'			");
            Console.WriteLine("                         .-`'-._          .'				");
            Console.WriteLine("                       .'     						   \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Ingrese el primer numero entero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el segundo numero entero");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // mostramos unos titulo de referencia
            Console.WriteLine($"Rango entre [{numero1}:{numero2}]\n");
            Console.ForegroundColor= ConsoleColor.Red;
            // mostramos el primer metodo con el bucle for
            for (int i = numero1; i <= numero2; i++)
            {
                Console.WriteLine("Usando for: " + i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n");

            // mostramos unos titulo de referencia
            Console.WriteLine($"Rango entre [{numero1}:{numero2}]\n");
            int numeroDeWhile1 = numero1;
            int numeroDeWhile2 = numero2;
            Console.ForegroundColor = ConsoleColor.Red;
            // mostramos el segundo metodo con el bucle while
            while (numeroDeWhile1 <= numeroDeWhile2)
            {
                Console.WriteLine($"Usando while: {numeroDeWhile1++}");
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n");
            // mostramos unos titulo de referencia
            Console.WriteLine($"Rango entre [{numero1}:{numero2}]\n");

            Console.ForegroundColor = ConsoleColor.Red;
            // mostramos el tercer metodo con el bucle do while
            do
            {
                Console.WriteLine($"Usando do while: {numero1++}");
            } while (numero1 <= numero2);// si numero 1 es menor o igual que el segundo
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
