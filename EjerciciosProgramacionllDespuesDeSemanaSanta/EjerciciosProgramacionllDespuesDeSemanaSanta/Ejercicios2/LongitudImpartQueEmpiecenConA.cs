using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que tienen una longitud impar y
    comienzan con la letra “a”. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class LongitudImpartQueEmpiecenConA
    {
        public static void MainLongitudImpartQueEmpiecenConA()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
              __    __    _______  ___      ___        ______        __   __  ___     ______     _______   ________   
             /"" |  | ""\  /""     ""||""  |    |""  |      /    "" \      |""  |/  \|  ""|   /    "" \   /""      \ |""      ""\  
            (:  (__)  :)(: ______)||  |    ||  |     // ____  \     |'  /    \:  |  // ____  \ |:        |(.  ___  :) 
             \/      \/  \/    |  |:  |    |:  |    /  /    ) :)    |: /'        | /  /    ) :)|_____/   )|: \   ) || 
             //  __  \\  // ___)_  \  |___  \  |___(: (____/ //      \//  /\'    |(: (____/ //  //      / (| (___\ || 
            (:  (  )  :)(:      ""|( \_|:  \( \_|:  \\        /       /   /  \\   | \        /  |:  __   \ |:       :) 
             \__|  |__/  \_______) \_______)\_______)\""_____/       |___/    \___|  \""_____/   |__|  \___)(________/  
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<String> list = new List<String>() { "Amazon", "Estrella", "Julio", "Astro", "Ala" };
            List<string> elementosImpares = new List<string>();
            string listaDeElementos = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Los elementos son: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in list)
            {
                listaDeElementos += $"{item} ({item.Length}), ";
            }

            Console.WriteLine("\n\t[>] " + listaDeElementos);

            string listaDeElementosImpares = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Los elementos impares son: ");
            Console.ForegroundColor = ConsoleColor.Gray;


            string patron = @"^a";
            RegexOptions opciones = RegexOptions.IgnoreCase | RegexOptions.Multiline;
            Regex rg = new Regex(patron, opciones);

            foreach (var item in list)
            {
                double esImpar = (item.Length % 2);
                if (esImpar != 0)
                {
                    if (rg.IsMatch(item))
                    {
                        elementosImpares.Add(item);
                        listaDeElementosImpares += $"{item} ({item.Length}), ";
                    }
                }
            }

            Console.WriteLine("\n[>] " + listaDeElementosImpares);
        }
    }
}
