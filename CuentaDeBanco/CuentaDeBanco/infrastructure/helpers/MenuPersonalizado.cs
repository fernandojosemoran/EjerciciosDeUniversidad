using CuentaDeBanco.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.helpers
{
    public class MenuPersonalizado
    {
        static public void CrearMenuPersonalizado(List<CuentaEntity> lista, string cabecera)
        {
            string[] headers = { cabecera };

            // Calcular el ancho de la columna basada en la longitud más larga de las acciones con índice
            int columnWidth = 0;
            int index = 1;

            Console.WriteLine("\n");
            foreach (var action in lista)
            {
                string indexedAction = $"({index}) {action}";
                if (indexedAction.Length > columnWidth)
                {
                    columnWidth = indexedAction.Length;
                }
                index++;
            }

            // Imprimir la cabecera
            Console.WriteLine("| {0,-" + columnWidth + "} |", cabecera);
            Console.WriteLine(new string('-', columnWidth + 4)); // Separador

            // Imprimir las acciones con índice
            index = 1;
            foreach (var action in lista)
            {
                string indexedAction = $"({index}) {action}";
                Console.WriteLine("| {0,-" + columnWidth + "} |", indexedAction);
                index++;
            }

            Console.WriteLine("\n");
        }
    }
}
