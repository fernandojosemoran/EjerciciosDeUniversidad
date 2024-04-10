using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 10 elementos a ella. Luego, 
    encuentra la cantidad de elementos en la lista que son divisibles por 2, 3 
    y 5. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class ElementosDiviciblesPorUnoDosAndCinco
    {
        public static void MainElementosDiviciblesPorUnoDosAndCinco()
        {

            Console.Title = "Elementos divicibles por numeros";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                            .         .                              
                     .8.                   ,8.       ,8.          8 888888888o.      
                    .888.                 ,888.     ,888.         8 8888    `^888.   
                   :88888.               .`8888.   .`8888.        8 8888        `88. 
                  . `88888.             ,8.`8888. ,8.`8888.       8 8888         `88 
                 .8. `88888.           ,8'8.`8888,8^8.`8888.      8 8888          88 
                .8`8. `88888.         ,8' `8.`8888' `8.`8888.     8 8888          88 
               .8' `8. `88888.       ,8'   `8.`88'   `8.`8888.    8 8888         ,88 
              .8'   `8. `88888.     ,8'     `8.`'     `8.`8888.   8 8888        ,88' 
             .888888888. `88888.   ,8'       `8        `8.`8888.  8 8888    ,o88P'   
            .8'       `8. `88888. ,8'         `         `8.`8888. 8 888888888P'      
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            // Crear una lista de enteros y agregar 10 elementos a ella
            List<int> numeros = new List<int> { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
            List<int> diviciblesPor2 = new List<int>();
            List<int> diviciblesPor3 = new List<int>();
            List<int> diviciblesPor5 = new List<int>();

            string listadoTotalDeNumeros = "";
            string listaDeDiviciblesPor2 = "";
            string listaDeDiviciblesPor3 = "";
            string listaDeDiviciblesPor5 = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Lista de numeros: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in numeros)
            {
                listadoTotalDeNumeros += item + ", ";
            }

            Console.WriteLine(listadoTotalDeNumeros);

            foreach (int item in numeros)
            {
                if (item % 2 == 0)
                {
                    diviciblesPor2.Add(item);
                    listaDeDiviciblesPor2 += item + ", ";
                }

                if (item % 3 == 0)
                {
                    diviciblesPor3.Add(item);
                    listaDeDiviciblesPor3 += item + ", ";   
                }

                if (item % 5 == 0)
                {
                    diviciblesPor5.Add(item);
                    listaDeDiviciblesPor5 += item + ", ";
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Elementos divisibles por 2: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(listaDeDiviciblesPor2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Elementos divisibles por 3: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(listaDeDiviciblesPor3);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Elementos divisibles por 5: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(listaDeDiviciblesPor5);
        }
    }
}
