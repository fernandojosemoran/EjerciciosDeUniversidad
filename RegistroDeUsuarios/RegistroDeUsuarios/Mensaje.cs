using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuarios
{
    public class Mensaje
    {
        static public void MensajePositivo(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\n[+] {mensaje}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        static public void MensajeNegativo(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n[-] {mensaje}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void MensajeInformativo(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n[?] {mensaje}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void MensajeDeCabecera(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n[*] {mensaje}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
