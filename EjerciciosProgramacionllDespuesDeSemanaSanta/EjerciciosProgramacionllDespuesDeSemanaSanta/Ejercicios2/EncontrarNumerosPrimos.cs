using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que son primos.
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class EncontrarNumerosPrimos
    {
        public static void MainEncontrarNumerosPrimos()
        {
            Console.Title = "Numeros primos";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                                                                                                                                            
                                                              88                                                 88                      88  88                           
                                                              88                                                 """"    ,d                88  """"                           
                                                              88                                                       88                88                               
 ,adPPYba,   ,adPPYba,   8b,dPPYba,   ,adPPYba,   ,adPPYba,   88   ,adPPYba,     8b      db      d8  8b,dPPYba,  88  MM88MMM  ,adPPYba,  88  88  8b,dPPYba,    ,adPPYba,  
a8""     """"  a8""     ""8a  88P'   `""8a  I8[    """"  a8""     ""8a  88  a8P_____88     `8b    d88b    d8'  88P'   ""Y8  88    88    a8P_____88  88  88  88P'   `""8a  a8P_____88  
8b          8b       d8  88       88   `""Y8ba,   8b       d8  88  8PP""""""""""""""      `8b  d8'`8b  d8'   88          88    88    8PP""""""""""""""  88  88  88       88  8PP""""""""""""""  
""8a,   ,aa  ""8a,   ,a8""  88       88  aa    ]8I  ""8a,   ,a8""  88  ""8b,   ,aa  888  `8bd8'  `8bd8'    88          88    88,   ""8b,   ,aa  88  88  88       88  ""8b,   ,aa  
 `""Ybbd8""'   `""YbbdP""'   88       88  `""YbbdP""'   `""YbbdP""'   88   `""Ybbd8""'  888    YP      YP      88          88    ""Y888  `""Ybbd8""'  88  88  88       88   `""Ybbd8""'
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<int> numeros = new List<int>() { 13, 7, 8, 26, 35 };
            List<int> primos = new List<int>();
            string listaDeNumerosPrimos = "";

            foreach (var item in numeros)
            {
                listaDeNumerosPrimos += item + ", ";
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] La lista de numeros primos son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDeNumerosPrimos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Los numeros primos encontrados son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            listaDeNumerosPrimos = "";

            foreach (var item in numeros)
            {
                float residuo = (item % 2);
                if (residuo != 0) 
                {
                    primos.Add(item);
                    listaDeNumerosPrimos += item + ", ";
                }
            }

            Console.WriteLine("[>] " + listaDeNumerosPrimos);
        }
    }
}
