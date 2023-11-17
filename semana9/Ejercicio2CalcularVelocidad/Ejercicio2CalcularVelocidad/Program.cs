using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2CalcularVelocidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));

            Console.WriteLine("\nCalcular velocidad\n");

            // pedimos al usuario los datos necesarios
            Console.WriteLine("Ingrese una distancia");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese los segundos");
            double segundos = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese los minutos");
            double minutos = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese las horas");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // calculamos el tiempo exacto
            double tiempo = horas + minutos / 60 + segundos / 3600;
            
            // aplicamos las formulas correspondientes para calcular la velocidad en metros por segundo
            double velocidadMetrosPorSegundo = (distancia / tiempo);
            // aplicamos las formulas correspondientes para calcular la velocidad en kilometros por hora
            double velocidadKilometrosPorHora = ((distancia / 1000) / (tiempo / 3600));
            // aplicamos las formulas correspondientes para calcular la velocidad en millas por hora
            double velocidadMillasPorHora = (distancia / 1609) / (tiempo / 3600);

            Console.ForegroundColor = cc[12];
            // mostramos los resultados
            Console.WriteLine($"\n[+] La velocidad en m/s es: {velocidadMetrosPorSegundo}m/s");
            Console.WriteLine($"\n[+] La velocidad en k/h es: {velocidadKilometrosPorHora}k/h");
            Console.WriteLine($"\n[+] La velocidad en mph es: {velocidadMillasPorHora}mph");
            Console.ReadKey();  
        }
    }
}
