using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10Producto_FormaDePago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] cc = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Precio de producto y Forma de pago\n");

            // Le mostramos al usuario los productos
            Console.WriteLine("Escoja un producto a comprar\n");
            Console.ForegroundColor = cc[2];
            Console.WriteLine("[1] Iphone 15             1000$");
            Console.WriteLine("[2] Laptop php            1200$");
            Console.WriteLine("[3] Iphone Watch          300$");
            Console.WriteLine("[4] Samsung Galaxy s22    1000$");
            Console.WriteLine("[5] Play Station 5        800$\n");

            Console.ForegroundColor = ConsoleColor.Gray;

            // Le pedimos al usuario que escoja un producto
            Console.WriteLine("Ingrese un indice del producto a comprar.");
            int indiceProducto = int.Parse(Console.ReadLine());

            // Verificamos que el usuario no ingrese un indice incorrecto
            if (
                indiceProducto != 1 &&
                indiceProducto != 2 &&
                indiceProducto != 3 &&
                indiceProducto != 4 &&
                indiceProducto != 5
            ){
                // Mostramos el mensaje negativo por escoger un indice erroneo.
                Console.WriteLine("\n[-] El indice del producto que ingresastes no existe.");
            }

            // Despues que el usuario indique el indice del producto que indique el indice del metodo de pago.
            Console.WriteLine("\nEscoja un medio de pago.\n");
            Console.ForegroundColor = cc[2];
            Console.WriteLine("[1] Paypal");
            Console.WriteLine("[2] Targeta");
            Console.WriteLine("[3] Efectivo\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            int indicePago = int.Parse(Console.ReadLine());

            // Verificamos si el usuario escoge un indice que no existe, le indicamos que ha  habido un error. 
            if (
                indicePago != 1 &&
                indicePago != 2 &&
                indicePago != 3 
            ){
                Console.WriteLine("\n[-] El indice de pago que ingresastes no existe.\n");
            }

            // Pero si el usaurio escoge pagar con tarjeta le pedimos el codigo de pago
            if (indicePago == 2)
            {
                // Le pedimos el codigo de pago
                Console.WriteLine("\nIngrese codigo de la tarjeta\n");
                string codigoTarjeta = Console.ReadLine();

                // Si el codigo de pago esta basio le decimos al usuario que su compra no se ha realizado
                if (codigoTarjeta == "") { 
                    Console.WriteLine("\n[-] Lo sentimos el pago no se realizo correctamente, Vuelva a intentar mas tarde.\n"); 
                }
                else
                {
                    // Si el usuario otorgo el codigo de pago, le avisamos que su compra se a realizado exitosamente.
                    Console.ForegroundColor = cc[12];
                    Console.WriteLine("\n\n[+] El pago se realizo correctamente.\n");
                }
            }

            Console.ReadKey();
        }
    }
}
