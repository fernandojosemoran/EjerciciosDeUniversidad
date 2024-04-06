using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 3 elementos a ella. Luego, ordena la
    lista en orden alfabético.
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class AgregarAndOrdenarCadenas
    {
        public static void MainAgregarAndOrdenarCadenas()
        {
            Console.Title = "Agregar cadenas y ordenarlas en orden alfabetico";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                    _                               _                __                  _                   
                                   (_)                             (_)              / _|                (_)                  
              ___ _ __    _ __ ___  _   _ __ ___   __ _  __ _ _   _ _ _ __   __ _  | |_ _   _ _ __   ___ _  ___  _ __   __ _ 
             / _ \ '_ \  | '_ ` _ \| | | '_ ` _ \ / _` |/ _` | | | | | '_ \ / _` | |  _| | | | '_ \ / __| |/ _ \| '_ \ / _` |
            |  __/ | | | | | | | | | | | | | | | | (_| | (_| | |_| | | | | | (_| | | | | |_| | | | | (__| | (_) | | | | (_| |
             \___|_| |_| |_| |_| |_|_| |_| |_| |_|\__,_|\__, |\__,_|_|_| |_|\__,_| |_|  \__,_|_| |_|\___|_|\___/|_| |_|\__,_|
                                                           | |                                                               
                                                           |_|            
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<string> list = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nAgregue un texto: ");
                string texto = Console.ReadLine();
                list.Add(texto);
            }

            list.Sort();

            Console.WriteLine("\nLos datos ingresados estan ordenados y son {0} elementos\n", list.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
