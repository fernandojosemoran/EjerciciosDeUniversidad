using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Desarrolla una aplicación que permita a los usuarios ingresar sus gastos diarios y luego calcule 
    el gasto promedio en una semana. Utiliza un diccionario para almacenar los gastos diarios. Al 
    final mostrar en consola el gasto diario y el total del gasto.
*/

namespace Diccionarios
{
    internal class GastosDiarios
    {
        public static void MainGastosDiarios()
        {
            Console.Title = "Gastos diarios";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 ___      ___       __       ___  ___        _______     __       ___  ___  _____  ___    _______  
|""  \    /""  |     /""""\     |""  \/""  |      |   __ ""\   /""""\     |""  \/""  |(\""   \|""  \  /""     ""| 
 \   \  //   |    /    \     \   \  /       (. |__) :) /    \     \   \  / |.\\   \    |(: ______) 
 /\\  \/.    |   /' /\  \     \\  \/        |:  ____/ /' /\  \     \\  \/  |: \.   \\  | \/    |   
|: \.        |  //  __'  \    /\.  \        (|  /    //  __'  \    /   /   |.  \    \. | // ___)_  
|.  \    /:  | /   /  \\  \  /  \   \      /|__/ \  /   /  \\  \  /   /    |    \    \ |(:      ""| 
|___|\__/|___|(___/    \___)|___/\___|    (_______)(___/    \___)|___/      \___|\____\) \_______) 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Dictionary<int, double> gastosDiarios = new Dictionary<int, double>();
            double totalGasto = 0;

            for (int dia = 1; dia <= 7; dia++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n[!] Ingrese el gasto para el día {dia}: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                double gastoDiario;
                while (!double.TryParse(Console.ReadLine(), out gastoDiario) || gastoDiario < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Cantidad no válida. Por favor, ingrese un número positivo.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\n[!] Ingrese el gasto para el día {dia}: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                gastosDiarios[dia] = gastoDiario;
                totalGasto += gastoDiario;
            }

            double gastoPromedio = totalGasto / 7;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[!] Gastos diarios:");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in gastosDiarios)
            {
                Console.WriteLine($"\nDía {item.Key}: ${item.Value}");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Gasto semana: (${totalGasto}),\tPromedio semana (${gastoPromedio})");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
