using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que contienen la letra “e” 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class ContieneLaLetraE
    {
        public static void MainContieneLaLetraE()
        {
            Console.Title = "Tiene la letra indicada la lista";
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
           /\  \     /\  \          /\  \     /\  \  
          /::\  \   /::\  \         \:\  \   /::\  \ 
         /:/\:\__\ /:/\:\__\        /::\__\ /:/\:\__\
         \:\:\/__/ \:\/:/  /       /:/\/__/ \:\/:/  /
          \::/  /   \::/  /        \/__/     \::/  / 
           \/__/     \/__/                    \/__/  
            ");
            Console.WriteLine(@"
            ___       ___       ___       ___            ___       ___       ___            ___       ___       ___       ___   
           /\__\     /\  \     /\  \     /\__\          /\  \     /\__\     /\  \          /\__\     /\  \     /\  \     /\  \  
          /:/__/_   /::\  \   /::\  \   /:/ _/_         \:\  \   /:/__/_   /::\  \        /:| _|_   /::\  \   /::\  \   /::\  \ 
         /::\/\__\ /::\:\__\ /:/\:\__\ /::-""\__\        /::\__\ /::\/\__\ /::\:\__\      /::|/\__\ /::\:\__\ /\:\:\__\ /::\:\__\
         \/\::/  / \/\::/  / \:\ \/__/ \;:;-"",-""       /:/\/__/ \/\::/  / \:\:\/  /      \/|::/  / \/\::/  / \:\:\/__/ \/\::/  /
           /:/  /    /:/  /   \:\__\    |:|  |         \/__/      /:/  /   \:\/  /         |:/  /    /:/  /   \::/  /    /:/  / 
           \/__/     \/__/     \/__/     \|__|                    \/__/     \/__/          \/__/     \/__/     \/__/     \/__/  
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<string> list = new List<string>() { "Pelear", "Comer", "Dormir", "Rascar", "Nadar", };
            List<string> listPalabrasQueCoinciden = new List<string>();
            string listadoDeVerbos = "";

            foreach (string item in list) { 
                listadoDeVerbos += item + ", ";
            }
            
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Listado de palabras\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listadoDeVerbos);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[?] Ingrese un caracter al cual buscar en cadenas de texto: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            char caracter = Console.ReadLine()[0];

            foreach (var item in list)
            {
                //Agregamos algunas flags a una expresion regular para que detecte las letras mayusculas tambien
                RegexOptions opciones = RegexOptions.IgnoreCase | RegexOptions.Multiline;

                Regex rg = new Regex($"{caracter}", opciones);

                if (rg.IsMatch(item))
                {
                    listPalabrasQueCoinciden.Add(item); 
                }
            }

            string coincidenciasEncontradas = "";
            foreach (var item in listPalabrasQueCoinciden)
            {
                coincidenciasEncontradas += item + ", ";
            }
            
            if (listPalabrasQueCoinciden.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n[+] Las coincidencias encontradas\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine($"[>] {coincidenciasEncontradas}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] No hay coincidencias con la letra {0}\n", caracter);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
