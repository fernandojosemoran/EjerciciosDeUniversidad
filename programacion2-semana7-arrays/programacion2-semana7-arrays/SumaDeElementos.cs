using System;

// Suma de elementos: 

/*
    Escribe un programa que sume todos los elementos de un arreglo bidimensional y 
    muestre el resultado.
*/

namespace programacion2_semana7_arrays
{
    internal class SumaDeElementos
    {

        public static void MainSumaDeElementos()
        {
            Console.Title = "Suma de elementos";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                   _  _   __                                 __       ___                       __           
                  FJ  L]  FJ     ____     _    _     ___ _   LJ      F _ "",   ___ _     ____    LJ    ____   
                 J |  | LJ  L   F ___J   J |  | L   F __` L  FJ     J `-'(|  F __` L   F ___J        F ___J. 
                 J J  F L|  |  | '----_  | |  | |  | |--| | J  L    | ,--.\ | |--| |  | '----_  FJ  | |---LJ 
                 J\ \/ /FF  J  )-____  L F L__J J  F L__J J J  L    F L__J \F L__J J  )-____  LJ  L F L___--.
                  \\__//J____LJ\______/FJ\____,__LJ\____,__LJ__L   J_______J\____,__LJ\______/FJ__LJ\______/F
                   \__/ |____| J______F  J____,__F J____,__F|__|   |_______FJ____,__F J______F |__| J______F 
            ");
            Console.ForegroundColor = ConsoleColor.Green;

            //Declaramos y inicializamos una instanciia de un arreglo de entero
            int[,] matrix = new int[3, 5]
            {
                { 1,2,3,4,5 },
                { 2,4,6,8,10 },
                { 3,6,9,12,15 }
            };

            //Declaramos e inicializamos una variable suma
            int suma = 0;

            //Recorrer la matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //Sumamos el valor que esta siendo recorriendo
                    suma += matrix[i, j];
                }
            }

            //Mostramos un mensaje mostrando la suma del arreglo bidimensional
            Console.WriteLine($"La suma del arreglo bidimensional es: {suma}");
        }
    }
}
