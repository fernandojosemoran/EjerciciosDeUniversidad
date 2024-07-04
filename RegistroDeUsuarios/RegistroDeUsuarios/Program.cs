using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

/*
    Desarrollar aplicación cumpliendo las siguientes características: Deberán de crear una clase
    llamada ClaseUsuario y su contructor (para inicializar las propiedades), la cual tendrán los
    siguientes atributos o propiedades

    IdUsuario       string
    NombreUsuario   string
    ApellidoUsuario string
    CodigoEmpleado  int
    RolUsuario      string
    FechaApertura   DateTime
    Password        string
    Activo          boolean
    GetUsuarios     DataTable

    Deberán de ingresar los datos por consola, donde podrá enviar o capturar datos de los
    atributos mencionados anteriormente. Se listarán o mostraran por consola los registros
    añadidos en el DataTabe, crearan un menú con tres opciones 

    1. Agregar datos 
    2. Buscar datos
    3. Salir deberá de contar con un Filtrado dinamico donde por medio de la consola se pueda buscar por IdUsuario, NombreUsuario, ApellidoUsuario, CodigoEmpleado, RolUsuario

    Deben investigar como funciona el objeto DataTable para poder almacenar datos y obtener datos desde ese objeto.
*/

namespace RegistroDeUsuarios
{
    public class Program
    {
        static private void Banner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                         .-""""""-.
                        /       \
                        \       /
                 .-""""""-.-`.-.-.<  _
                /      _,-\ O_O-_/ ) 
                \     / ,  `   . `|
                 '-..-| \-.,__~ ~ /        
                       \ `-.__/  /         
                      / `-.__.-\`-._    ,"",
                     / /|    ___\-._`-.;  , .----.  
                    ( ( |.-""`   `'\ '-(     -.---' 
                     \ \/    {}{}  |   \.__.-'
                      \|           /     
                       \        , /
                       ( __`;-;'__`)
                       `//'`   `||`
                      _//       ||
              .-""-._,(__)     .(__).-""""-.
             /          \    /           \
             \          /    \           /
              `'-------`      `--------'`
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main(string[] args)
        {
            Console.Title = "Registro de usuarios";
            Banner();

            while (true)
            {
                Menu.ShowMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Menu.AgregarDatos();
                        break;
                    case "2":
                        Menu.BuscarDatos();
                        break;
                    case "3":
                        Menu.VerTodosLosRegistros();
                        break;
                    case "4":
                        Menu.LimpiarConsola();
                        Banner();
                        break;
                    case "5":
                        return;
                    default:
                        Mensaje.MensajeNegativo("Opción no valida. Intente de nuevo.");
                        break;
                }
            }

        }
    }
}
