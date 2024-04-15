using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea un diccionario que almacene el nombre de un mes y su número de días. Luego, agrega 
    algunos meses y sus números de días a este diccionario. Finalmente, permite al usuario 
    buscar un mes y muestra su número de días. 
*/

namespace Diccionarios
{
    internal class BuscarMesAndDias
    {
        public static void MainBuscarMesAndDias()
        {
            Console.Title = "Buscar el Mes y dias";

            Dictionary<string, int> meses = new Dictionary<string, int>();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
    dMMMMb  dMMMMMP .dMMMb  dMP dMMMMb  dMMMMMP dMMMMb         dMMMMMP dMP dMP dMP dMP 
   dMP.dMP dMP     dMP"" VP amr dMP VMP dMP     dMP dMP        dMP     dMP dMP amr dMP  
  dMMMMK"" dMMMP    VMMMb  dMP dMP dMP dMMMP   dMP dMP        dMMMP   dMP dMP dMP dMP   
 dMP""AMF dMP     dP .dMP dMP dMP.aMP dMP     dMP dMP        dMP      YMvAP"" dMP dMP    
dMP dMP dMMMMMP  VMMMP"" dMP dMMMMP"" dMMMMMP dMP dMP        dMMMMMP    VP""  dMP dMMMMMP 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            meses["Enero"] = 31;
            meses["Febrero"] = 28; 
            meses["Marzo"] = 31;
            meses["Abril"] = 30;
            meses["Mayo"] = 31;
            meses["Junio"] = 30;
            meses["Julio"] = 31;
            meses["Agosto"] = 31;
            meses["Septiembre"] = 30;
            meses["Octubre"] = 31;
            meses["Noviembre"] = 30;
            meses["Diciembre"] = 31;

            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[!] Ingrese el nombre de un mes, primera letra en mayuscula (o 'fin' para terminar):");
                Console.ForegroundColor = ConsoleColor.Gray;
                string mesBuscado = Console.ReadLine();

                if (mesBuscado.ToLower() == "fin")
                {
                    break;
                }

                if (meses.ContainsKey(mesBuscado))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n[+] El mes de {mesBuscado} tiene {meses[mesBuscado]} días.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[x] Mes no encontrado.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
