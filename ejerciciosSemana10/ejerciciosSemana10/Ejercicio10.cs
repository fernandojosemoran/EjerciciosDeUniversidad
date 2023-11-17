using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Calcule el peso de un objeto considerando los valores de dos variables que deben ser ingresados.
M = Masa

G = Gravedad

Fórmula P = M * G

El valor de la gravedad debe ser declarado como constante con valor de 9.8
*/

namespace ejerciciosSemana10
{
    internal class Ejercicio10
    {
        static public void EjercicioDiez()
        {

            ConsoleColor[] cc = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = cc[10];

            Console.WriteLine("              .,-:;//;:=, 				    ");
            Console.WriteLine("          . :H@@@MM@M#H/.,+%;,			    ");
            Console.WriteLine("       ,/X+ +M@@M@MM%=,-%HMMM@X/,			");
            Console.WriteLine("     -+@MM; $M@@MH+-,;XMMMM@MMMM@+-		    ");
            Console.WriteLine("    ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.		");
            Console.WriteLine("  ,%MM@@MH ,@%=             .---=-=:=,.		");
            Console.WriteLine("  =@#@@@MX.,                -%HX$$%%%:;		");
            Console.WriteLine(" =-./@M@M$                   .;@MMMM@MM:		");
            Console.WriteLine(" X@/ -$MM/                    . +MM@@@M$		");
            Console.WriteLine(",@M@H: :@:                    . =X#@@@@-		");
            Console.WriteLine(",@@@MMX, .                    /H- ;@M@M=		");
            Console.WriteLine(".H@@@@M@+,                    %MM+..%#$.		");
            Console.WriteLine(" /MMMM@MMH/.                  XM@MH; =;		");
            Console.WriteLine("  /%+%$XHH@$=              , .H@@@@MX,		");
            Console.WriteLine("   .=--------.           -%H.,@@@@@MX,		");
            Console.WriteLine("   .%MM@@@HHHXX$$$%+- .:$MMX =M@@MM%.		");
            Console.WriteLine("     =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=		    ");
            Console.WriteLine("       =%@M@M#@$-.=$@MM@@@M; %M%=			");
            Console.WriteLine("         ,:+$+-,/H#MMMMMMM@= =,			    ");
            Console.WriteLine("               =++%%%%+/:-.				    ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nIngrese una maza en (kg)");
            double masa = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            const double gravedad = 9.8;

            double peso = masa * gravedad;
            Console.ForegroundColor = cc[12];
            Console.WriteLine("\nEl peso del objecto es: {0} N", peso);
            Console.ReadKey();
        }
    }
}
