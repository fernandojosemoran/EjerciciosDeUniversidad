using System;

// Llenar un vector de 20 elementos

/*
    Imprimir la posición y el valor del elemento mayor almacenado en el vector. Supongamos 
    que todos los elementos del vector son diferentes 
*/
namespace programacion2_semana7_arrays
{
    internal class ImprimirPosicionAndValor
    {
        private Mostrar _mostrar = new Mostrar();   

        public void MainImprimirPosicionAndValor()
        {
            Console.Title = "Imprimir posicion y valor";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                  (     _      _    
                  )\  _| |_  _| |_  
                 ((_)|_   _||_   _| 
                / _|   |_|    |_|   
                \__|                   
            ");

            Console.ForegroundColor = ConsoleColor.Gray;

            //Declaramos e inicializamos una variable que interactura como a vector que tiene 10 elementos
            int[] vector = new int[10];

            //Llenar el vector con valores otorgados por el usuario
            for (int i = 0; i < vector.Length; i++)
            {
                //Obtenemos los valore enteros
                Console.Write($"Ingrese el valor para el elemento {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            //Encontrar el mayor elemento y su posición en el vector
            int mayor = vector[0]; 
            int posicion = 0; 

            //Recorremos la variable unidemencional
            for (int i = 1; i < vector.Length; i++)
            {
                //Comprobamos si el codicional 
                if (vector[i] > mayor)
                {
                    //Metemos todos los valores o mas bien copiarnose disenos
                    mayor = vector[i];
                    posicion = i;
                }
            }

            //Mostramos el mensaje indicando que 
            this._mostrar.MostrarMensaje($"\nEl elemento mayor se encuentra en la posición {posicion} y tiene el valor de {mayor}", this._mostrar.MENSAJE_POSITIVO);
        }
    }
}
