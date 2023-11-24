using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cree un programa en C# que use el operador condicional ternario para asignar
valor a una variable boolean . Deberás asignar verdadero si dos números
ingresados por el usuario (x, y) son pares y falso si alguno de ellos es impar.
Para finalizar muestra el valor de la variable por pantalla.
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio1
    {
        public static void EjercicioUno()
        {
            Console.Title = "Verificar si dos numeros son pares";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n▒▒▒▒▒▒▒▒▒▒▒▄▄▄▄░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒▒▒▒▄██▀░░▀██▄▒▒▒▒████████▄▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒▒▒███░░░░░░██▒▒▒▒▒▒█▀▀▀▀▀██▄▄▒▒▒ ");
            Console.WriteLine("▒▒▒▒▒▄██▌░░░░░░░██▒▒▒▒▐▌▒▒▒▒▒▒▒▒▀█▄▒ ");
            Console.WriteLine("▒▒▒▒▒███░░▐█░█▌░██▒▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▀▌ ");
            Console.WriteLine("▒▒▒▒████░▐█▌░▐█▌██▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▐████░▐░░░░░▌██▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒████░░░▄█░░░██▒▒▐█▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒████░░░██░░██▌▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒████▌░▐█░░███▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒▐████░░▌░███▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒▒▒████░░░███▒▒▒▒█▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▒▒██████▌░████▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒▐████████████▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("▒█████████████▄████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("██████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("██████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("█████████████████▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("█████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ");
            Console.WriteLine("████████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            // pedimos un numero al usuario
            Console.WriteLine("Ingrese el primer numero");
            // convertimos el texto a un numero
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // pedimos segundo numero al usuario
            Console.WriteLine("Ingrese el segundo numero");
            // convertimos el texto a un numero
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // sacamos el residuo de los dos numeros
            int residuo1 = (numero1 % 2);
            int residuo2 = (numero2 % 2);

            // verificamos si son pares
            bool SonPares = (residuo1 == 0 && residuo2 == 0) ? true : false;
  
            // obtenemos un texto acorde si son pares o impares
            string sonParesText = (residuo1 == 0 && residuo2 == 0) ? "son pares" : "son impares";

            Console.ForegroundColor = ConsoleColor.Red;
            // mostramos en pantalla los resultados 
            Console.WriteLine("\nlos numeros {0}: {1}", sonParesText , SonPares);
            Console.ReadKey();
        }
    }
}
