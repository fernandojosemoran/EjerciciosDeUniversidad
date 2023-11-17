using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Obtener el cuadrado de un número ingresado por teclado y si el resultado es mayor a 5000 entonces imprimir resultado fuera de rango.
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio6
    {
        static public void EjercicioSeix()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                  .-'''..-'''-.		");
            Console.WriteLine("                  | /`\\(/`\\  |		    ");
            Console.WriteLine("          __...--'  Q_/ Q_/  /		    ");
            Console.WriteLine("      .-'`.                  < '         ");
            Console.WriteLine("      '-._ '          ._,    `\\		    ");
            Console.WriteLine("          `T''-- - ...-'/      .-;		");
            Console.WriteLine("          /          /      /   |		");
            Console.WriteLine("       .-;--.     _.'       \\   |		");
            Console.WriteLine("      ( /    )_.-'           '--|		");
            Console.WriteLine("      `;-..-'`          .-.     /		");
            Console.WriteLine("        '-._           (   )    \\		");
            Console.WriteLine("       ..__ `';--       '-'    .-;		");
            Console.WriteLine("     .'    `' -| (  | '');       |       ");
            Console.WriteLine("    / /.''''-..|_   /         _'-|		");
            Console.WriteLine("    \\ /         `'`         (_)  |      ");
            Console.WriteLine("     | | | /-._    _.'           |		");
            Console.WriteLine("     \\_\\ \\_\\  \\`''`              |	");
            Console.WriteLine("        \\_\\    \\                 ;	");
            Console.WriteLine("            _.-''.              /		");
            Console.WriteLine("         .-'      '-./        .'         ");
            Console.WriteLine("        |     _..--'/       .'		    ");
            Console.WriteLine("        `\\  -;     /      .'		    ");
            Console.WriteLine("          \\  \\    /     .'			    ");
            Console.WriteLine("           \\  \\  /    .'			    ");
            Console.WriteLine("            \\  \\/   _;				    ");
            Console.WriteLine("             \\ `\\    `-._			    ");
            Console.WriteLine("             ;  |'=.      `'.			");
            Console.WriteLine("         	 7  L  `'-._   `.		    ");
            Console.WriteLine("            /,  |       `-.  '.		    ");
            Console.WriteLine("        __.'.' \\;          `-. '-.	    ");
            Console.WriteLine("       `'.   /   \\            /`  `\\   ");
            Console.WriteLine("          \\   .--.>         .'  /  |    ");
            Console.WriteLine("          /_.'          _.-' -'  \\ |    ");
            Console.WriteLine("          `            `-.   /     /	    ");
            Console.WriteLine("                         )   _.._|	    ");
            Console.WriteLine("                         /_.-'`   `	  \n");
            

            Console.ForegroundColor = ConsoleColor.Gray;
            // le pedimos al usuario un numero
            Console.WriteLine("Ingrese un numero");
            // convertimos el numero a un numero
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // vamos a elevar por 2 el numero dado.
            double cuadradoDeUnNumero = Math.Pow(numero, 2);

            Console.ForegroundColor = ConsoleColor.Blue;
            // verificamos el el valor dado por elevar el numero dado supera el valor de 5000
            if (cuadradoDeUnNumero > 5000)
            {
                // si el valor supera los 5000 mostramos el mensaje con el valor.
                Console.WriteLine("Resultado fuera de rango: [{0}]", cuadradoDeUnNumero);
            }

            Console.ReadKey();
        }
    }
}
