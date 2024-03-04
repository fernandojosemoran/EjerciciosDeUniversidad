using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mayor elemento por columna: 

/*
    Desarrolla un programa que encuentre el mayor elemento de cada columna en un 
    arreglo bidimensional y los muestre
*/

namespace programacion2_semana7_arrays
{
    internal class MayorElementoPorColumna
    {
        //Declaramos y inicializaos una variable que instancia a la clase mostrar
        private Mostrar _mostrar = new Mostrar();

        public void MainMayorElementoPorColumna()
        {
            //Llamamos al metodo para mostrar los datos necesarios
            this._MostrarValoresMaximosPorColumna();
        }

        private void _MostrarValoresMaximosPorColumna()
        {
            Console.Title = "ElMayorElementoPorColumna";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
                ██████╗ ██╗  ██╗██████╗ 
                ██╔══██╗██║  ██║██╔══██╗
                ██████╔╝███████║██████╔╝
                ██╔═══╝ ██╔══██║██╔═══╝ 
                ██║     ██║  ██║██║     
                ╚═╝     ╚═╝  ╚═╝╚═╝   
            ");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Creamos un arreglo bidimensional de enteros
            int[,] matrix1 = new int[3, 5]
            {
                { 32, 65, 88, 90, 76 },
                { 21, 43, 9, 874, 65 },
                { 54, 24, 88, 90, 54 }
            };

            // Recorremos los arreglos internos
            for (int fila = 0; fila < matrix1.GetLength(0); fila++)
            {
                // Inicializar el valor maximo para la columna actual
                int maximo = int.MinValue;
                //Recorremos el arreglo bidimensional de enteros
                for (int columna = 0; columna < matrix1.GetLength(1); columna++)
                {
                    //Verificamos que los valores de la columna sean mayores que el valor maximo
                    if (matrix1[fila, columna] > maximo)
                    {
                        //Si es mayor entonces lo guardamos en la variable maximo
                        maximo = matrix1[fila, columna];
                    }
                }

                //Mostramos un mensaje mostrando el valor de mas alto de cada columna
                this._mostrar.MostrarMensaje($"\nEl número mayor de la columna {fila + 1} es: {maximo}", this._mostrar.MENSAJE_POSITIVO);
            }
        }
    } 
}

