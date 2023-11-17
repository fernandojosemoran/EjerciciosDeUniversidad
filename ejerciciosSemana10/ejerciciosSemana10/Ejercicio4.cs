using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
Cree un programa en C# que calcule la nota de un alumno a partir de un número entero. Solicite al usuario un número (x) entre 0 y 10, y responda lo siguiente:
    <10 - Matrícula de honor
    <=9 - Sobresaliente
    <=6 - Bien
    <=5 - Reprobado
Use la instrucción switch, break y default de C#.
 
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio4
    {
        static public void EjercicioCuatro()
        {
            Console.Title = "Programa para calcular nota";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n    \\            _    _            _    					        ");
            Console.WriteLine("     \\          | |  | |          | |   					        ");
            Console.WriteLine("      \\\\        | |__| | __ _  ___| | __					        ");
            Console.WriteLine("       \\\\       |  __  |/ _` |/ __| |/ /					        ");
            Console.WriteLine("        >\\/7    | |  | | (_| | (__|   < 					        ");
            Console.WriteLine("    _.-(6'  \\   |_|  |_|\\__,_|\\___|_|\\_\\					    ");
            Console.WriteLine("   (=___._/` \\         _   _          					            ");
            Console.WriteLine("        )  \\ |        | | | |         					            ");
            Console.WriteLine("       /   / |        | |_| |__   ___ 					            ");
            Console.WriteLine("      /    > /        | __| '_ \\ / _ \\					            ");
            Console.WriteLine("     j    < _\\        | |_| | | |  __/					            ");
            Console.WriteLine(" _.-' :      ``.       \\__|_| |_|\\___|					            ");
            Console.WriteLine(" \\ r=._\\        `.								                    ");
            Console.WriteLine("<`\\_  \\         .`-.         _____  _                  _   _ 	    ");
            Console.WriteLine(" \\ r-7  `-. ._  ' .  `\\     |  __\\ | |                | | | |	    ");
            Console.WriteLine("  \\`,      `-.`7  7)   )    | |__) | | __ _ _ __   ___| |_| |	    ");
            Console.WriteLine("   \\/         \\|  \'  / `-._ | ___/ | |/ _` | '_ \\ / _ \\ __| |	");
            Console.WriteLine("              ||    .'      | |    | | (_| | | | |  __/ |_|_|	    ");
            Console.WriteLine("               \\  (         |_|    |_|\\__,_|_| |_|\\___|\\__(_)	");
            Console.WriteLine("                >\\  >								                ");
            Console.WriteLine("            ,.-' >.'								                    ");
            Console.WriteLine("           <.'_.''								                    ");
            Console.WriteLine("             <'									                  \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            // le pedimos al usuario ingresar una nota.
            Console.WriteLine("Ingrese Nota, entre [0:10]");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            Console.ForegroundColor = ConsoleColor.Green;
            // usamos un condicional switch para verificar el valor de la nota dada
            switch (nota)
            {
                case 5: // si el alumno saco 5 esta reprobado
                    Console.WriteLine("Reprobado, por haragan :-(\n");
                    // cortamos el flujo del condicional.
                    break;
                case 6:// si el alumno saco 6 esta aprobado
                    Console.WriteLine("Bien echo crack =]\n");
                    // cortamos el flujo del condicional.
                    break;
                case 9:// si el alumno saco 9 esta aprobado
                    Console.WriteLine("Sobresaliente, no pares de mejorar :)\n");
                    // cortamos el flujo del condicional.
                    break;
                case 10:// si el alumno saco 10 esta aprobado
                    Console.WriteLine("Matricula de honor :()\n");
                    // cortamos el flujo del condicional.
                    break;
                default:
                    Console.WriteLine("El valor de nota, no es correcto. :'(\n");
                    // cortamos el flujo del condicional.
                    break;
            }

            Console.ReadKey();  
        }
    }
}
