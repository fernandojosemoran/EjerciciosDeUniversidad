using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 10 elementos a ella. Luego, ordena la
    lista de manera descendente y encuentra el segundo elemento más
    grande. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class OrdenarDecendentementeAndEncontrarElSegundoNumeroMasGrande
    {
        public static void MainOrdenarDecendentementeAndEncontrarElSegundoNumeroMasGrande()
        {
            Console.Title = "Ordenar Decendentemente y Encontrar ElSegundo Numero Mas Grande";

            List<int> numeros = new List<int>() { 10,34,58,99,123,654,876,347,843 };
            string listaDeNumeros = "";

            foreach (var item in numeros)
            {
                listaDeNumeros += item  + ", ";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Listado de numeros:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDeNumeros);
            Console.WriteLine("\n");

            numeros.Sort();
            numeros.Reverse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] El segundo numero mas grande {0}", numeros[1]);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
