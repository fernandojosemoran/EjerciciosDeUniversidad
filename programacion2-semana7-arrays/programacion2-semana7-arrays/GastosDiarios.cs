using System;
using System.Linq;

/*
    Desarrolla una aplicación que permita a los usuarios ingresar sus gastos diarios y luego calcule 
    el gasto promedio en una semana. Utiliza un arreglo para almacenar los gastos diarios. Al final 
    mostrar en consola el gasto diario y el total del gasto.
*/

namespace programacion2_semana7_arrays
{
    internal class GastosDiarios
    {
        //Declaramos variables globales en la clase y las inicializamos con instancia de las clases necesarias
        private Mostrar mostrar = new Mostrar();
        private Gasto gastos = new Gasto();
        public void MainGastosDiarios()
        { 
            //Creamos un bucle que me permita pedirle al usuario sus gastos recientes
            for (; ; )
            {
                //Le indicamos al usuario que nos otorgue el nuevo gasto
                Console.Write("Ingrese nuevo gasto: ");
                //Convertimos el gasto reciente en un decimal
                double gastoNuevo = double.Parse(Console.ReadLine());

                //Guardamos el gasto reciente
                gastos.SetGastos(gastoNuevo);
                //Limpiamos la terminal
                Console.Clear();

                //Mostramos mensajes indicando los gastos realizados y el promedio total de ellos.
                mostrar.MostrarMensaje($"\nGasto total: {gastos.GetGastos()}", 0);
                mostrar.MostrarMensaje($"Promedio de gastos: {gastos.GetPromedioDeGastos()}\n", 0);
            }
        }
    }

    internal class Gasto
    {
        //Declaramos variables correspondientes para usar en la clase

        //Declaramos y inicializamos la variable gastos en cero 
        private double gastos = 0;

        //Declaramos y inicializamos un arreglo de decimales o enteros 
        private double[] listaDeGastos = new double[0];

        //Asignamos un metodo para modificar la varible de gastos
        public void SetGastos(double gastoNuevo)
        {
            //Crear un nuevo arreglo con un tamano mayor que el arreglo actual
            double[] nuevaListaDeGastos = new double[this.listaDeGastos.Length + 1];

            //Copiamos los elementos del arreglo original al nuevo arreglo
            for (int i = 0; i < this.listaDeGastos.Length; i++)
            {
                nuevaListaDeGastos[i] = this.listaDeGastos[i];
            }

            //Agregar el nuevo gasto al final del nuevo arreglo de gastos
            nuevaListaDeGastos[this.listaDeGastos.Length] = gastoNuevo;

            //Modificamos el valor del arreglo de gastos original al valor del arreglo de gastos nuevos
            this.listaDeGastos = nuevaListaDeGastos;

            //Sumamos el total de gastos y los guardamos en la variable gastos
            this.gastos = this.listaDeGastos.Sum();
        }

        //Creamos un metodo para mostrar los gastos totales
        public double GetGastos()
        {
            //Otorgamos el total de gastos al usuario
            return this.gastos;
        }

        //Declaramos un metodo para mostrar el promedio de gastos 
        public double GetPromedioDeGastos()
        {
            //Otorgamos el promedio de gastos al usuario
            return this.gastos / this.listaDeGastos.Length;
        }
    }
}
