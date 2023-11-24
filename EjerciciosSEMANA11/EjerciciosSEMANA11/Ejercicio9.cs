using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Los 20 empleados de una fábrica trabajan en dos turnos: diurno o nocturno. se 
desea calcular el salario diario de cada uno de los empleados de acuerdo con los 
siguientes puntos:
la tarifa de horas diurnas es de $5 - la tarifa de horas nocturnas es de $10
caso de ser domingo, la tarifa se pagará en $10 en el turno diurno y $20 en el 
turno nocturno. 
*/

namespace EjerciciosSEMANA11
{
    internal class Ejercicio9
    {
        public static void EjercicioNueve()
        {
            Console.Title = "Calcular salario segun los turnos de horario";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                                                         ___			    ");
            Console.WriteLine("                                                       .~))>>			    ");
            Console.WriteLine("                                                      .~)>>			        ");
            Console.WriteLine("                                                    .~))))>>>			    ");
            Console.WriteLine("                                                  .~))>>             ___	    ");
            Console.WriteLine("                                                .~))>>)))>>      .-~))>> 	");
            Console.WriteLine("                                              .~)))))>>       .-~))>>)>	    ");
            Console.WriteLine("                                            .~)))>>))))>>  .-~)>>)>		    ");
            Console.WriteLine("                        )                 .~))>>))))>>  .-~)))))>>)>		    ");
            Console.WriteLine("                     ( )@@*)             //)>))))))  .-~))))>>)>			    ");
            Console.WriteLine("                   ).@(@@               //))>>))) .-~))>>)))))>>)>		    ");
            Console.WriteLine("                 (( @.@).              //))))) .-~)>>)))))>>)>			    ");
            Console.WriteLine("               ))  )@@*.@@ )          //)>))) //))))))>>))))>>)>			    ");
            Console.WriteLine("            ((  ((@@@.@@             |/))))) //)))))>>)))>>)>			    ");
            Console.WriteLine("           )) @@*. )@@ )   (\\_(\\-\b  |))>)) //)))>>)))))))>>)>			    ");
            Console.WriteLine("         (( @@@(.@(@ .    _/`-`  ~|b |>))) //)>>)))))))>>)>			        ");
            Console.WriteLine("          )* @@@ )@*     (@) (@)  /\b|))) //))))))>>))))>>				    ");
            Console.WriteLine("        (( @. )@( @ .   _/       /  \b)) //))>>)))))>>>_._				    ");
            Console.WriteLine("         )@@ (@@*)@@.  (6,   6) / ^  \b)//))))))>>)))>>   ~~-.			    ");
            Console.WriteLine("      ( @jgs@@. @@@.*@_ ~^~^~, /\\  ^  \b/)>>))))>>      _.     `,		    ");
            Console.WriteLine("       ((@@ @@@*.(@@ .   \\^^^/' (  ^   \b)))>>        .'         `,		    ");
            Console.WriteLine("        ((@@).*@@ )@ )    `-'   ((   ^  ~)_          /             `,		");
            Console.WriteLine("          (@@. (@@ ).           (((   ^    `\\        |               `.	    ");
            Console.WriteLine("            (*.@*              / ((((        \\        \\      .         `.	");
            Console.WriteLine("                              /   (((((  \\    \\    _.-~\\     Y,         ;	");
            Console.WriteLine("                             /   / (((((( \\    \\.-~   _.`' _.- ~`,       ; ");
            Console.WriteLine("                            /   /   `(((((()    )    (((((~      `,     ;	");
            Console.WriteLine("                          _/  _/      `'' /   / '                  ;     ;	");
            Console.WriteLine("                      _.-~_.-~           /  /'                _.-~   _.'	    ");
            Console.WriteLine("                    ((((~~              / /'              _.-~ __.--~		");
            Console.WriteLine("                                       ((((          __.-~ _.-~			    ");
            Console.WriteLine("                                                   .'   .~~			        ");
            Console.WriteLine("                                                   :    ,'			        ");
            Console.WriteLine("                                                   ~~~~~			          \n");
            Console.ForegroundColor = ConsoleColor.White;

            // le pedimos al usuario que ingrese la cantidad de horas
            Console.Write("[?] Ingrese cantidad de horas a trabajar: ");
            // convertimos el valor dado por el usuario en numero
            int cantidadDeHorasPorDia = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            // declaramos y inicializamos las variables necesarias
            const int cantidadDeEmpleados = 20;
            const int valorDeHorasDiurnas = 5;
            const int valorDeHorasDiurnasLosDomingos = 10;
            const int valorDeHorasNocturnas = 10;
            const int valorDeHorasNocturnasLosDomingos = 20;

            // hacemos calculos matematicos para los salarios
            double totalPorHorasDiurnas = cantidadDeHorasPorDia * valorDeHorasDiurnas; // calculamos el salario para las horas diurnas
            double totalPorHorasDiurnasLosDomingos = cantidadDeHorasPorDia * valorDeHorasDiurnasLosDomingos; // calculamos el salario para las horas diurnas en los domingos

            double totalPorHorasNocturnas = cantidadDeHorasPorDia * valorDeHorasNocturnas; // calculamos el salario para las horas nocturnas
            double totalPorHorasNocturnasLosDomingos = cantidadDeHorasPorDia * valorDeHorasNocturnasLosDomingos; // calculamos el salario para las horas nocturnas en los domingos

            // asignamos unas cabeceras para los datos 
            Console.WriteLine("CantidadEmpleados\tHorasNocturnas\tHorasDiurnas\tHorasNocturnasLosDomingos\tHorasDiurnasLosDomingos");

            Console.ForegroundColor = ConsoleColor.Green;
            // mostramos los datos
            Console.WriteLine(
                $"{cantidadDeEmpleados}\t\t\t" +
                $"{totalPorHorasNocturnas}\t\t" +
                $"{totalPorHorasDiurnas}\t\t" +
                $"{totalPorHorasNocturnasLosDomingos}\t\t\t\t" +
                $"{totalPorHorasDiurnasLosDomingos}"
            );
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
