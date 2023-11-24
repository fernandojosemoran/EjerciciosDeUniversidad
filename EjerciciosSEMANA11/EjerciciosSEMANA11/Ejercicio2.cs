using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escriba un programa de inicio de sesion en C# que solicite al usuario el nombre 
de usuario y la contraseña. Ambos deben ser números enteros y repetirlo hasta 
que el inicio de sesión sea 12 y la contraseña sea 4321 o hasta un máximo de 3 
intentos.
Si el usuario y la contraseña son correctos muestra Inicio de sesión correcto, sino 
Error de inicio de sesión. 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio2
    {
        public static void EjercicioDos()
        {
            Console.Title = "Inicio de sesion en frakinMania";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n────────▄▄▄▄▄▄▄▄▄ 	     ");
            Console.WriteLine("────────▌▐░▀░▀░▀▐ 	     ");
            Console.WriteLine("────────▌░▌░░░░░▐ 	     ");
            Console.WriteLine("────────▌░░░░░░░▐ 	     ");
            Console.WriteLine("────────▄▄▄▄▄▄▄▄▄ 	     ");
            Console.WriteLine("──▄▀▀▀▀▀▌▄█▄░▄█▄▐▀▀▀▀▀▄   ");
            Console.WriteLine("─█▒▒▒▒▒▐░░░░▄░░░░▌▒▒▒▒▒█  ");
            Console.WriteLine("▐▒▒▒▒▒▒▒▌░░░░░░░▐▒▒▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒▒▒█░▀▀▀▀▀░█▒▒▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒▒▒▒█▄▄▄▄▄█▒▒▒▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▐▒▒▒▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒▐▒▒▒▒▒▒▒▒▒▒▒▌▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒▒▌▒▒▒▒▒▒▒▒▒▐▒▒▒▒▒▒▌ ");
            Console.WriteLine("▐▒▒▒▒▒▒▌▄▄▄▄▄▄▄▄▄▐▒▒▒▒▒▒▌ ");
            Console.WriteLine("▐▄▄▄▄▄▄▌▌███████▌▐▄▄▄▄▄▄▌ ");
            Console.WriteLine("─█▀▀▀▀█─▌███▌███▌─█▀▀▀▀█  ");
            Console.WriteLine("─▐░░░░▌─▌███▌███▌─▐░░░░▌  ");
            Console.WriteLine("──▀▀▀▀──▌███▌███▌──▀▀▀▀   ");
            Console.WriteLine("────────▌███▌███▌ 	     ");
            Console.WriteLine("────────▌███▌███▌ 	     ");
            Console.WriteLine("──────▐▀▀▀██▌█▀▀▀▌ 	     ");
            Console.WriteLine("______▐▄▄▄▄▄▄▄▄▄▄▌ 	   \n");
            Console.ForegroundColor = ConsoleColor.White;

            // indicamos al usuario que ingrese su usuario de sesion y contrasena
            Console.WriteLine("Ingrese los siguites datos\n");

            // le mostramos una referencia decorativa
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("| Usuario    | Contraseña |");
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("| user1      |  #######   |");
            Console.WriteLine("| user2      |  #######   |");
            Console.WriteLine("| user3      |  #######   |");
            Console.WriteLine("|-------------------------|\n");
            Console.ForegroundColor = ConsoleColor.White;

            // asignamos una variable iteradora para manejar las veces que el usuario intenta iniciar sesion la cual empieze valiendo 3 ya que son los intentos maximos
            int iteradorIntentos = 3;

            // creamos un bucle
            for (; ; )
            {
                // verificamos el la variable iteradora que cuenta los intentos a la hora de iniciar seccion
                if (iteradorIntentos == 0)
                {
                    // si al usuario se le acaba los intentos mostramos el siguiente mensaje
                    Console.WriteLine("\n[-] Intentos permitidos realizados, intento mas tarde.");
                    // terminamos el bucle
                    break;
                }

                // si la variable que maneja los intentos no es 0 todavia, mostramos los intentos restantes
                Console.WriteLine($"\n[+] Intentos restantes: {iteradorIntentos}\n");

                // llamamos el metodo ObtenerMensaje el cual le pedira al usuario insertar un dato requerido
                double usuarioDeCuenta = ObtenerMensaje("Ingrese su usuario de cuenta");

                // llamamos el metodo ObtenerMensaje el cual le pedira al usuario insertar un dato requerido
                double contrasenaDeCuenta = ObtenerMensaje("Ingrese su contrasena de cuenta");

                // verificamos las credenciales si las credenciales dadas por el usuario son correctas
                bool sonCredencialesCorrectas = (usuarioDeCuenta == 12 && contrasenaDeCuenta == 4321);

                // si son correctas se ejecutara el siguiente codigo
                if (sonCredencialesCorrectas)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    // si las credenciales son correctas, daremos una bienvenida
                    Console.WriteLine("[+] Bienvenido a frankiMania.");
                    Console.ForegroundColor = ConsoleColor.White;
                    // terminamos el bucle
                    break;
                }else
                {
                    // si las credenciales son incorrectas ejecutaremos este codigo
                    Console.ForegroundColor = ConsoleColor.Red;
                    // mostramos al usuario que hay un herror de inicio de session por que sus credenciales son erroneas.
                    Console.WriteLine("\n[?] Usuario o contrasena INCORRECTA.\n");
                    Console.BackgroundColor = ConsoleColor.Red;
                    // creamos un separador de intentos
                    Console.WriteLine("                                                                                      ");
                    Console.BackgroundColor = default;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // si las credenciales fueron erroneas restamos un intento mas al usuario
                iteradorIntentos -= 1;
            }

            Console.ReadKey();

            // creamos un metodo para mostrar mensajes y pedir datos al usuario mas simple
            double ObtenerMensaje(string text)
            {
                // insertamos el mensaje dado por el usuario usando el parametro text
                Console.Write($"$$$$> {text}:");
                // convertimos el dato dado por el usuario en numero
                double datoDeUsuario = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // devolvemos el dato dado por el usuario
                return datoDeUsuario;
            }
        }
    }
}
