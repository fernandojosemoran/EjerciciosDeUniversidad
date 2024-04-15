using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea un programa que gestione el inventario de una tienda. Utiliza un diccionario para 
    mantener un registro de los productos disponibles, combinado el diccionario con una lista o 
    arreglo para manejar sus precios y cantidades en stock. Permite al usuario elegir a través de un
    menú las opciones: agregar, vender, Consultar, actualizar productos y salir.
*/

namespace Diccionarios
{
    internal class InventarioDeProducto
    {
        static Dictionary<string, Tuple<double, int>> inventario = new Dictionary<string, Tuple<double, int>>();
        public static void MainInventarioDeProducto()
        {
            Console.Title = "Inventario";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                                                                                                                                               
                                                                                                                  dddddddd                                                            
                            ..       ..                                ..                           s                 
                      x .d88""  x .d88""                    oec :      dF                            :8      ..         
                       5888R    5888R             u.     @88888     '88bu.         x.    .        .88     @L          
      .         u      '888R    '888R       ...ue888b    8""*88%     '*88888bu    .@88k  z88u     :888ooo 9888i   .dL  
 .udR88N     us888u.    888R     888R       888R Y888r   8b.          ^""*8888N  ~""8888 ^8888   -*8888888 `Y888k:*888. 
<888'888k .@88 ""8888""   888R     888R       888R I888>  u888888>     beWE ""888L   8888  888R     8888      888E  888I 
9888 'Y""  9888  9888    888R     888R       888R I888>   8888R       888E  888E   8888  888R     8888      888E  888I 
9888      9888  9888    888R     888R       888R I888>   8888P       888E  888E   8888  888R     8888      888E  888I 
9888      9888  9888    888R     888R      u8888cJ888    *888>       888E  888F   8888 ,888B .  .8888Lu=   888E  888I 
?8888u../ 9888  9888   .888B .  .888B .     ""*888*P""     4888       .888N..888   ""8888Y 8888""   ^%888*    x888N><888' 
 ""8888P'  ""888*""""888""  ^*888%   ^*888%        'Y""        '888        `""888*""""     `Y""   'YP       'Y""      ""88""  888  
   ""P'     ^Y""   ^Y'     ""%       ""%                      88R           """"                                       88F  
                                                          88>                                                   98""   
                                                          48                                                  ./""     
                                                          '8                                                 ~`                                                                                                                                    
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMenú:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Vender producto");
                Console.WriteLine("3. Consultar inventario");
                Console.WriteLine("4. Actualizar producto");
                Console.WriteLine("5. Salir");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nSeleccione una opción: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[-] Opción no válida. Por favor, ingrese un número del 1 al 5.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        VenderProducto();
                        break;
                    case 3:
                        Console.WriteLine("\nNombre\t\tPrecio\t\tCantidad");
                        ConsultarInventario();
                        break;
                    case 4:
                        ActualizarProducto();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nSaliendo del programa...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[-] Opción no válida. Por favor, ingrese un número del 1 al 5.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nIngrese el nombre del producto: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nombre = Console.ReadLine();

            if (inventario.ContainsKey(nombre))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] El producto ya existe en el inventario.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nIngrese el precio del producto: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            double precio;
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] Precio no valido. Por favor, ingrese un numero positivo.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nIngrese el precio del producto: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nIngrese la cantidad en stock del producto: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] Cantidad no válida. Por favor, ingrese un número entero no negativo.");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Ingrese la cantidad en stock del producto: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            inventario.Add(nombre, Tuple.Create(precio, cantidad));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Producto agregado al inventario.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void VenderProducto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese el nombre del producto a vender: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string nombre = Console.ReadLine();

            if (!inventario.ContainsKey(nombre))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] El producto no existe en el inventario.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese la cantidad a vender: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 0 || cantidad > inventario[nombre].Item2)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"\n[-] Cantidad no válida. Por favor, ingrese un número entero no negativo menor o igual a {inventario[nombre].Item2}.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Ingrese la cantidad a vender: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Tuple<double, int> producto = inventario[nombre];
            double precioTotal = cantidad * producto.Item1;
            inventario[nombre] = Tuple.Create(producto.Item1, producto.Item2 - cantidad);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Se vendieron {cantidad} unidades de {nombre} por un total de ${precioTotal}.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void ConsultarInventario()
        {
            if (inventario.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] El inventario está vacío.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            foreach (var item in inventario)
            {
                string nombre = item.Key;
                double precio = item.Value.Item1;
                int cantidad = item.Value.Item2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{nombre}\t\t${precio}\t\t{cantidad}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        static void ActualizarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese el nombre del producto a actualizar: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            string nombre = Console.ReadLine();

            if (!inventario.ContainsKey(nombre))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] El producto no existe en el inventario.");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[+] Producto: {nombre}, Precio actual: {inventario[nombre].Item1}, Cantidad en stock actual: {inventario[nombre].Item2}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese el nuevo precio del producto: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            double nuevoPrecio;
            while (!double.TryParse(Console.ReadLine(), out nuevoPrecio) || nuevoPrecio <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[-] Precio no válido. Por favor, ingrese un número positivo.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Ingrese el nuevo precio del producto: ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[!] Ingrese la nueva cantidad en stock del producto: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            int nuevaCantidad;
            while (!int.TryParse(Console.ReadLine(), out nuevaCantidad) || nuevaCantidad < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCantidad no válida. Por favor, ingrese un número entero no negativo.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n[!] Ingrese la nueva cantidad en stock del producto: ");
                Console.ForegroundColor = ConsoleColor.Gray;    
            }

            inventario[nombre] = Tuple.Create(nuevoPrecio, nuevaCantidad);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Producto actualizado en el inventario.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
