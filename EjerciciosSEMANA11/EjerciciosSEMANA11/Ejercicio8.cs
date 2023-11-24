using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Realiza un programa en C#, que pida 2 números enteros, e imprima los números 
pares que existen entre los 2.
Nota: Se debe validar que el segundo número sea mayor que el primero.
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio8
    {
        public static void EjercicioOcho()
        {
            Console.Title = "Calcular numeros pares";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("§§§§§§¶¶¶¶¶¶§§§§§§§§§§§¶§¶§¶¶¶¶¶¶¶§§§¶§§        ");
            Console.WriteLine("§§§¶§§111111§§1§¶§§§§§§¶§11§§111111§1¶§§        ");
            Console.WriteLine("§§§¶¶§§11111§§1§¶§§§§§¶¶1§§§§11111§§§¶§§        ");
            Console.WriteLine("§§§§¶¶§§1111§§1§¶§§§§§¶¶1§§¶11111§§§¶§§§        ");
            Console.WriteLine("§§§§§¶¶§§111§§§1¶§§§§§¶§1§§§1111§§§¶§§§§        ");
            Console.WriteLine("§§§§§§¶§1§§11¶§§¶¶§§§§¶§1§§§11§§§¶¶§§§§§        ");
            Console.WriteLine("§§§§§§§¶¶1§§1§§1¶¶§§§§¶§11§11§§§¶¶§§§§§§        ");
            Console.WriteLine("§§§§§§§§¶¶1§§¶§1¶¶§§¶¶¶§1§§§§§§¶¶§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§¶¶1§§§1¶¶¶¶¶§¶¶¶§§§1§¶§§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§§¶¶§§§1¶¶§¶§¶¶¶§¶§§§¶§§§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§§§¶¶§§1§§11§¶§§¶§§§¶¶§§§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§§¶§§§§§§§§§§1§§§§§§§§¶§§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§¶¶1§§§§§§§§§§§§§§§§§1§¶§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§¶§§§1§§§§§§§§§§§§§11§§¶§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§¶§§111§§§§§§§§§§§111§§¶¶§§§§§§§        ");
            Console.WriteLine("§§§§§§§§¶§§§1111§§§§§§§§§11111§§¶§§§§§§§        ");
            Console.WriteLine("§§§§§§§¶§1§§1111§§§§§§§§§11111§1§¶§§§§§§        ");
            Console.WriteLine("§§§§§§¶¶1§§§11111§§§§§§§11111§§§1¶¶§§§§§        ");
            Console.WriteLine("§§§§¶¶§1§§§§11111§§§§§§§11111§§§§1¶¶§§§§        ");
            Console.WriteLine("¶¶¶§¶¶§§§§§¶11§¶1§§§§§§§1¶¶11¶§§§§§¶¶¶¶¶        ");
            Console.WriteLine("¶§§111111§§§¶1¶¶§§§§§§§§§¶¶1§§§§1111§§§§        ");
            Console.WriteLine("1111111§111111§¶§§§§§§§§§¶§1111111111111        ");
            Console.WriteLine("§§§§§§§1§§§§§1111§§§§§§§11111111§1§1§§§1        ");
            Console.WriteLine("111111§§§¶¶¶¶¶¶¶¶§1§§§11¶¶¶¶¶¶¶¶§§§§1§11        ");
            Console.WriteLine("11§§§§§§§1§¶¶¶¶¶¶111¶§11¶¶¶¶¶¶¶111111111        ");
            Console.WriteLine("§1111111111§¶¶§¶¶111§111§¶§§¶¶1111111111        ");
            Console.WriteLine("¶§1111111111§¶¶¶¶111§111¶¶¶¶¶1111111111§        ");
            Console.WriteLine("¶¶¶§111111111§¶¶¶§111111¶¶¶¶111111111§¶¶        ");
            Console.WriteLine("§§¶¶¶§11111111§¶¶¶§§11§¶¶¶¶§11111111¶¶¶§        ");
            Console.WriteLine("§§§§¶¶¶§1111111§¶¶¶¶¶¶¶¶§¶§111111§¶¶¶§§§        ");
            Console.WriteLine("§§§§§§¶¶¶¶§§1111§¶§§§§§§§11111§§¶¶¶§§§§§        ");
            Console.WriteLine("§§§§§§§§§¶¶¶¶¶§§11§§§§§§1§§§¶¶¶¶§§§§§§§§        ");
            Console.WriteLine("§§§§§§§§§§§§§§¶§§§111111¶¶§¶¶§§§§§§§§§§§        ");
            Console.ForegroundColor = ConsoleColor.White;

            // pedimos al usuario el primer numero
            Console.Write("\n[?] Ingrese el primer numero entero: ");
            // convertimos el dato dado por el usuario en numero
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // pedimos al usuario el primer numero
            Console.Write("\n[?] Ingrese el segundo numero entero: ");
            // convertimos el dato dado por el usuario en numero
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // usamos un set para guardar no guardas numeros repetidos
            HashSet<int> set = new HashSet<int>();

            // obtenemos el valor minimo entre los dos numeros dados por el usuario
            int numeroMenor = (numero1 >= numero2) ? numero2 : numero1;

            // usamos un for para recorrer desde el 1 al numero con menos valor dado por el usuario
            for (int i = 1; i <= numeroMenor; i++)
            {
                // obtenemos los numeros pares del primer numero dado por el usuario
                if (numero1 % 2 == 0)
                {
                    // almacenamos en el set de datos los numeros pares del primer numero dado por el usuario
                    set.Add(i / 2);
                }

                // obtenemos los numeros pares del segundo numero dado por el usuario
                if (numero2 % 2 == 0)
                {
                    // almacenamos en el set de datos los numeros pares del segundo numero dado por el usuario
                    set.Add(i / 2);
                }
            }

            // recorremos los numeros pares que comparten el primer numero con el segundo numero
            foreach (var item in set)
            {
                // mostramos los valores
                Console.Write($"[+] Los numeros pares que comparten {numero1} y {numero2} son: {item}");
            }

            Console.ReadKey();
        }
    }
}
