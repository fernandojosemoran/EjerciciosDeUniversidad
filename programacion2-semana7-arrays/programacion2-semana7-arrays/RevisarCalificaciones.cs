using System;
using System.Linq;

/*
    Escribe un programa que permita a un maestro ingresar las calificaciones de sus estudiantes y 
    luego calcule el promedio, la calificación más alta y la más baja (Para calcular máxima y mínima 
    hagan uso del método max() y min() que contienen los arreglos). Utiliza un arreglo para 
    almacenar las calificaciones. Al final mostrar en consola la calificación, el promedio. La nota 
    alta y la mas baja.
*/


namespace programacion2_semana7_arrays
{
    public class RevisarCalificaciones
    {
        private static void _MostrarBanner()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("====================");
            Console.WriteLine("===     ====  ==  ==");
            Console.WriteLine("==  ===  ===  ==  ==");
            Console.WriteLine("=  ========        =");
            Console.WriteLine("=  =========  ==  ==");
            Console.WriteLine("=  =========  ==  ==");
            Console.WriteLine("=  ========        =");
            Console.WriteLine("=  =========  ==  ==");
            Console.WriteLine("==  ===  ===  ==  ==");
            Console.WriteLine("===     ============");
            Console.WriteLine("====================\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void MainRevisarCalificaciones()
        {
            _MostrarBanner();

            Console.Write("Ingrese cantidad de calificaciones:\n");
            int cantidadDeCalificaciones = int.Parse(Console.ReadLine());

            //Inicializamos el arreglo con la cantidad de calificaciones especificada
            double[] calificaciones = new double[cantidadDeCalificaciones]; 
            //Creamos una variable que guarde el promedio
            double promedio = 0;

            //Creamos un metodo que muestre las calificaciones
            void PedirCalificaciones()
            {
                //Creamos un bucle for para pedir los datos necesarios al usuario
                for (int iterador = 0; iterador < cantidadDeCalificaciones; iterador++)
                {
                    //Indicamos al usuario que nos de una calificacion
                    Console.Write($"\nIngrese calificación {(iterador + 1)}: ");
                    //Convertimos los datos dados por el usuario en un numero
                    double calificacion = double.Parse(Console.ReadLine());

                    //Guardamos las calificaciones dadas por el usuario
                    calificaciones[iterador] = calificacion;
                    //Sumamos los valores dados por el usuario
                    promedio += calificacion;
                }
            }

            void MostrarInformacion()
            {
                //Si existen calificaciones entonces
                if (calificaciones.Length > 0)
                {
                    //Modificamos el valor de la variable promedia y calculamos el promedio
                    promedio = promedio / calificaciones.Length;

                    //Mostramos los datos exigidos
                    Console.WriteLine($"\nLa calificacion mas alta es: {calificaciones.Max()}");
                    Console.WriteLine($"La calificacion mas baja es: {calificaciones.Min()}");
                    Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
                }
            }

            PedirCalificaciones();
            MostrarInformacion();
            Console.ReadKey();
        }
    }
}
