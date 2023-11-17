using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Se desea calcular de forma Independiente, la suma de los números pares e impares de los números comprendidos del 1 al 200. 
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio9
    {
        static public void EjercicioNueve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n             =+$HM####@H%;, 				");
            Console.WriteLine("          /H###############M$, 			    ");
            Console.WriteLine("          ,@################+ 			    ");
            Console.WriteLine("           .H##############+ 			    ");
            Console.WriteLine("             X############/ 				    ");
            Console.WriteLine("              $##########/ 				    ");
            Console.WriteLine("               %########/ 				    ");
            Console.WriteLine("                /X/;;+X/ 				    ");
            Console.WriteLine("					 			                ");
            Console.WriteLine("                 -XHHX- 				        ");
            Console.WriteLine("                ,######, 				    ");
            Console.WriteLine("#############X  .M####M.  X############# 	");
            Console.WriteLine("##############-   -//-   -############## 	");
            Console.WriteLine("X##############%,      ,+##############X 	");
            Console.WriteLine("-##############X        X##############- 	");
            Console.WriteLine(" %############%          %############% 		");
            Console.WriteLine("  %##########;            ;##########% 		");
            Console.WriteLine("   ;#######M=              =M#######; 		");
            Console.WriteLine("    .+M###@,                ,@###M+. 		");
            Console.WriteLine("       :XH.                  .HX: 		  \n");

            // declaramos y inicializamos las variables necesarias
            int sumaPares = 0;
            int sumaImpares = 0;

            // usamos un blucle for para recorrer un rango de numeros de 1 al 200
            for (int i = 1; i <= 200; i++)
            {
                // si el residuo de la operacion es 0 es un numero par
                if ((i % 2) == 0)
                {
                    // sumamos el nuevo numero par a la variable sumaPares
                    sumaPares += i;
                }

                // si el residuo de la operacion es 1 es un numero impar
                if ((i % 2) == 1)
                {
                    // sumamos el nuevo numero impar a la variable sumaImpares
                    sumaImpares += i;
                }
            }

            // mostramos los datos
            Console.WriteLine("La suma de los pares son: {0}", sumaPares);
            Console.WriteLine("La suma de los impares son: " + sumaImpares);
        } 
    }
}
