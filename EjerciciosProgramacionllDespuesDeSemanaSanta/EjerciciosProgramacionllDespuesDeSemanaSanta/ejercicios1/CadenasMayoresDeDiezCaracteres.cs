using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de cadenas y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que tienen más de 5 caracteres. 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class CadenasMayoresDeDiezCaracteres
    {
        public static void MainCadenasMayoresDeDiezCaracteres()
        {
            Console.Title = "Encontrar cadenas con mas de diez caracteres";

            List<string> objectos = new List<string>() { "zapato", "llanta", "juguete", "celular", "pelota", "llave", "tuerca", "plato"};
            List<string> mayoresDeCincoCaracteres = new List<string>();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
      .-'''-.    ____       ____     __         ,---.   .--.    ,-----.            ,---------.    ,-----.                 .-./`)     ____    ,---.  ,---.   ____     
      / _     \ .'  __ `.    \   \   /  /        |    \  |  |  .'  .-,  '.          \          \ .'  .-,  '.               \ '_ .') .'  __ `. |   /  |   | .'  __ `.  
     (`' )/`--'/   '  \  \    \  _. /  '         |  ,  \ |  | / ,-.|  \ _ \          `--.  ,---'/ ,-.|  \ _ \             (_ (_) _)/   '  \  \|  |   |  .'/   '  \  \ 
    (_ o _).   |___|  /  |     _( )_ .'          |  |\_ \|  |;  \  '_ /  | :            |   \  ;  \  '_ /  | :              / .  \ |___|  /  ||  | _ |  | |___|  /  | 
     (_,_). '.    _.-`   | ___(_ o _)'           |  _( )_\  ||  _`,/ \ _/  |            :_ _:  |  _`,/ \ _/  |         ___  |-'`|     _.-`   ||  _( )_  |    _.-`   | 
    .---.  \  :.'   _    ||   |(_,_)'            | (_ o _)  |: (  '\_/ \   ;            (_I_)  : (  '\_/ \   ;        |   | |   '  .'   _    |\ (_ o._) / .'   _    | 
    \    `-'  ||  _( )_  ||   `-'  /             |  (_,_)\  | \ `""/  \  ) /            (_(=)_)  \ `""/  \  ) /         |   `-'  /   |  _( )_  | \ (_,_) /  |  _( )_  | 
     \       / \ (_ o _) / \      /              |  |    |  |  '. \_/``"".'              (_I_)    '. \_/``"".'           \      /    \ (_ o _) /  \     /   \ (_ o _) / 
      `-...-'   '.(_,_).'   `-..-'               '--'    '--'    '-----'                '---'      '-----'              `-..-'      '.(_,_).'    `---`     '.(_,_).'  
                                                                                                                                  
            ");
            Console.ForegroundColor= ConsoleColor.Gray;

            string listaDeObjectos = "";

            foreach (var item in objectos)
            {
                listaDeObjectos += item + ", ";
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nLista de objectos\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[>] " + listaDeObjectos);

            string objectosConMasDeCincoCaracteres = "";
            foreach (var item in objectos)
            {
                if (item.Length > 5)
                {
                    mayoresDeCincoCaracteres.Add(item);
                    objectosConMasDeCincoCaracteres += item + ", ";
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Los objectos con mas de cinco caracteres son: \n");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine(objectosConMasDeCincoCaracteres);
        }
    }
}
