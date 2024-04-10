using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    .Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra 
    la cantidad de elementos en la lista que tienen una longitud mayor que 
    el promedio de la longitud de los elementos en la lista. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class MayoresAlPromedioUsando10Elementos
    {
        public static void MainMayoresAlPromedioUsando10Elementos()
        {
            Console.Title = "Numeros mayores al promedio";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
             .d8888b.    888  888               d8888 888      888       888        d8888 Y88b   d88P  .d8888b.  
            d88P  Y88b   888  888              d88888 888      888   o   888       d88888  Y88b d88P  d88P  Y88b 
            888    888 888888888888           d88P888 888      888  d8b  888      d88P888   Y88o88P   Y88b.      
            888          888  888            d88P 888 888      888 d888b 888     d88P 888    Y888P     ""Y888b.   
            888          888  888           d88P  888 888      888d88888b888    d88P  888     888         ""Y88b. 
            888    888 888888888888        d88P   888 888      88888P Y88888   d88P   888     888           ""888 
            Y88b  d88P   888  888         d8888888888 888      8888P   Y8888  d8888888888     888     Y88b  d88P 
             ""Y8888P""    888  888        d88P     888 88888888 888P     Y888 d88P     888     888      ""Y8888P""                                                                                   
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<string> cadenas = new List<string> { "manzana", "pera", "banana", "naranja", "kiwi" };

            string listaDeCadenas = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] La lista de cadenas es: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in cadenas)
            {
                listaDeCadenas += item + ", ";
            }

            Console.WriteLine("[>] " + listaDeCadenas);

            int longitudTotal = cadenas.Sum(cadena => cadena.Length);

            double promedioLongitud = longitudTotal / cadenas.Count;

            listaDeCadenas = "";

            foreach (string item in cadenas)
            {
                if (item.Length > promedioLongitud)
                {
                    listaDeCadenas += item + ", ";
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] La lista de cadenas mayores al promedio es: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDeCadenas);
        }
    }
}
