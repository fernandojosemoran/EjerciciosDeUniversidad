using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Búsqueda de elemento: 

/*
    Desarrolla un programa que busque un elemento específico en un arreglo 
    bidimensional y muestre su posición (fila y columna) si se encuentra
*/

namespace programacion2_semana7_arrays
{
    internal class BuscarElemento
    {
        //Declaramos y inicializamos variables que seran usadas para las cabeceras
        private string _Colores = "Colores";
        private string _Dias = "Dias";
        private string _Comidas = "Comidas";
        private string _Refrescos = "Refresco";
        private string _Frutas = "Frutas";

        //Instanciamos la clase _mostrar
        private Mostrar _mostrar = new Mostrar();

        //Creamos un arreglo de objectos o arreglos
        private object[,] elementos = new object[3,5]{
            {"rojo",   "lunes",   "pizza",        "pepsi",     "naranja"},
            {"azul",   "martes",  "hamburguesa",  "lipton",    "sandia"},
            {"verde",  "sabado",  "balidas",      "tropical",  "mango"}
        };

        public void MainBuscarElemento()
        {
            Console.Title = "Buscar Elemento";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                       █████                                
                      ░░███                                 
                       ░███   ██████   █████ █████  ██████  
                       ░███  ░░░░░███ ░░███ ░░███  ░░░░░███ 
                       ░███   ███████  ░███  ░███   ███████ 
                 ███   ░███  ███░░███  ░░███ ███   ███░░███ 
                ░░████████  ░░████████  ░░█████   ░░████████
                 ░░░░░░░░    ░░░░░░░░    ░░░░░     ░░░░░░░░ 
            ");

            Console.ForegroundColor = ConsoleColor.Gray;

            //Mostramos todos los elementos existentes
            this.MostrarElementos();

            //Creamos un bucle for infinito que me permita pedir al usuario un nombre de un elemento existente en la lista de elementos
            for (; ; )
            {
                //Le pedimos al usuario que inserte un nombre de elemento existente
                Console.Write("\nEscriba el nombre de el elemento a buscar: ");
                //Guardamos el elemento solicitado
                string elemento = Console.ReadLine();

                //Buscamos el elemento 
                this.BuscarUnElemento(elemento);
            }
        }

        //Creamos un metodo que muestre todos los elementos existentes
        public void MostrarElementos()
        {
            //Mostramos las cabeceras
            Console.WriteLine($"{this._Colores,-3}\t{this._Dias, 7}\t\t{this._Comidas,-10}\t{this._Refrescos,-10}\t{this._Frutas,-10}\n");

            //Recorremos todas las filas de la tabla para mostrar los elementos
            for (int fila = 0; fila < 3; fila++)
            {
                //Mostrar los elementos
                Console.WriteLine($"{this.elementos[fila, 0],-10} {this.elementos[fila, 1],-12} {this.elementos[fila, 2],-15} {this.elementos[fila, 3],-10}\t{this.elementos[fila, 4]}");
            }
        }

        //Creamos un metodo que me permita buscar un elemento
        public void BuscarUnElemento(string elemento)
        {
            //Recorremos la lista de objectos o listas 
            for (int fila = 0; fila < this.elementos.GetLength(0); fila++)
            {
                //Recorremos las sub listas o objectos 
                for (int columna = 0; columna < this.elementos.GetLength(1); columna++)
                {
                    //Verificamos que el producto que el usuario nos entrego sea el que esta en la lista de elementos
                    if (elemento == this.elementos[fila, columna].ToString())
                    {
                        //Si el elemento se encuentra entonces _mostrar un mensaje de exito
                        this._mostrar.MostrarMensaje($"\nEl producto {elemento} se encuentra en la fila ({fila + 1}) y columna {columna + 1}", 0);
                        //Rompemos el bucle for
                        return;
                    }
                }
            }

            //Si el elemento no se encuentra entonces mostramos un mensaje de error
            this._mostrar.MostrarMensaje($"\nEl producto {elemento} no se encuentra en la lista de elementos.", this._mostrar.MENSAJE_NEGATIVO);
        }
    }
}
