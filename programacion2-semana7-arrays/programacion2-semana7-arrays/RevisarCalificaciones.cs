using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion2_semana7_arrays
{
    public class RevisarCalificaciones
    {
        private static void MostrarBanner()
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
            MostrarBanner();

            Console.Write("Ingrese cantidad de calificaciones:\n");
            int cantidadDeCalificaciones = int.Parse(Console.ReadLine());

            double[] calificaciones = new double[cantidadDeCalificaciones]; // Inicializar el arreglo con la cantidad de calificaciones especificada
            double promedio = 0;

            void PedirCalificaciones()
            {
                for (int iterador = 0; iterador < cantidadDeCalificaciones; iterador++)
                {
                    Console.WriteLine($"\nIngrese calificación {(iterador + 1)}:");
                    double calificacion = double.Parse(Console.ReadLine());

                    calificaciones[iterador] = calificacion;
                    promedio += calificacion;
                }
            }

            void MostrarInformacion()
            {
                //Si existen calificaciones
                if (calificaciones.Length > 0)
                {
                    // Modificamos el valor de la variable promedia y calculamos el promedio
                    promedio = promedio / calificaciones.Length;

                    //Mostramos los datos exigidos
                    Console.WriteLine($"\nLa calificacion mas alta es: {calificaciones.Max()}");
                    Console.WriteLine($"La calificacion mas baja es: {calificaciones.Min()}");
                    Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
                }
                else
                {
                    Console.WriteLine("No se ingresaron calificaciones.");
                }
            }

            PedirCalificaciones();
            MostrarInformacion();
            Console.ReadKey();
        }
    }
}
