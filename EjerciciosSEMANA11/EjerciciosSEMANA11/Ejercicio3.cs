using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cree un programa en C# que simule una caja registradora de supermercado para 
devolver el cambio de una compra. Solicite la cantidad total de dinero que tiene 
en la caja registradora (x) y un número entero con el valor de la compra (y).
Deberás usar billetes de 100, 50, 20, 10, 5, 2, o 1 y devolver el cambio utilizando 
primero los billetes más grandes.
Resuelva utilizando el ciclo while 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio3
    {
        public static void EjercicioTres()
        {
            Console.Title = "Caja registradora";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n_____________________$$$		");
            Console.WriteLine("____________________$___$		");
            Console.WriteLine("_____________________$$$			");
            Console.WriteLine("_____________________$_$			");
            Console.WriteLine("_____________________$_$			");
            Console.WriteLine("___________________$$$_$$$			");
            Console.WriteLine("_________________$$__$$$__$$$			");
            Console.WriteLine("_______________$$__$$$$$$$___$			");
            Console.WriteLine("______________$_______________$			");
            Console.WriteLine("_____________$_________________$			");
            Console.WriteLine("_____________$_________________$			");
            Console.WriteLine("_____________$_____$$$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$____$_______________$			");
            Console.WriteLine("_____________$____$___$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$___$___$___________$$$			");
            Console.WriteLine("_____________$___$___$_$$$___$$$__$$			");
            Console.WriteLine("_____________$___$___$_$$$___$$$__$$			");
            Console.WriteLine("_____________$___$___$___________$$$			");
            Console.WriteLine("_____________$____$___$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$_____$$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$_________________$			");
            Console.WriteLine("_____________$____$$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$___$__$__$__$__$			");
            Console.WriteLine("_____________$__$$$$$$$$$$$$$$			");
            Console.WriteLine("_____________$__$___$__$__$__$			");
            Console.WriteLine("_____________$___$$$$$$$$$$$$$$$			");
            Console.WriteLine("____________$$$_________________$$$			");
            Console.WriteLine("__________$$___$$$_________$$$$$___$$			");
            Console.WriteLine("________$$________$$$$$$$$$__________$$$			");
            Console.WriteLine("_______$__$$_____________________$$$$___$$			");
            Console.WriteLine("____$$$$$___$$$$$$$$______$$$$$$$_______$_$			");
            Console.WriteLine("__$______$$_________$$$$$$______________$_$$			");
            Console.WriteLine("_$____$____$____________________________$_$_$			");
            Console.WriteLine("_$_____$___$______________$$$$$$$$$$$___$_$_$$			");
            Console.WriteLine("_$$$____$___$__$$$$$$$$$$$$__________$___$_$_$$			");
            Console.WriteLine("$___$$$$____$__$_____________________$___$_$$_$			");
            Console.WriteLine("$$$____$___$$__$_____________________$$__$_$__$			");
            Console.WriteLine("$___$__$__$$___$______________________$__$$$__$			");
            Console.WriteLine("$_____$$_$$____$_______________$$$____$__$_$__$		  \n");

            Console.ForegroundColor = ConsoleColor.White;
            // indicamos al usuario que escoja un indice del producto
            Console.WriteLine("Escoja que indice del producto que quiere comprar\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("| ID | Producto        | Cantidad |  Precio  |");
            Console.WriteLine("|-------------------------------- -----------|");
            Console.WriteLine("| 1  | Leche           |    5     |  L30.50  |");
            Console.WriteLine("| 2  | Pan             |    14    |  L20.00  |");
            Console.WriteLine("| 3  | Huevos          |    200   |  L105.25 |");
            Console.WriteLine("| 4  | Naranjas        |    30    |  L12.50  |");
            Console.WriteLine("| 5  | Tomates         |    40    |  L10.75  |");
            Console.WriteLine("| 6  | Galletas        |    10    |  L50.75  |");
            Console.WriteLine("| 7  | Cereal          |    25    |  L45.00  |");
            Console.WriteLine("| 8  | Jabón           |    60    |  L18.99  |");
            Console.WriteLine("| 9  | Champú          |    30    |  L40.50  |");
            Console.WriteLine("| 10 | Papel higiénico |    20    |  L50.99  |");
            Console.WriteLine("|--------------------------------------------|");
            Console.ForegroundColor = ConsoleColor.White;

            // le pedimos al usuario los datos correspondientes usnado el metodo MostrarMensaje que nos devuelve un numero 
            double dineroDeCajaRegistradora = MostrarMensaje("Indique la cantidad de dinero dispuesto en la caja registradora");
            double indiceProducto = MostrarMensaje("Indique el indice del producto");
            double cantidadDeProducto = MostrarMensaje("Indique la cantidad de productos a comprar");
            double dineroDeCliente = MostrarMensaje("Indique la cantidad de dinero del cliente");

            // usamos la clase cajero y llamamos al metodo cobrar para darle los valos correspondientes dados por el usuario
            Cajero.Cobrar(
                indiceProducto,
                cantidadDeProducto,
                dineroDeCajaRegistradora,
                dineroDeCliente
            );

            Console.ReadKey(); 
            
            // creamos un metodo para manejar facilmente los mensajes y simplificar un poco el codigo
            double MostrarMensaje(string text)
            {
                // insertamos el mensaje mediante el parametro text
                Console.Write($"\n{text}:");
                // convertimos el dato dado por el usuario en numero
                double datoDeUsuario = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                // devolvemos el numero dado por el usuario
                return datoDeUsuario;
            }
        }

        // creamos una clase cajero para dividir la logica
        public class Cajero
        {
            // creamos un metodo cobrar, el cual tendra el codigo principal
            public static void Cobrar(double indice, double cantidad, double dineroDeCaja, double dineroCliente)
            {
                // asignamos las variables correspondientes a los productos
                const int leche = 30;
                const int pan = 20;
                const int huevos = 105;
                const int naranjas = 12;
                const int tomates = 10;
                const int galletas = 50;
                const int cereal = 45;
                const int jabon = 18;
                const int champu = 40;
                const int papelHigienico = 50;

                // creamos un array que nos almacene los valores monetarios de cada billete
                double[] tiposDeMonedas = new double[7] { 100, 50, 20, 10, 5, 2, 1 };

                // creamos un indice iterador
                int index = 0;
                // una variable para guardar el cambio
                double cambio = 0;
                // otra para la compra
                double totalDeCompra = 0;
                // y el precio de todos los productos comprados
                double totalDeProductos = 0;

                // declaramos y inicializamos la variable que actualizara el dinero de la caja registradora 
                double dineroDeCajaActualizado = dineroDeCaja;


                // usamos la estructura de control switch para verificar el productos y obtener el precio total
                switch (indice)
                {
                    case 1:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * leche);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 2:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * pan);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 3:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * huevos);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 4:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * naranjas);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 5:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * tomates);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 6:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * galletas);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 7:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * cereal);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 8:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * jabon);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 9:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * champu);
                        // cancelamos la verificacion de los demas productos
                        break;
                    case 10:
                        // calculamos el precio total de los productos
                        totalDeProductos = Math.Round(cantidad * papelHigienico);
                        // cancelamos la verificacion de los demas productos
                        break;
                }

                // usamos un bucle while para comprobar la logica del dinero del cliente
                while (true)
                {
                    // si el cliente no tiene suficiente dinero para realizar la compra
                    if (dineroCliente < totalDeProductos)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        // mostramos un mensaje de error
                        Console.WriteLine("[-] No puedes realizar la compra por falta de dinero.");
                        Console.ForegroundColor = ConsoleColor.White;
                        // salimos del bucle
                        break;
                    }

                    // si el clinete tiene menos dinero que la caja registrado terminamos el bucle
                    if (dineroCliente < dineroDeCajaActualizado)
                    {
                        //
                        break;
                    }

                    // pero si la caja registradora no tiene suficiente dinero, agregamos 3000  otorgados por el negocio o empresa.
                    if (dineroCliente >= dineroDeCajaActualizado)
                    {
                        // le otorgamos 3000 lempiras para que puedar realizar el cobro
                        dineroDeCajaActualizado += 3000;
                        // indicamos que se agrego la cantidad de 3000 lempiras 
                        Console.WriteLine("Por falta de dinero, el supermercado ha brindado a la caja registradora L3000 para realizar cobros.");
                    }
                }

                // calculamos el total de la compra realizada por el usuario
                totalDeCompra = dineroCliente - totalDeProductos;
                // calculamos el cambio del cliente
                cambio = dineroDeCajaActualizado - totalDeCompra;

                // mostramos los valores al usuario
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n");
                Console.WriteLine(
                    "[+] El cambio es de: {0}\n" +
                    "[+] El precio de los productos es: {1}",
                    cambio,
                    totalDeProductos
                );

                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.White;

                // creamos un bucle while para incrementar el index o indice iterador y poder calcular los billetes requeridos para el cambio
                // verificamos que exista un cambio 
                while (cambio > 0)
                {
                    // salimos del bucle si el indice es 6 ya que es el maximo de iteraciones que tiene el array tiposDeMonedas
                    if (index >= 6)
                    {
                        // salimos del bucle
                        break;
                    }

                    // almacenamos los billetes y los redondiamos
                    double billetes  = Math.Round(cambio / tiposDeMonedas[index]);

                    // verificamos que existan billetes
                    if (billetes > 0)
                    {
                        // mostramos los billetes necesarios para realizar el cambio del cliente
                        Console.WriteLine($"Billetes de {tiposDeMonedas[index]}: {billetes}");
                        // obtenemos el valor restante si es que existe del siguiten billete menor 
                        cambio %= tiposDeMonedas[index];
                    }

                    // incrementamos la variable index que nos sirve de iteradora
                    index++;
                }
            }
        }
    }
}
