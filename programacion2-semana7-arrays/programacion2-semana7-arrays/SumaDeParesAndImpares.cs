using System;

//Suma de elementos pares e impares: 

/*
    Escribe un programa que cree un arreglo unidimensional de números enteros y luego 
    calcule la suma de los elementos pares por un lado y la suma de los elementos impares 
    por otro. 
*/

namespace programacion2_semana7_arrays
{
    internal class SumaDeParesAndImpares
    {
        //Instanciamos una variable global privada que es una instancia de la clase mostrar
        private Mostrar _mostrar = new Mostrar();   
        public void MainSumaDeParesAndImpares()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                .#####...##..##...####...######.
                .##..##..##..##..##........##...
                .#####...##..##...####.....##...
                .##..##..##..##......##....##...
                .##..##...####....####.....##...
                ................................
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            //Pedimos al usuario ingrese la longitud del arreglo 
            Console.Write("\nIndique longitud del arreglo: ");
            //Convertimos el dato enviado por el usuario por un numero enteros
            int longitud = int.Parse(Console.ReadLine());

            //Declaramos e inicializamos una variable enteros
            double[] enteros = new double[longitud];
            //Declaramos una variable de tipo entero que inicializa con 0
            int indice = 0;

            //Creamos un bucle infinito
            for (; ; )
            {
                //Verificamos si el indice es igual a la longitud
                if (indice == longitud)
                {
                    //Declaramos e inicializamos las variables de numeros pares e impares
                    double sumaImpares = 0;
                    double sumaPares = 0;

                    //Recorremos el arreglo
                    for (int i = 0; i < enteros.Length; i++)
                    {
                        //Comprobamos si el valor es impar
                        if (enteros[i] % 2 != 0)
                        {
                            //Sumamos los numeros impares
                            sumaImpares += enteros[i];
                        }

                        //Comprobamos si el numero es par
                        if (enteros[i] % 2 == 0)
                        {
                            //Sumamos los numeros pares
                            sumaPares += enteros[i];
                        }
                    }

                    //Mostramos algunos mensajes de exito
                    this._mostrar.MostrarMensaje($"\nLa suma de los numeros impares es: {sumaImpares}", this._mostrar.MENSAJE_POSITIVO);
                    this._mostrar.MostrarMensaje($"\nLa suma de los numeros pares es: {sumaPares}", this._mostrar.MENSAJE_POSITIVO);
                    
                    //Acabos con el transcurso del programa
                    break;
                }
                
                //Pedimos al usuario que digite un entero
                Console.Write($"\n({indice + 1}) Ingrese un numero entero: \n");
                //Convertimos los valore y principios
                double numero = double.Parse(Console.ReadLine());

                // :v
                enteros[indice] = numero;
                //Devolvemos los valore scorrespdondientes
                indice++;
            }

        }
    }
}
