using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 10 elementos a ella. Luego, 
    encuentra la suma de los elementos en la lista que son mayores que el 
    promedio de la lista. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class EncontrarElementosMayoresAlPromedio
    {
        public static void MainEncontrarElementosMayoresAlPromedio()
        {
            Console.Title = "Numeros mayores al promedio";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
        ______/\\\\\\\\\\\__/\\\\\\\\\\\\_____/\\\________/\\\_        
         _____\/////\\\///__\/\\\////////\\\__\/\\\_____/\\\//__       
          _________\/\\\_____\/\\\______\//\\\_\/\\\__/\\\//_____      
           _________\/\\\_____\/\\\_______\/\\\_\/\\\\\\//\\\_____     
            _________\/\\\_____\/\\\_______\/\\\_\/\\\//_\//\\\____    
             _________\/\\\_____\/\\\_______\/\\\_\/\\\____\//\\\___   
              __/\\\___\/\\\_____\/\\\_______/\\\__\/\\\_____\//\\\__  
               _\//\\\\\\\\\______\/\\\\\\\\\\\\/___\/\\\______\//\\\_ 
                __\/////////_______\////////////_____\///________\///__
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<int> enteros = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            List<double> enterosMayoresAlPromedio = new List<double>();
            double promedio = enteros.Sum() / enteros.Count();
            string listaDeEnteros = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] El promedio de la lista de enteros es: {0}", promedio);
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in enteros)
            {
                listaDeEnteros += item + ", ";
            }

            Console.WriteLine("\n[>] " + listaDeEnteros);

            listaDeEnteros = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+]Los numeros mayores al promedio es: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in enteros)
            {
                if (item > promedio)
                {
                    enterosMayoresAlPromedio.Add(item);
                    listaDeEnteros += item + ", ";
                }
            }

            Console.WriteLine("\n[>] " + listaDeEnteros);
        }
    }
}
