using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra 
    la cantidad de elementos en la lista que contienen una subcadena que 
    comienza con la letra “b” y termina con la letra “a”. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.Ejercicios2
{
    internal class EncontrarSubCadena
    {
        public static void MainEncontrarSubCadena()
        {
            Console.Title = "Que inicien con b y finalicen con a";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
            SSSSS                                                                                                               
            SSSSS .sSSSs.  SSSSS .sSSSSSSSSSSSSSs. .sSSSSs.    SSSSS            .sSSSSs.    .sSSSSs.    .sSSSSSSSs. .sSSSSs.    
            S SSS S SSS SS SSSSS SSSSS S SSS SSSSS S SSSSSSSs. S SSS            S SSSSSSSs. S SSSSSSSs. S SSS SSSSS S SSSSSSSs. 
            S  SS S  SS  `sSSSSS SSSSS S  SS SSSSS S  SS SSSS' S  SS            S  SS SSSS' S  SS SSSSS S  SS SSSS' S  SS SSSS' 
            S..SS S..SS    SSSSS `:S:' S..SS `:S:' S..SS       S..SS            S..SS       S..SS SSSSS S..SSsSSSa. S..SS       
            S:::S S:::S    SSSSS       S:::S       S:::SSSS    S:::S            S:::S SSSSS S:::S SSSSS S:::S SSSSS S:::SSSS    
            S;;;S S;;;S    SSSSS       S;;;S       S;;;S       S;;;S            S;;;S SSSSS S;;;S SSSSS S;;;S SSSSS S;;;S       
            S%%%S S%%%S    SSSSS       S%%%S       S%%%S SSSSS S%%%S SSSSS      S%%%S SSSSS S%%%S SSSSS S%%%S SSSSS S%%%S SSSSS 
            SSSSS SSSSS    SSSSS       SSSSS       SSSSSsSS;:' SSSSSsSS;:'      SSSSSsSSSSS SSSSSsSSSSS SSSSS SSSSS SSSSSsSS;:'
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<string> cadenas = new List<string>{ "Banana","Manzana","Pera","Uva","Banana" };
            List<string> coincidencias = new List<string>();
            string listaDeCadenas = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] La lista de cadenas es la siguiente: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in cadenas)
            {
                listaDeCadenas += item + ", ";
            }

            Console.WriteLine(listaDeCadenas);

            string patron = @"\b[bB].*a\b";

            Regex regex = new Regex(patron);

            listaDeCadenas = ""; 

            foreach (string item in cadenas)
            {
                if (regex.IsMatch(item))
                {
                    coincidencias.Add(item);
                    listaDeCadenas += item + ", ";
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Las cadenas que coinciden son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("[>] " + listaDeCadenas);
        }
    }
}
