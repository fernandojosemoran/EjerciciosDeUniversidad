using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Cuanto hay que pagar por una llamada telefónica, si los tres 3 primeros minutos se pagan a $0.10 y si el tiempo de la llamada es superior a diez minutos se descontara el 20% de la llamada. El pago normal después de los 3 minutos es de $0.15. 
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio7
    {
        static public void EjercicioSiete()
        {
            Console.Title = "Obtener cobro por tiempo de llamada";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                   .-'`     '.                      			");
            Console.WriteLine("                 __/  __       \\                     		    ");
            Console.WriteLine("                /  \\ /  \\       |    ___                       ");
            Console.WriteLine("               | /`\\| /`\\|      | .-'  /^\\/^\\                ");
            Console.WriteLine("               | \\(/| \\(/|      |/     |) |)|                  ");
            Console.WriteLine("              .-\\__/ \\__/       |      \\_/\\_/__..._          ");
            Console.WriteLine("      _...---'-.                /   _              '.            ");
            Console.WriteLine("     /,      ,             \\   '|  `\\                \\        ");
            Console.WriteLine("    | ))     ))           /`|   \\    `.       /)  /) |          ");
            Console.WriteLine("    | `      `          .'       |     `-._         /            ");
            Console.WriteLine("    \\                 .'         |     ,_  `--....-'            ");
            Console.WriteLine("     `.           __.' ,         |     / /`'''`                  ");
            Console.WriteLine("       `'-.____.-' /  /,         |    / /                     	");
            Console.WriteLine("           `. `-.-` .'  \\        /   / |                      	");
            Console.WriteLine("             `-.__.'|    \\      |   |  |-.                     	");
            Console.WriteLine("                _.._|     |     /   |  |  `'.                    ");
            Console.WriteLine("          .-''``    |     |     |   /  |     `-.                 ");
            Console.WriteLine("       .'`         /      /     /  |   |        '.               ");
            Console.WriteLine("     /`           /      /     |   /   |\\         \\            ");
            Console.WriteLine("    /            |      |      |   |   /\\          |            ");
            Console.WriteLine("   ||            |      /      |   /     '.        |             ");
            Console.WriteLine("   |\\            \\      |      /   |       '.      /           ");
            Console.WriteLine("   \\ `.           '.    /      |    \\        '---'/            ");
            Console.WriteLine("    \\  '.           `-./        \\    '.          /             ");
            Console.WriteLine("     '.  `'.            `-._     '.__  '-._____.'--'''''--.      ");
            Console.WriteLine("       '-.  `'--._          `.__     `';----`              \\    ");
            Console.WriteLine("          `-.     `-.          `.''```                     ;     ");
            Console.WriteLine("             `'-..,_ `-.         `'-.                     /      ");
            Console.WriteLine("        	         '.  '.           '.                 .'       \n");

            Console.ForegroundColor = ConsoleColor.Gray;
            // le pedimos al usuario que ingrese un tiempo
            Console.Write("\nIngrese la duración de la llamada en minutos: ");
            int duracionLlamada = int.Parse(Console.ReadLine());

            // inicializamos las variables correspondientes
            const double costo1 = 0.10;
            const double costo2 = 0.15;
            const double descuentoPorcentaje = 0.20;

            double costoTotal = 0;

            if (duracionLlamada <= 3)
            {
                // aplicamos el cobro del 10% a los 3 primeros minutos
                costoTotal = duracionLlamada * costo1;
            }

            // hacemos la logica para aplicar el descuento del 20% y aplicar un cobro del 15% adicional.
            if (duracionLlamada > 10)
            {
                // Aplicar descuento del 20% para llamadas de más de 10 minutos
                costoTotal = (3 * costo1) + (duracionLlamada * costo2) * (1 - descuentoPorcentaje);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            // mostramos los datos.
            Console.WriteLine($"\nEl costo total de la llamada es: ${costoTotal:F2}");
        }
    }
}
