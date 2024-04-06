using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que comienzan con la letra “A” 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class EncontrarElementosConCaracterDado
    {
        private List<String> _cadenas = new List<String>() { "Pizza", "Hamburguesa", "Hotdog", "Pollo", "Papas Fritas", "Manzanas", "Nance", "Aguacate o Palta", "Cacao", "Sandia", "Uva" };
        public void MainEncontrarElementosConCaracterDado()
        {
            Console.Title = "Buscar alimentos que empiecen con caracter";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
                 _________  _______           ________ ________  ___   _________  ________          _______   ___                        
                |\___   ___\\  ___ \         |\  _____\\   __  \|\  \ |\___   ___\\   __  \        |\  ___ \ |\  \              ___      
                \|___ \  \_\ \   __/|        \ \  \__/\ \  \|\  \ \  \\|___ \  \_\ \  \|\  \       \ \   __/|\ \  \            |\__\     
                     \ \  \ \ \  \_|/__       \ \   __\\ \   __  \ \  \    \ \  \ \ \   __  \       \ \  \_|/_\ \  \           \|__|     
                      \ \  \ \ \  \_|\ \       \ \  \_| \ \  \ \  \ \  \____\ \  \ \ \  \ \  \       \ \  \_|\ \ \  \____          ___   
                       \ \__\ \ \_______\       \ \__\   \ \__\ \__\ \_______\ \__\ \ \__\ \__\       \ \_______\ \_______\       |\  \  
                        \|__|  \|_______|        \|__|    \|__|\|__|\|_______|\|__|  \|__|\|__|        \|_______|\|_______|       \ \  \ 
                                                                                                                                  _\/  /|
                                                                                                                                 |\___/ /
                                                                                                                                 \|___|/ 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Inventario de alimentos\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            void MostrarAlimentosExistentes()
            {
                string alimentos = "";
                int contador = 1;
                foreach (var item in _cadenas)
                {
                    alimentos += $"({contador})" + item + " ";
                    contador++;
                }

                Console.WriteLine(alimentos);
            }

            MostrarAlimentosExistentes();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] Ingresa una letra y devolvera los alimentos que inicien con ese producto.\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Ingresa una lentra: ");
            string texto = Console.ReadLine().ToUpper();
            List<String> coincidencias = new List<String>();

            //Comprobamos que el usuario alla enviado un caracter y no un texto
            if (texto.Length > 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] Se solicito un caracter y recibio un texto");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
               void BuscarAlimentosQueEmpiecenConElCaracterIngresado()
                {
                    Char caracter = texto[0];

                    foreach (var item in _cadenas)
                    {
                        bool coincideConCaracter = Regex.IsMatch(item, $"^{caracter}");

                        if (coincideConCaracter)
                        {
                            coincidencias.Add(item);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nLos alimentos encontrados son:\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    foreach (var item in coincidencias)
                    {
                        Console.WriteLine(item);
                    }
                }

                BuscarAlimentosQueEmpiecenConElCaracterIngresado();
            }
        }
    }
}
