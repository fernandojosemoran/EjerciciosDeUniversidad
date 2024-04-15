using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea un diccionario que almacene el nombre de un Departamento y su población. Luego, 
    agrega algunos departamentos y sus poblaciones a este diccionario por consola. 
    Finalmente, limpia la consola e imprime el diccionario completo. 
*/

namespace Diccionarios
{
    internal class AlmacenarDepartamentoAndPoblacion
    {
        public static void MainAlmacenarDepartamentoAndPoblacion()
        {
            Console.Title = "Departamentos y poblaciones";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
ooo        ooooo                        .             oooo       oooo                                     .o8                     .   
`88.       .888'                      .o8             `888       `888                                    ""888                   .o8   
 888b     d'888   .ooooo.  oooo d8b .o888oo  .oooo.    888        888  oooo   .ooooo.  ooo. .oo.  .oo.    888oooo.   .oooo.   .o888oo 
 8 Y88. .P  888  d88' `88b `888""""8P   888   `P  )88b   888        888 .8P'   d88' `88b `888P""Y88bP""Y88b   d88' `88b `P  )88b    888   
 8  `888'   888  888   888  888       888    .oP""888   888        888888.    888   888  888   888   888   888   888  .oP""888    888   
 8    Y     888  888   888  888       888 . d8(  888   888        888 `88b.  888   888  888   888   888   888   888 d8(  888    888 . 
o8o        o888o `Y8bod8P' d888b      ""888"" `Y888""""8o o888o      o888o o888o `Y8bod8P' o888o o888o o888o  `Y8bod8P' `Y888""""8o   ""888"" 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Dictionary<string, int> departamentos = new Dictionary<string, int>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[!] Ingrese el nombre del departamento (o 'fin' para terminar):");
                Console.ForegroundColor = ConsoleColor.Gray;
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "fin")
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[!] Ingrese la población del departamento:");
                Console.ForegroundColor = ConsoleColor.Gray;

                int poblacion;

                while (!int.TryParse(Console.ReadLine(), out poblacion) || poblacion < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Población no válida. Por favor, ingrese un número entero no negativo.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n[!] Ingrese la población del departamento:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                departamentos[nombre] = poblacion;
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Departamentos y poblaciones:");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var kvp in departamentos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] {kvp.Key}: {kvp.Value}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
