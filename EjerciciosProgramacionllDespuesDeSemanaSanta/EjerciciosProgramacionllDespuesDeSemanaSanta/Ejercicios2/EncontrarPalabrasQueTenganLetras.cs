using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que contienen la letra “a” y la letra
    “e”. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class EncontrarPalabrasQueTenganLetras
    {
        public static void MainEncontrarPalabrasQueTenganLetras()
        {

            Console.Title = "Encontrar cadenas con a y e"; 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
              _______        __    ________  ______
             / ___/ /  ___ _/ /_  / ___/ _ \/_  __/
            / /__/ _ \/ _ `/ __/ / (_ / ___/ / /   
            \___/_//_/\_,_/\__/  \___/_/    /_/    
                       _       __              
                      (_)__   / /  ___ _______ 
                     / (_-<  / _ \/ -_) __/ -_)
                    /_/___/ /_//_/\__/_/  \__/     
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<string> list = new List<string>() { "Halo", "Call of duty black ops zombies", "God of war", "Resident Evil", "GTA Sanandreas" };
            List<string> coincidencias = new List<string>();


            string listaDePalabras = "";
            foreach (var item in list)
            {
                listaDePalabras += item + ", ";
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Lista de palabras: \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDePalabras);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Las palabras que contienen la letra a y e son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            RegexOptions opciones = RegexOptions.IgnoreCase | RegexOptions.Multiline;
            string existeAandE = @"^(?=.*a)(?=.*e).*$";

            Regex rg = new Regex(existeAandE, opciones);

            foreach (var item in list)
            {
                if (rg.IsMatch(item))
                {
                    coincidencias.Add(item);
                }
            }

            listaDePalabras = "";

            foreach (var item in coincidencias)
            {
                listaDePalabras += item + ", ";
            }

            Console.WriteLine("[>] " + listaDePalabras);
        }
    }
}
