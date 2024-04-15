using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    En una gasolinera hay 4 surtidores de combustible, Realizar un programa haciendo uso de 
    diccionario para los surtidores y otro para el tipo de combustible a vender y la cantidad de 
    litros. Los surtidores de la misma registran lo que surten en galones, pero el precio de la 
    gasolina está fijado en litros. El programa debe calcular e imprimir lo que hay que cobrarle 
    al cliente. Al final del día el programa debe arrojar cuantos clientes hubo y la suma 
    acumulada por cada uno de los surtidores.
    Mediante un menú el usuario elegirá si venderá del surtidor 1, 2, 3 o 4
    Considere que cada galón de gasolina tiene 3.785 litros y el precio de gasolina Regular es 
    L.24.20 y la premium es de L.27.00
*/

namespace Diccionarios
{
    internal class Gasolinera
    {
        public static void MainGasolinera()
        {
            Console.Title = "Gasolinera";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                 ███▄    █  ▒█████       ▄████  ▄▄▄       ███▄ ▄███▓▓█████   ██████ 
 ██ ▀█   █ ▒██▒  ██▒    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ ▒██    ▒ 
▓██  ▀█ ██▒▒██░  ██▒   ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   ░ ▓██▄   
▓██▒  ▐▌██▒▒██   ██░   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄   ▒   ██▒
▒██░   ▓██░░ ████▓▒░   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒▒██████▒▒
░ ▒░   ▒ ▒ ░ ▒░▒░▒░     ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░
░ ░░   ░ ▒░  ░ ▒ ▒░      ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░░ ░▒  ░ ░
   ░   ░ ░ ░ ░ ░ ▒     ░ ░   ░   ░   ▒   ░      ░      ░   ░  ░  ░  
         ░     ░ ░           ░       ░  ░       ░      ░  ░      ░  
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Dictionary<int, double> surtidores = new Dictionary<int, double>();
            surtidores[1] = 0; 
            surtidores[2] = 0; 
            surtidores[3] = 0; 
            surtidores[4] = 0; 

            
            Dictionary<string, double> ventas = new Dictionary<string, double>();

            int clientesTotales = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenú:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Vender del surtidor 1");
                Console.WriteLine("2. Vender del surtidor 2");
                Console.WriteLine("3. Vender del surtidor 3");
                Console.WriteLine("4. Vender del surtidor 4");
                Console.WriteLine("5. Mostrar total de clientes y ventas por surtidor");
                Console.WriteLine("6. Salir");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Seleccione una opción: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Opción no válida. Por favor, ingrese un número del 1 al 6.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }

                if (opcion == 6)
                {
                    break;
                }

                if (opcion >= 1 && opcion <= 4)
                {
                    Vender(surtidores, ventas, opcion);
                    clientesTotales++;
                }
                else if (opcion == 5)
                {
                    MostrarVentasPorSurtidor(surtidores);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n[+] Total de clientes: {clientesTotales}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Opción no válida. Por favor, ingrese un número del 1 al 6.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        static void Vender(Dictionary<int, double> surtidores, Dictionary<string, double> ventas, int surtidor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Venta del surtidor {surtidor}:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Tipo de combustible (regular o premium): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string tipoCombustible = Console.ReadLine();

            if (tipoCombustible.ToLower() != "regular" && tipoCombustible.ToLower() != "premium")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[x] Tipo de combustible no válido. La venta no se ha realizado.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Cantidad de galones: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            double galones;
            while (!double.TryParse(Console.ReadLine(), out galones) || galones <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[x] Cantidad no válida. Por favor, ingrese un número positivo.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Cantidad de galones: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            // Convertir galones a litros
            double litros = galones * 3.785; 

            // Actualizar la cantidad de litros vendidos por tipo de combustible
            if (ventas.ContainsKey(tipoCombustible))
            {
                ventas[tipoCombustible] += litros;
            }
            else
            {
                ventas[tipoCombustible] = litros;
            }

            // Calcular el monto a cobrar al cliente
            double monto = 0;
            if (tipoCombustible.ToLower() == "regular")
            {
                monto = litros * 24.20;
            }
            else
            {
                monto = litros * 27.00;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Se vendieron {litros} litros de {tipoCombustible} por L.{monto}");
            Console.ForegroundColor = ConsoleColor.Gray;

            // Actualizar la cantidad de litros vendidos por surtidor
            surtidores[surtidor] += monto;
        }

        static void MostrarVentasPorSurtidor(Dictionary<int, double> surtidores)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[!] Ventas por surtidor:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var kvp in surtidores)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n[+] Surtidor {kvp.Key}: L.{kvp.Value}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
