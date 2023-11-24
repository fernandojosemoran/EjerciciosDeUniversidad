using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Acertar número, el programa elegirá al azar un numero entre 0 y 10 cuando lo 
tenga pedirá al usuario valores a irá dándole pistas (el número es mayor o es 
menor que el objetivo) hasta que, o bien el usuario acerte o se aburra, para lo que 
le preguntemos si quiere volver a intentarlo cada vez que falle. 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio6
    {
        public static void EjercicioSeis()
        {
            Console.Title = "Adivinar numero";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n▒▒▒▒▒▒▒▓        ");
            Console.WriteLine("▒▒▒▒▒▒▒▓▓▓        ");
            Console.WriteLine("▒▓▓▓▓▓▓░░░▓       ");
            Console.WriteLine("▒▓░░░░▓░░░░▓      ");
            Console.WriteLine("▓░░░░░░▓░▓░▓      ");
            Console.WriteLine("▓░░░░░░▓░░░▓      ");
            Console.WriteLine("▓░░▓░░░▓▓▓▓       ");
            Console.WriteLine("▒▓░░░░▓▒▒▒▒▓      ");
            Console.WriteLine("▒▒▓▓▓▓▒▒▒▒▒▓      ");
            Console.WriteLine("▒▒▒▒▒▒▒▒▓▓▓▓      ");
            Console.WriteLine("▒▒▒▒▒▓▓▓▒▒▒▒▓     ");
            Console.WriteLine("▒▒▒▒▓▒▒▒▒▒▒▒▒▓    ");
            Console.WriteLine("▒▒▒▓▒▒▒▒▒▒▒▒▒▓    ");
            Console.WriteLine("▒▒▓▒▒▒▒▒▒▒▒▒▒▒▓   ");
            Console.WriteLine("▒▓▒▓▒▒▒▒▒▒▒▒▒▓    ");
            Console.WriteLine("▒▓▒▓▓▓▓▓▓▓▓▓▓     ");
            Console.WriteLine("▒▓▒▒▒▒▒▒▒▓        ");
            Console.WriteLine("▒▒▓▒▒▒▒▒▓       \n");
            Console.ForegroundColor = ConsoleColor.White;

            // intanciamos la clase Random para tener un numero aleatorio.
            Random random = new Random();
            // almacenamos el numero aleatorio en una variable y obtenemos el numero aleatorio llamando el metodo Next
            int numeroAleatorio = random.Next(10 + 1);
           
            // creamos un bucle poder pedir al usuario el numero a divinar
            for (; ; )
            {
                // indicamos al usuario que nos de un numero del 1 al 10
                Console.Write("Introduce un numero entre [1:10]: ");
                // convertimos el dato dado por el usuario en numero
                int numero = int.Parse(Console.ReadLine());

                // verificamos si el usuario logro adivinar el numero aleatorio
                if (numero == numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    // mostramos un mensaje de victoria si logro adivinarlo
                    Console.WriteLine("[+] Felicidades adivinaste el numero");
                    Console.ForegroundColor = ConsoleColor.White;
                    // y salimos del bucle
                    break;
                }else
                {
                    // si el usuario no adivino el numero, le indicamos que se equivoco y que lo siga intentando
                    Console.ForegroundColor = ConsoleColor.Red;
                    // mostramos el mensaje
                    Console.Write("[-] Vuelve a intentar ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.ReadKey();
        }
    }
}
