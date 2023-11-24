using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Haciendo uso de los bucles while, do while y for, para cada ejercicio resuelva lo 
siguiente.

1 - Imprimir los números del 1 al 500.
2 - Imprimir los números del 50 al 100.
3 - Imprimir los números del -50 al 0.
4 - Imprimir los números del 2 al 100 pero de 2 en 2 (2,4,6,8 ....100) 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio10
    {
        public static void EjercicioDiez()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n__________________▄▄▄▀▀▀▀▀▀▀▄							");
            Console.WriteLine("_______________▄▀▀____▀▀▀▀▄____█							");
            Console.WriteLine("___________▄▀▀__▀▀▀▀▀▀▄___▀▄___█							");
            Console.WriteLine("__________█▄▄▄▄▄▄_______▀▄__▀▄__█							");
            Console.WriteLine("_________█_________▀▄______█____█_█							");
            Console.WriteLine("______▄█_____________▀▄_____▐___▐_▌							");
            Console.WriteLine("______██_______________▀▄___▐_▄▀▀▀▄							");
            Console.WriteLine("______█________██_______▌__▐▄▀______█							");
            Console.WriteLine("______█_________█_______▌__▐▐________▐							");
            Console.WriteLine("_____▐__________▌_____▄▀▀▀__▌_______▐_____________▄▄▄▄▄▄							");
            Console.WriteLine("______▌__________▀▀▀▀________▀▀▄▄▄▀______▄▄████▓▓▓▓▓▓▓███▄							");
            Console.WriteLine("______▌____________________________▄▀__▄▄█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▄							");
            Console.WriteLine("______▐__________________________▄▀_▄█▓▓▓▓▓▓▓▓▓▓_____▓▓____▓▓█▄							");
            Console.WriteLine("_______▌______________________▄▀_▄█▓▓▓▓▓▓▓▓▓▓▓____▓▓_▓▓_▓▓__▓▓█							");
            Console.WriteLine("_____▄▀▄_________________▄▀▀▌██▓▓▓▓▓▓▓▓▓▓▓▓▓__▓▓▓___▓▓_▓▓__▓▓█							");
            Console.WriteLine("____▌____▀▀▀▄▄▄▄▄▄▄▄▀▀___▌█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓__▓________▓▓___▓▓▓█							");
            Console.WriteLine("_____▀▄_________________▄▀▀▓▓▓▓▓▓▓▓█████████████▄▄_____▓▓__▓▓▓█							");
            Console.WriteLine("_______█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▄▄___▓▓▓▓▓█							");
            Console.WriteLine("_______█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓███▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓█							");
            Console.WriteLine("________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓█▓▓██░░███████░██▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓█							");
            Console.WriteLine("________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓░░░░░█░░░░░██░░░░██▓▓▓▓▓▓▓▓▓██▓▓▓▓▌							");
            Console.WriteLine("________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓███░░░░░░░░____░██░░░░░░░██▓▓▓▓▓▓▓██▓▓▌							");
            Console.WriteLine("________▐▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░░________░░░░░░░░░██████▓▓▓▓▓█▓▌							");
            Console.WriteLine("________▐▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░___▓▓▓▓▓░░░░░░░███░░███▓▓▓▓▓█▓▌							");
            Console.WriteLine("_________█▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░___▓▓█▄▄▓░░░░░░░░___░░░░█▓▓▓▓▓█▓▌							");
            Console.WriteLine("_________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░░█░░░___▓▓██░░░░░░░░▓▓▓▓__░░░░█▓▓▓▓██							");
            Console.WriteLine("_________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░███░░____▓░░░░░░░░░░░█▄█▓__░░░░█▓▓█▓█							");
            Console.WriteLine("_________▐▓▓▓▓▓▓▓▓▓▓▓▓▓█░█████░░░░░░░░░░░░░░░░░█▓__░░░░███▓█							");
            Console.WriteLine("__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░███████░░░░░░░░░░░░░░░▓_░░░░░██▓█							");
            Console.WriteLine("__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░███████░░░░░░░░░░░░░░_░░░░░██▓█							");
            Console.WriteLine("__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░███████░░░░░░░░░░░░░░░░░░░██▓█							");
            Console.WriteLine("___________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░░███████░░░░░░░░░░░█████░██░							");
            Console.WriteLine("___________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░__███████░░░░░███████░░█░░							");
            Console.WriteLine("___________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░█▄▄▄▀▀▀▀████████████░░█░							");
            Console.WriteLine("___________▐▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░██████▄__▀▀░░░███░░░░░█							");
            Console.WriteLine("___________▐▓▓▓▓▓▓▓▓▓▓▓█▒█░░░░░░▓▓▓▓▓███▄░░░░░░░░░░░____________▄▄▄							");
            Console.WriteLine("___________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█░░░░░░▓▓▓▓▓█░░░░░░░░░░░______▄▄▄_▄▀▀____▀▄							");
            Console.WriteLine("__________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█▓▓░░░░░░░░░░░░░░░░░░░░░____▄▀____▀▄_________▀▄							");
            Console.WriteLine("_________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█▓▓▓▓░░░░░░░░░░░░░░░░░______▐▄________█▄▄▀▀▀▄__█							");
            Console.WriteLine("________█▓▓▓▓▓▓▓▓█▒▒▒▒▒▒█▓▓▓▓▓▓▓░░░░░░░░░____________█_█______▐_________▀▄▌							");
            Console.WriteLine("_______█▓▓▓▓▓▓▓▓█▒▒▒▒▒▒███▓▓▓▓▓▓▓▓▓▓▓█▒▒▄___________█__▀▄____█____▄▄▄____▐							");
            Console.WriteLine("______█▓▓▓▓▓▓▓█_______▒▒█▒▒██▓▓▓▓▓▓▓▓▓▓█▒▒▒▄_________█____▀▀█▀▄▀▀▀___▀▀▄▄▐							");
            Console.WriteLine("_____█▓▓▓▓▓██▒_________▒█▒▒▒▒▒███▓▓▓▓▓▓█▒▒▒██________▐_______▀█_____________█							");
            Console.WriteLine("____█▓▓████▒█▒_________▒█▒▒▒▒▒▒▒▒███████▒▒▒▒██_______█_______▐______▄▄▄_____█							");
            Console.WriteLine("__█▒██▒▒▒▒▒▒█▒▒____▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒____▒█▓█__▄█__█______▀▄▄▀▀____▀▀▄▄█							");
            Console.WriteLine("__█▒▒▒▒▒▒▒▒▒▒█▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▓▓█▓▓▌_▐________▐____________▐							");
            Console.WriteLine("__█▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒_______█▓▓▓█▓▌__▌_______▐_____▄▄____▐							");
            Console.WriteLine("_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒_____█▓▓▓█▓▓▌__▌_______▀▄▄▀______▐							");
            Console.WriteLine("_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████▓▓█▓▓▓▌__▀▄_______________▄▀							");
            Console.WriteLine("_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒██▓▓▓▓▓▌___▀▄_________▄▀▀							");
            Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒█▓▓▓▓▓▀▄__▀▄▄█▀▀▀							");
            Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▓▓██▄▄▄▀							");
            Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████							");
            Console.WriteLine("█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▄▄▄▄▄							");
            Console.WriteLine("_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒██▄▄							");
            Console.WriteLine("__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒█▄							");
            Console.WriteLine("__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("___█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▌							");
            Console.WriteLine("____█▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░▒▒▌							");
            Console.WriteLine("____█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████████▒▒▒▒▒█▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒░▒▌							");
            Console.WriteLine("_____█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______▐▒▒▒▒█▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌							");
            Console.WriteLine("______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒█▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌							");
            Console.WriteLine("_______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒█▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌							");
            Console.WriteLine("________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀							");
            Console.WriteLine("__________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒░░░▒▒▒▒▒░░░░░░░░▒▒▒█▀▀▀							");
            Console.WriteLine("___________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░█▀							");
            Console.WriteLine("____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀							");
            Console.WriteLine("_____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒▒▒▒▒▒▒▒▒▒▒▒█▀							");
            Console.WriteLine("_____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______▀▀▀███████▀▀							");
            Console.WriteLine("______________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_______________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("__________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒█							");
            Console.WriteLine("___________________█▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒█							");
            Console.WriteLine("___________________█▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒█							");
            Console.WriteLine("___________________█████████▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█							");
            Console.WriteLine("_____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌							");
            Console.WriteLine("_____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌							");
            Console.WriteLine("______________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▌							");
            Console.WriteLine("_______________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░█							");
            Console.WriteLine("________________________█▒▒▒▒▒▒▒▒▒▒▒░░░█							");
            Console.WriteLine("__________________________██▒▒▒▒▒▒░░░█▀							");
            Console.WriteLine("_____________________________█░░░░░█▀							");
            Console.WriteLine("_______________________________▀▀▀▀							\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Usamos un for para imprimir en pantalla los numeros desde el 1 al 500 
            for (int i = 1; i <= 500; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                // mostramos el valor numerico
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
            }


            // Asignamos una variable que va a ir en incremento hasta llegar al 100 
            int iterador = 50;

            // Usamos un bucle do while para imprimir en pantalla los numeros desde el 50 al 100 
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                // mostramos el valor numerico
                Console.WriteLine(iterador);
                Console.ForegroundColor = ConsoleColor.White;
                // incrementamos la variable iteradora en uno
                iterador += 1;
            }while (iterador <= 100);

            // Asignamos una variable que va a ir en incremento hasta llegar al 0 
            iterador = -50;
            // Usamos un bucle while para imprimir en pantalla los numeros desde el -50 al 0
            while (iterador <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                // mostramos el valor numerico
                Console.WriteLine(iterador);
                Console.ForegroundColor = ConsoleColor.White;
                // incrementamos la variable iteradora en uno
                iterador += 1;
            }

            // Usamos un for para imprimir en pantalla los numeros desde el 1 al 100 pero en intervalos de dos
            for (int i = 0; i <= 100; i += 2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                // mostramos el valor numerico
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
