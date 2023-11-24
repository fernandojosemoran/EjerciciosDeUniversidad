using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Realiza un programa en C#, que muestre un menú en pantalla con las opciones:

1) Sumar
2) Restar
3) Multiplicar
4) Dividir
5) Salir

El usuario debe seleccionar una opción. y a continuación, el programa deber 
solicitar el ingreso de 2 números enteros. Una vez ingresados los números, se 
deberá evaluar con un switch, realizando la operación correspondiente a la 
opción seleccionada.
La ejecución debe realizarse una y otra vez, hasta que el usuario seleccione la 
opción # 5. 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio7
    {
        public static void EjercicioSiete()
        {
            Console.Title = "Calculadora aritmetica";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n─────────────────────────────────       ");
            Console.WriteLine("───────────────▄████████▄────────         ");
            Console.WriteLine("─────────────▄█▀▒▒▒▒▒▒▒▀██▄──────         ");
            Console.WriteLine("───────────▄█▀▒▒▒▒▒▒▒▒▒▒▒██──────         ");
            Console.WriteLine("─────────▄█▀▒▒▒▒▒▒▄▒▒▒▒▒▒▐█▌─────         ");
            Console.WriteLine("────────▄█▒▒▒▒▒▒▒▒▀█▒▒▒▒▒▐█▌─────         ");
            Console.WriteLine("───────▄█▒▒▒▒▒▒▒▒▒▒▀█▒▒▒▄██──────         ");
            Console.WriteLine("──────▄█▒▒▒▒▒▒▒▒▒▒▒▒▀█▒▄█▀█▄─────         ");
            Console.WriteLine("─────▄█▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▀▒▒▒█▄────         ");
            Console.WriteLine("────▄█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▄───         ");
            Console.WriteLine("───▄█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▄──         ");
            Console.WriteLine("──▄█▒▒▒▄██████▄▒▒▒▒▄█████▄▒▒▒▒█──         ");
            Console.WriteLine("──█▒▒▒█▀░░░░░▀█─▒▒▒█▀░░░░▀█▒▒▒█──         ");
            Console.WriteLine("──█▒▒▒█░░▄░░░░▀████▀░░░▄░░█▒▒▒█──         ");
            Console.WriteLine("▄███▄▒█▄░▐▀▄░░░░░░░░░▄▀▌░▄█▒▒███▄         ");
            Console.WriteLine("█▀░░█▄▒█░▐▐▀▀▄▄▄─▄▄▄▀▀▌▌░█▒▒█░░▀█         ");
            Console.WriteLine("█░░░░█▒█░▐▐──▄▄─█─▄▄──▌▌░█▒█░░░░█         ");
            Console.WriteLine("█░▄░░█▒█░▐▐▄─▀▀─█─▀▀─▄▌▌░█▒█░░▄░█         ");
            Console.WriteLine("█░░█░█▒█░░▌▄█▄▄▀─▀▄▄█▄▐░░█▒█░█░░█         ");
            Console.WriteLine("█▄░█████████▀░░▀▄▀░░▀█████████░▄█         ");
            Console.WriteLine("─██▀░░▄▀░░▀░░▀▄░░░▄▀░░▀░░▀▄░░▀██          ");
            Console.WriteLine("██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██         ");
            Console.WriteLine("█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█         ");
            Console.WriteLine("█░▄░░░░░░░░░░░░░░░░░░░░░░░░░░░▄░█         ");
            Console.WriteLine("█░▀█▄░░░░░░░░░░░░░░░░░░░░░░░▄█▀░█         ");
            Console.WriteLine("█░░█▀███████████████████████▀█░░█         ");
            Console.WriteLine("█░░█────█───█───█───█───█────█░░█         ");
            Console.WriteLine("█░░▀█───█───█───█───█───█───█▀░░█         ");
            Console.WriteLine("█░░░▀█▄▄█▄▄▄█▄▄▄█▄▄▄█▄▄▄█▄▄█▀░░░█         ");
            Console.WriteLine("▀█░░░█──█───█───█───█───█──█░░░█▀         ");
            Console.WriteLine("─▀█░░▀█▄█───█───█───█───█▄█▀░░█▀─         ");
            Console.WriteLine("──▀█░░░▀▀█▄▄█───█───█▄▄█▀▀░░░█▀──         ");
            Console.WriteLine("───▀█░░░░░▀▀█████████▀▀░░░░░█▀───         ");
            Console.WriteLine("────▀█░░░░░▄░░░░░░░░░▄░░░░░█▀────         ");
            Console.WriteLine("─────▀██▄░░░▀▀▀▀▀▀▀▀▀░░░▄██▀─────         ");
            Console.WriteLine("────────▀██▄▄░░░░░░░▄▄██▀────────         ");
            Console.WriteLine("───────────▀▀███████▀▀───────────       \n");
            Console.ForegroundColor = ConsoleColor.White;
            
            // asignamos un metodo que muestre las opciones aritmeticas
            void MostrarOpciones()
            {
                Console.WriteLine("Escoja una opcion aritmetica\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+----+-------------+");
                Console.WriteLine("| ID | Operacion   |");
                Console.WriteLine("+----+-------------+");
                Console.WriteLine("| 1  | Sumar       |");
                Console.WriteLine("| 2  | Restar      |");
                Console.WriteLine("| 3  | Multiplicar |");
                Console.WriteLine("| 4  | Dividir     |");
                Console.WriteLine("| 5  | Salir       |");
                Console.WriteLine("| 6  | limpiar cmd |");
                Console.WriteLine("+----+-------------+");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
            }

            // llamamos el metodo para mostrar las opciones aritmeticas en pantalla
            MostrarOpciones();

            // creamos un bucle para tener control de ciertas operaciones
            for (; ; ) {
                // pedimos al usuario dar un indice correcto
                Console.Write("\n[?] Indice: ");
                // convertimos el valor dado por el usuario en un numero entero
                int indiceAritmetico = int.Parse(Console.ReadLine());

                // creamos un bucle while para controlar la opcion de limpiar la consola y no perder la tabla de las opciones aritmeticas
                while (true)
                {
                    // verificamos si el numero es 6
                    if (indiceAritmetico == 6)
                    {
                        // si el numero es 6 limpiamos la terminal
                        Console.Clear();
                        // despues mostramos una vez mas la tabla de las opciones aritmeticas
                        MostrarOpciones();
                        // y volvemos a pedir un indice valido
                        Console.Write("\n[?] Indice: ");
                        // convertimos el valor dado por el usuario en un numero entero
                        indiceAritmetico = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        // si el indice no es 6 salimos del bucle 
                        break;
                    }
                }

                // verificamos si el indice es 5
                if (indiceAritmetico == 5)
                {
                    // si es 5 damos un mensaje de despedida
                    Console.WriteLine("[+] BYE");
                    // despues terminamos la ejecucion del programa
                    Environment.Exit(0);
                }

                // despues de controlar los valores 6 y 5 del indice, mostrmos los mensaje pidiendo los dos numeros a operar 
                Console.Write("\n[?] Ingrese el primero valor a operar: ");
                // convertimos el valor dado por el usuario en un numero entero
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // pedimos el segundo numero al usuario
                Console.Write("\n[?] Ingrese el segundo valor a operar: ");
                // convertimos el valor dado por el usuario en un numero entero
                double numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // usamos la estructura de control switch para verificar el indice de cada operacion aritmetica
                switch (indiceAritmetico)
                {
                    case 1: // si el indice es 1 entonces.
                        Console.ForegroundColor = ConsoleColor.Green;
                        // monstramos un mensaje con la operacion arimetica correspondiente
                        Console.WriteLine($"[+] La suma de los valores ingresados es: {numero1 + numero2}");
                        Console.ForegroundColor = ConsoleColor.White;
                        // acabamos con la verificacion de valores
                        break;
                    case 2: // si el indice es 2 entonces.
                        Console.ForegroundColor = ConsoleColor.Green;
                        // monstramos un mensaje con la operacion arimetica correspondiente
                        Console.WriteLine($"[+] La resta de los valores ingresados es: {numero1 - numero2}");
                        Console.ForegroundColor = ConsoleColor.White;
                        // acabamos con la verificacion de valores
                        break;
                    case 3: // si el indice es 3 entonces.
                        Console.ForegroundColor = ConsoleColor.Green;
                        // monstramos un mensaje con la operacion arimetica correspondiente
                        Console.WriteLine($"[+] La multiplicacion de los valores ingresados es: {numero1 * numero2}");
                        Console.ForegroundColor = ConsoleColor.White;
                        // acabamos con la verificacion de valores
                        break;
                    case 4: // si el indice es 4 entonces.
                        Console.ForegroundColor = ConsoleColor.Green;
                        // monstramos un mensaje con la operacion arimetica correspondiente
                        Console.WriteLine($"[+] La divicion de los valores ingresados es: {numero1 / numero2}");
                        Console.ForegroundColor = ConsoleColor.White;
                        // acabamos con la verificacion de valores
                        break;
                }
            }
        }
    }
}
