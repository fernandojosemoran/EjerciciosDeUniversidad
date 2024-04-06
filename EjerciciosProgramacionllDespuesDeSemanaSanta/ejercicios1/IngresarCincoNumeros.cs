using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    public class IngresarCincoNumeros
    {
        public static void MainIngresarCincoNumeros()
        {
            Console.Title = "\nIngresar 5 numeros";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                ╦ ╦╔╦╗╔╦╗╦    ╦╔═╗  ╔╗╔╔═╗╔╦╗  ╔═╗  ╔═╗╔═╗╔╦╗╔═╗  ╦  ╔═╗╔╗╔╔═╗╦ ╦╔═╗ ╦╔═╗
                ╠═╣ ║ ║║║║    ║╚═╗  ║║║║ ║ ║   ╠═╣  ║  ║ ║ ║║║╣   ║  ║╣ ║║║║ ╦║ ║╠═╣ ║║╣ 
                ╩ ╩ ╩ ╩ ╩╩═╝  ╩╚═╝  ╝╚╝╚═╝ ╩   ╩ ╩  ╚═╝╚═╝═╩╝╚═╝  ╩═╝╚═╝╝╚╝╚═╝╚═╝╩ ╩╚╝╚═╝
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            List<int> list = new List<int>();
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("\nIngresa un numero\n");
                int numero = int.Parse(Console.ReadLine());

                list.Add(numero);
            }

            Console.WriteLine("\nLos numeros ingresados son: \n");

            Console.ForegroundColor= ConsoleColor.Red;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
