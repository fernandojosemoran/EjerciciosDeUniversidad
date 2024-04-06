using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que son pares 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class EncontrarListaDeEnterosPares
    {
        public static void MainEncontrarListaDeEnterosPares()
        {
            Console.Title = "Encontrar Numeros Pares";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                \ \/ /___ _   ____  _________  / /_  ____ ______/ /____     ________  (_)___  (_)____(_)___ _____  ____/ /___  
                 \  / __ `/  / __ \/ ___/ __ \/ __ \/ __ `/ ___/ __/ _ \   / ___/ _ \/ / __ \/ / ___/ / __ `/ __ \/ __  / __ \ 
                 / / /_/ /  / /_/ / /  / /_/ / /_/ / /_/ (__  ) /_/  __/  / /  /  __/ / / / / / /__/ / /_/ / / / / /_/ / /_/ / 
                /_/\__,_/  / .___/_/   \____/_.___/\__,_/____/\__/\___/  /_/   \___/_/_/ /_/_/\___/_/\__,_/_/ /_/\__,_/\____(_)
                          /_/                                                                                                 
            "
            );

            Console.ForegroundColor = ConsoleColor.Gray;

            List<int> listaDeEnteros = new List<int>() { 10,37, 40, 73, 60, 101, 84 };

            string listadoDenumeros = "";

            foreach (var item in listaDeEnteros)
            {
                listadoDenumeros += item + ", ";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] El listado de numeros son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("[>] " + listadoDenumeros);

            List<int> numerosPares = new List<int>();
            listadoDenumeros = "";

            foreach (var item in listaDeEnteros)
            {
                double residuo = (item % 2);
                if (residuo == 0)
                {
                    listadoDenumeros += item + ", ";
                    numerosPares.Add(item); 
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Los numeros pares son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listadoDenumeros);


        }
    }
}
