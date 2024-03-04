using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Promedio por fila:

/*
    Crea un programa que calcule el promedio de cada fila de un arreglo bidimensional y 
    muestre los resultados 
*/

namespace programacion2_semana7_arrays
{
    internal class PromedioPorFila
    {
        //Instanciamos la clase mostrar
        private Mostrar _mostrar = new Mostrar();
        
        //declaramos y inicializamos el arreglo de enteros
        private int[,] arregloDeEnteros = new int[3,5] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 }
        };

        public void MainPromedioPorFila()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                 ██████╗  ██████╗ 
                ██╔════╝ ██╔═══██╗
                ██║  ███╗██║   ██║
                ██║   ██║██║   ██║
                ╚██████╔╝╚██████╔╝
                 ╚═════╝  ╚═════╝ 
            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");

            //Mostramos el promedios de cada columna
            MostrarPromedioDeFilas();
        }

        //Creamos un metod que me permita mostrar el promedio de cada columna
        private void MostrarPromedioDeFilas()
        {
            //Calcular y mostrar el promedio de cada fila
            for (int i = 0; i < this.arregloDeEnteros.GetLength(0); i++)
            {
                //Declaramos e inicializamos una variable suma
                double suma = 0;
                //Recorremos los valores del arreglo bidimensional
                for (int j = 0; j < this.arregloDeEnteros.GetLength(1); j++)
                {
                    //Sumamos cada valor del arreglo
                    suma += this.arregloDeEnteros[i, j];
                }

                //Calculamos el promedio
                double promedio = suma / arregloDeEnteros.GetLength(1);
                //Mostramos los promedios
                this._mostrar.MostrarMensaje($"\nEl promedio de la fila {i + 1} es: {promedio}\n", this._mostrar.MENSAJE_POSITIVO);
            }
        }
    }
}
