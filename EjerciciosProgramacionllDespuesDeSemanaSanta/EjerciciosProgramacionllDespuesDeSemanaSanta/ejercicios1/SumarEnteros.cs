using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 5 elementos a ella. Luego, encuentra
    la suma de todos los elementos en la lista. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class SumarEnteros
    {
        public static void MainSumarEnteros()
        {
            Console.Title = "Suma de una lista";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
                 ██████╗ ██╗ ██╗     ██╗   ██╗███████╗         ██╗ █████╗ ██╗   ██╗ █████╗ 
                ██╔════╝████████╗    ██║   ██║██╔════╝         ██║██╔══██╗██║   ██║██╔══██╗
                ██║     ╚██╔═██╔╝    ██║   ██║███████╗         ██║███████║██║   ██║███████║
                ██║     ████████╗    ╚██╗ ██╔╝╚════██║    ██   ██║██╔══██║╚██╗ ██╔╝██╔══██║
                ╚██████╗╚██╔═██╔╝     ╚████╔╝ ███████║    ╚█████╔╝██║  ██║ ╚████╔╝ ██║  ██║
                 ╚═════╝ ╚═╝ ╚═╝       ╚═══╝  ╚══════╝     ╚════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝  ╚═╝
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            List<int> enteros = new List<int>() { 10,54,34,98,29 };
            Console.WriteLine("\n");
            Console.WriteLine("La suma de todos los numeros es: {0}", enteros.Sum());
        }
    }
}
