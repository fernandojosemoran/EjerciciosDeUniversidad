using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Escribe un programa que permita a un maestro ingresar las calificaciones de sus estudiantes de 
    diferentes asignaturas y luego calcule el promedio, la calificación más alta y la más baja (Para 
    calcular máxima y mínima hagan uso del método max() y min()). Utiliza un Diccionario para 
    almacenar los nombres de los alumnos y una lista para calificaciones. Al final mostrar en 
    consola todo el contenido del diccionario incluyendo, el promedio. La nota alta y la más baja.
*/

namespace Diccionarios
{
    internal class RegistroDeCalificaciones
    {
        public static void MainRegistroDeCalificaciones()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
             .S_SsS_S.    .S_SSSs     .S_sSSs     .S    sSSs_sSSs           .S    S.    .S_SSSs     .S_sSSs    sdSS_SSSSSSbs  
            .SS~S*S~SS.  .SS~SSSSS   .SS~YS%%b   .SS   d%%SP~YS%%b         .SS    SS.  .SS~SSSSS   .SS~YS%%b   YSSS~S%SSSSSP  
            S%S `Y' S%S  S%S   SSSS  S%S   `S%b  S%S  d%S'     `S%b        S%S    S&S  S%S   SSSS  S%S   `S%b       S%S       
            S%S     S%S  S%S    S%S  S%S    S%S  S%S  S%S       S%S        S%S    d*S  S%S    S%S  S%S    S%S       S%S       
            S%S     S%S  S%S SSSS%S  S%S    d*S  S&S  S&S       S&S        S&S   .S*S  S%S SSSS%S  S%S    d*S       S&S       
            S&S     S&S  S&S  SSS%S  S&S   .S*S  S&S  S&S       S&S        S&S_sdSSS   S&S  SSS%S  S&S   .S*S       S&S       
            S&S     S&S  S&S    S&S  S&S_sdSSS   S&S  S&S       S&S        S&S~YSSY%b  S&S    S&S  S&S_sdSSS        S&S       
            S&S     S&S  S&S    S&S  S&S~YSY%b   S&S  S&S       S&S        S&S    `S%  S&S    S&S  S&S~YSY%b        S&S       
            S*S     S*S  S*S    S&S  S*S   `S%b  S*S  S*b       d*S        S*S     S%  S*S    S&S  S*S   `S%b       S*S       
            S*S     S*S  S*S    S*S  S*S    S%S  S*S  S*S.     .S*S        S*S     S&  S*S    S*S  S*S    S%S       S*S       
            S*S     S*S  S*S    S*S  S*S    S&S  S*S   SSSbs_sdSSS         S*S     S&  S*S    S*S  S*S    S&S       S*S       
            SSS     S*S  SSS    S*S  S*S    SSS  S*S    YSSP~YSSY          S*S     SS  SSS    S*S  S*S    SSS       S*S       
                    SP          SP   SP          SP                        SP                 SP   SP               SP        
                    Y           Y    Y           Y                         Y                  Y    Y                Y                                                                                          
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Dictionary<string, List<double>> calificacionesPorAlumno = new Dictionary<string, List<double>>();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n[?] ingrese 'fin' para terminar: \n");
            Console.WriteLine("[?] Ingrese los nombres de estudiante y calificaciones\n");

            while (true)
            {
                Console.Write("[!] Ingrese nombre del estudiante: ");
                string nombre = Console.ReadLine();

                if (nombre.ToLower() == "fin")
                    break;

                Console.Write("\n[?] Separada por espacio cada calificacion si son varias: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                string[] calificacionesStr = Console.ReadLine().Split(' ');
                List<double> calificaciones = new List<double>();

                foreach (string calificacionStr in calificacionesStr)
                {
                    if (double.TryParse(calificacionStr, out double calificacion))
                    {
                        calificaciones.Add(calificacion);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[x] La calificacion ingresada no es valida. Intente de nuevo.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        continue;
                    }
                }

                calificacionesPorAlumno[nombre] = calificaciones;
            }

            Console.WriteLine("\n[+] Calificaciones por alumno:");
            foreach (var item in calificacionesPorAlumno)
            {
                string nombre = item.Key;
                List<double> calificaciones = item.Value;


                Console.ForegroundColor = ConsoleColor.Green;
                //mostramos los datos de la lista sin recorrerlos
                Console.WriteLine($"\n[+] {nombre}: {string.Join(", ", calificaciones)}");
            }

            //Obtenemos el promedio
            double promedio = calificacionesPorAlumno.Values.SelectMany(x => x).Average();

            double calificacionMaxima = calificacionesPorAlumno.Values.SelectMany(x => x).Max();
            double calificacionMinima = calificacionesPorAlumno.Values.SelectMany(x => x).Min();

            Console.WriteLine($"\n(Promedio: {promedio}) (Calificacion mas alta: {calificacionMaxima}) (Calificacion mas baja: {calificacionMinima})");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
