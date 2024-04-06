using System;
using System.Collections.Generic;


/*
    Crea una lista de enteros y agrega 10 elementos a ella. Luego, elimina
    todos los elementos que sean múltiplos de 3 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class EliminarMultiplos
    {
        public static void MainEliminarMultiplos()
        {
            Console.Title = "Eliminar Multiplos";


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
 __       ________   ______    ________   __   __   ______   __           ________  ______       ______   ______   ______   __          
/_/\     /_______/\ /_____/\  /_______/\ /_/\ /_/\ /_____/\ /_/\         /_______/\/_____/\     /_____/\ /_____/\ /_____/\ /_/\         
\:\ \    \::: _  \ \\:::_ \ \ \::: _  \ \\:\ \\ \ \\::::_\/_\:\ \        \__.::._\/\::::_\/_    \:::__\/ \:::_ \ \\:::_ \ \\:\ \        
 \:\ \    \::(_)  \ \\:(_) ) )_\::(_)  \ \\:\ \\ \ \\:\/___/\\:\ \          \::\ \  \:\/___/\    \:\ \  __\:\ \ \ \\:\ \ \ \\:\ \       
  \:\ \____\:: __  \ \\: __ `\ \\:: __  \ \\:\_/.:\ \\::___\/_\:\ \____     _\::\ \__\_::._\:\    \:\ \/_/\\:\ \ \ \\:\ \ \ \\:\ \____  
   \:\/___/\\:.\ \  \ \\ \ `\ \ \\:.\ \  \ \\ ..::/ / \:\____/\\:\/___/\   /__\::\__/\ /____\:\    \:\_\ \ \\:\_\ \ \\:\_\ \ \\:\/___/\ 
    \_____\/ \__\/\__\/ \_\/ \_\/ \__\/\__\/ \___/_(   \_____\/ \_____\/   \________\/ \_____\/     \_____\/ \_____\/ \_____\/ \_____\/ 
                                                                                                                                                                                   ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<int> numeros = new List<int>() { 3, 5, 10, 12, 15, 18, 44, 22, 33, 36 };

            string listaDeNumeros = "";

            foreach (var item in numeros)
            {
                listaDeNumeros += item + ", ";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Lista de numeros \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDeNumeros);

            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                if (numeros[i] % 3 == 0)
                {
                    //RemoveAt elimina por indice
                    numeros.RemoveAt(i);
                }
            }

            listaDeNumeros = "";

            foreach (var item in numeros)
            {
                listaDeNumeros += item + ", ";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Numeros multiplos de 3 eliminados");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n[>] " + listaDeNumeros);
        }
    }
}
