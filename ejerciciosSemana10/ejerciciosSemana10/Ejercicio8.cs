using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escribir un programa que permita emitir la FACTURA correspondiente, a una compra de un Artículo determinado, del que se adquieren una o varias Unidades. El ISV a aplicar es de 13% y si el Sub Total (precio de venta por cantidad), es Mayor de 1000, se aplicará un descuento del 15%.
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio8
    {
        static public void EjercicioOcho()
        {
            Console.Title = "Factura";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n                  ,  ;:._.-`''.  				");
            Console.WriteLine("                ;.;'.;`      _ `.				");
            Console.WriteLine("                 ',;`       ( \\ ,`-.  			");
            Console.WriteLine("              `:.`,         (_/ ;\\  `-.			");
            Console.WriteLine("               ';:              / `.   `-._		");
            Console.WriteLine("             `;.;'              `-,/ .     `-.	");
            Console.WriteLine("             ';;'              _    `^`       `.	");
            Console.WriteLine("            ';;            ,'-' `--._          ;	");
            Console.WriteLine("   ':      `;;        ,;     `.    ':`,,.__,,_ /	");
            Console.WriteLine("    `;`:;`;:`       ,;  '.    ;,      ';';':';;`	");
            Console.WriteLine("                 .,; '    '-._ `':.;    			");
            Console.WriteLine("               .:; `          '._ `';;,			");
            Console.WriteLine("             ;:` `    :'`'       ',__.)			");
            Console.WriteLine("           `;:;:.,...;'`'					    ");
            Console.WriteLine("         ';. '`'::'`''  .'`'					    ");
            Console.WriteLine("       ,'   `';;:,..::;`'`'					    ");
            Console.WriteLine("   , .;`      `'::''`						    ");
            Console.WriteLine("   ,`;`.								          \n");

            Console.ForegroundColor = ConsoleColor.Gray;
            // cabezeras de los productos

            Console.WriteLine(
                "Indice\t" +
                "Producto\t\t" +
                "Unidades\t" +
                "Precio"
            );

            // mostramos los productoa que vendemos
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "[1]\t" +
                "Cargador generico\t" +
                "15\t\t" +
                "L200"
            );

            Console.WriteLine(
                "[2]\t" +
                "Pepsi 3 litros\t\t" +
                "27\t\t" +
                "L50"
            );

            Console.WriteLine(
                "[3]\t" +
                "Costal de papas\t\t" +
                "54\t\t" +
                "L600"
            );

            // creamos un bucle for para insistir al usuario a que compre mas.
            for (; ; )
            {
                // preguntamos al usuario si quiere comprar algo, para comprar algo le pedimos el indice.
                Console.WriteLine("\nQue quiere comprar");
                // convertimos el valor dado a un numero.
                int indice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // si el usuario nos pone indice 0, el programa termina.
                if (indice == 0)
                {
                    break;
                }
                // le pedimos cuantos productos quiere llevar.
                Console.WriteLine("Cuantas Unidades Quiere Comprar");
                // convertimos el valor dado a un numero.
                int CantidadDeUnidades = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                // declaramos y inicializamos las variables correspondientes

                string total;
                // instanciamos la clase Cobrador y usamos el metodo cobrar.
                total = Cobrador.HacerCobra(indice, CantidadDeUnidades);

                // mostramos los valores
                Console.WriteLine(total);
            }
        }

        class Cobrador
        {
            public static string HacerCobra(int index, int unidades)
            {
                // declaramos y inicializamos las variables correspondientes
                int precioCargadorGenerico = 200;
                int precioPepsi = 50;
                int precioCostalDePapas = 600;
                const double ISV = 0.13;
                const double descuento = 0.15;
                double PrecioTotal;
                double impuestoAplicado;
                double descuentoToAplicar;

                // usamos la estructura de control swith para hacer la logica correspondiente
                switch (index)
                {
                    case 1:
                        // obtenemos el impuesto ISV
                        impuestoAplicado = (precioCargadorGenerico * unidades) * ISV;
                        // agregamos el impuesto al valor del total de productos
                        PrecioTotal = (precioCargadorGenerico * unidades) + impuestoAplicado;

                        // verificamos si el valor de los productos excede los 1000 L
                        if (PrecioTotal > 1000)
                        {
                            // si excede los 1000 L aplicamos un descuento
                            descuentoToAplicar = PrecioTotal * descuento;
                            // devolvemos el precio total y descuento
                            return $"El Precio total es: {PrecioTotal - descuentoToAplicar}\tEl descuento es: {descuentoToAplicar}";
                        }

                        // devolvemos el precio total y descuento
                        return $"El Precio total es: {PrecioTotal}\tEl descuento es: {0}";

                    case 2:
                        // obtenemos el impuesto ISV
                        impuestoAplicado = (precioPepsi * unidades) * ISV;
                        // agregamos el impuesto al valor del total de productos
                        PrecioTotal = (precioPepsi * unidades) + impuestoAplicado;

                        // verificamos si el valor de los productos excede los 1000 L
                        if (PrecioTotal > 1000)
                        {
                            // si excede los 1000 L aplicamos un descuento
                            descuentoToAplicar = PrecioTotal * descuento;
                            // devolvemos el precio total y descuento
                            return $"El Precio total es: {PrecioTotal - descuentoToAplicar}\tEl descuento es: {descuentoToAplicar}";
                        }

                        // devolvemos el precio total y descuento
                        return $"El Precio total es: {PrecioTotal}\tEl descuento es: {0}";

                    case 3:
                        // obtenemos el impuesto ISV
                        impuestoAplicado = (precioCostalDePapas * unidades) * ISV;
                        // agregamos el impuesto al valor del total de productos
                        PrecioTotal = (precioCostalDePapas * unidades) + impuestoAplicado;

                        // verificamos si el valor de los productos excede los 1000 L
                        if (PrecioTotal > 1000)
                        {
                            // si excede los 1000 L aplicamos un descuento
                            descuentoToAplicar = PrecioTotal * descuento;
                            // devolvemos el precio total y descuento
                            return $"El Precio total es: {PrecioTotal - descuentoToAplicar}\tEl descuento es: {descuentoToAplicar}";
                        }

                        // devolvemos el precio total y descuento
                        return $"El Precio total es: {PrecioTotal}\tEl descuento es: {0}";

                    default:
                        // devolvemos un mensaje de error.
                        return "El indice que ingresastes no es correcto";
                }
            }
        }
    }
}
