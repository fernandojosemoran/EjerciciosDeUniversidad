using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Solicitar ingresar un numero a través de la consola y Mostrar los números del 1 
    hasta el número ingresado.
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio4
    {
        public static void EjercicioCuatro()
        {
            Console.Title = "Imprimir de 1 al numero dado";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n________________________________________________¶¶_¶¶¶¶¶¶¶¶¶ ");
            Console.WriteLine("______________________________________________¶¶¶¶________¶¶   ");
            Console.WriteLine("____________________________________________¶¶_¶¶¶_______¶¶    ");
            Console.WriteLine("_____¶¶¶¶¶¶¶¶_____¶¶___¶¶¶¶_______________¶¶___¶¶______¶¶      ");
            Console.WriteLine("___¶¶¶______¶¶¶__¶¶¶__¶¶________________¶¶____¶¶¶_____¶¶       ");
            Console.WriteLine("____________¶¶¶__¶¶_¶¶¶_______________¶¶______¶¶_____¶¶        ");
            Console.WriteLine("___¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶____¶¶¶¶¶¶¶¶¶__¶¶_______¶¶¶_____¶¶        ");
            Console.WriteLine("_¶¶¶¶______¶¶¶__¶¶_¶¶¶___¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶         ");
            Console.WriteLine("¶¶¶_______¶¶¶__¶¶¶__¶¶¶_____________________¶¶¶_____¶¶         ");
            Console.WriteLine("¶¶¶¶____¶¶¶¶¶__¶¶____¶¶¶____________________¶¶_____¶¶          ");
            Console.WriteLine("_¶¶¶¶¶¶¶¶_¶¶¶__¶¶_____¶¶____________________¶¶_____¶¶          ");
            Console.WriteLine("______________________________________________________¶¶__     "); 
            Console.WriteLine("________________________________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶     ");
            Console.WriteLine("_______________________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__     ");
            Console.WriteLine("________________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_____________     ");
            Console.WriteLine("__________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________________     ");
            Console.WriteLine("_________________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶______________________     ");
            Console.WriteLine("¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_________________________     ");
            Console.WriteLine("¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_¶_¶¶¶¶¶¶¶¶_________________________     ");
            Console.WriteLine("¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶___¶__¶¶¶¶¶¶________________________     ");
            Console.WriteLine("_¶¶¶¶¶¶¶¶¶¶¶¶____¶¶¶¶¶¶¶¶¶___¶¶¶¶¶¶_______________________     ");
            Console.WriteLine("__¶¶¶¶¶¶¶¶¶______¶¶¶¶¶_______¶¶¶¶¶¶¶______________________     ");
            Console.WriteLine("___¶¶¶¶¶¶________¶¶¶¶¶_________¶¶¶¶¶¶¶____________________     ");
            Console.WriteLine("____¶¶¶¶_________¶¶¶¶¶__________¶¶¶¶¶¶¶¶__________________   \n");
            Console.ForegroundColor = ConsoleColor.White;

            // le pedimos al usuario que inserte un numero entero
            Console.Write("Ingrese un numero: ");
            // convertimos el dato dado por el usuario en numero, ademas lo redondemos en caso de ser decimal
            double numero = Math.Round(double.Parse(Console.ReadLine()));

            // usamos un for para recorrer los numeros del 1 al numero dado por el usuario
            for (int i = 1; i <= numero; i++)
            {
                // mostramos en pantalla todos los numeros
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();  
        }
    }
}
