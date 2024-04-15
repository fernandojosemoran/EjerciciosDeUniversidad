using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Implementa un sistema de registro de clientes para una empresa. Utiliza uno o los diccionarios 
    que considere, para almacenar información como nombres, direcciones y números de teléfono 
    de los clientes. Ingresar por consola la cantidad de clientes a almacenar, también crear un 
    menú con las opciones: Agregar cliente, Mostrar cliente, modificar cliente y Salir. 
*/

namespace Diccionarios
{
    internal class RegistroDeClientes
    {
        public static void MainRegistroDeClientes()
        {
            Console.Title = "Registro de clientes";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"                                    
            @@@  @@@   @@@@@@   @@@        @@@@@@   
            @@@  @@@  @@@@@@@@  @@@       @@@@@@@@  
            @@!  @@@  @@!  @@@  @@!       @@!  @@@  
            !@!  @!@  !@!  @!@  !@!       !@!  @!@  
            @!@!@!@!  @!@!@!@!  @!!       @!@  !@!  
            !!!@!!!!  !!!@!!!!  !!!       !@!  !!!  
            !!:  !!!  !!:  !!!  !!:       !!:  !!!  
            :!:  !:!  :!:  !:!   :!:      :!:  !:!  
            ::   :::  ::   :::   :: ::::  ::::: ::  
             :   : :   :   : :  : :: : :   : :  :                         
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese la cantidad de clientes a almacenar: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            int cantidadClientes;
            while (!int.TryParse(Console.ReadLine(), out cantidadClientes) || cantidadClientes <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[x] Cantidad no válida. Por favor, ingrese un número entero positivo.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Ingrese la cantidad de clientes a almacenar: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nCliente {i + 1}:");
                Console.Write("\nNombre: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string nombre = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nDirección: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string direccion = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nNúmero de teléfono: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string telefono = Console.ReadLine();

                Cliente cliente = new Cliente(nombre, direccion, telefono);
                clientes[nombre] = cliente;
            }

            bool salir = false;
            while (!salir)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenú:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Mostrar cliente");
                Console.WriteLine("3. Modificar cliente");
                Console.WriteLine("4. Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Seleccione una opción: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Opción no válida. Por favor, ingrese un número del 1 al 4.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarCliente(clientes);
                        break;
                    case 2:
                        MostrarCliente(clientes);
                        break;
                    case 3:
                        ModificarCliente(clientes);
                        break;
                    case 4:
                        salir = true;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n[!] Saliendo del programa...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[x] Opción no válida. Por favor, ingrese un número del 1 al 4.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
        }

        static void AgregarCliente(Dictionary<string, Cliente> clientes)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[!] Agregar Cliente:");
            Console.Write("\nNombre: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nombre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDirección: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string direccion = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nNúmero de teléfono: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string telefono = Console.ReadLine();

            Cliente cliente = new Cliente(nombre, direccion, telefono);
            clientes[nombre] = cliente;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Cliente agregado correctamente.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarCliente(Dictionary<string, Cliente> clientes)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[!] Mostrar Cliente:");
            Console.Write("\n[!]Ingrese el nombre del cliente: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nombre = Console.ReadLine();

            if (clientes.ContainsKey(nombre))
            {
                Cliente cliente = clientes[nombre];

                Console.ForegroundColor = ConsoleColor.Green;   
                Console.WriteLine($"\n[+] Nombre: ({cliente.Nombre}),\tDirección: ({cliente.Direccion}),\tNúmero de teléfono: ({cliente.Telefono})");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[x] Cliente no encontrado.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        static void ModificarCliente(Dictionary<string, Cliente> clientes)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[!] Modificar Cliente:");
            Console.Write("\n[!] Ingrese el nombre del cliente a modificar: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nombre = Console.ReadLine();

            if (clientes.ContainsKey(nombre))
            {
                Cliente cliente = clientes[nombre];

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[!]cIngrese los nuevos datos del cliente (deje en blanco para mantener los datos actuales):");
                Console.Write("\nNuevo nombre: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string nuevoNombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    cliente.Nombre = nuevoNombre;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nNueva dirección: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                string nuevaDireccion = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nuevaDireccion))
                {
                    cliente.Direccion = nuevaDireccion;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nNuevo número de teléfono: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string nuevoTelefono = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nuevoTelefono))
                {
                    cliente.Telefono = nuevoTelefono;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n[+] Cliente modificado correctamente.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[x] Cliente no encontrado.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
    class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Cliente(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
