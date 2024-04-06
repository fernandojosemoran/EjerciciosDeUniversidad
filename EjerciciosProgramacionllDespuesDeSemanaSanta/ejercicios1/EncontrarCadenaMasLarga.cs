using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cadena más larga en la lista. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class EncontrarCadenaMasLarga
    {
        private List<string> _list = new List<string>();
        public void MainEncontrarCadenaMasLarga()
        {
            Console.Title = "Encontrar cadena mas larga";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                 __     __  __  __   __  _____   ______  __     __  ______       __   ________       ______  ______  ______  __      ______    
                /\ \  _ \ \/\ \/\ ""-.\ \/\  __-./\  __ \/\ \  _ \ \/\  ___\     /\ \ / /\  ___\     /\  __ \/\  == \/\  == \/\ \    /\  ___\   
                \ \ \/ "".\ \ \ \ \ \-.  \ \ \/\ \ \ \/\ \ \ \/ "".\ \ \___  \    \ \ \'/\ \___  \    \ \  __ \ \  _-/\ \  _-/\ \ \___\ \  __\   
                 \ \__/"".~\_\ \_\ \_\\""\_\ \____-\ \_____\ \__/"".~\_\/\_____\    \ \__| \/\_____\    \ \_\ \_\ \_\   \ \_\   \ \_____\ \_____\ 
                  \/_/   \/_/\/_/\/_/ \/_/\/____/ \/_____/\/_/   \/_/\/_____/     \/_/   \/_____/     \/_/\/_/\/_/    \/_/    \/_____/\/_____/ 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");

            void AgregarTexto()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese un palabra o frase: ");
                    string cadena = Console.ReadLine();

                    _list.Add(cadena);
                }
            }

            AgregarTexto();

            
            List<int> AgregarLongitudDeTexto()
            {
                List<int> longitudes = new List<int>();
                foreach (var item in _list)
                {
                    longitudes.Add(item.Length);
                }

                return longitudes;
            }

            List<String> VerificarSiExistenPalabrasSimilare() {
                List<int> longitudesDeCaracteresDeTexto = AgregarLongitudDeTexto();
                List<string> SonSimilares = new List<string>();

                foreach (var item in _list)
                {
                    if (longitudesDeCaracteresDeTexto.Max() == item.Length)
                    {
                        SonSimilares.Add(item);
                    }

                }

                return SonSimilares;
            }

            void MostrarCadenaConMasLongitudDeCaracteres()
            {
                List<String> SonSimilar = VerificarSiExistenPalabrasSimilare();

                if (SonSimilar.Count > 1)
                {
                    foreach (var item in SonSimilar)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[-] Hay mas de una cadena con la misma longitud: {0}\n", item);
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                }
                else
                {
                    foreach (var item in SonSimilar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n[+] La cadena mas larga es: {0}\n", item);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }

            MostrarCadenaConMasLongitudDeCaracteres();

        }
    }
}
