using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.config
{
    public class Advertencias
    {
        static public void AdvertenciaPositiva(string mensaje)
        {
            Console.ForegroundColor = AppConfig.TemaDeSolicitudesCorrectas;
            Console.WriteLine($"\n[+] {mensaje}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void AdvertenciaNegativo(string mensaje)
        {
            Console.ForegroundColor = AppConfig.TemaDeErrores;
            Console.WriteLine($"\n[x] {mensaje}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void AdvertenciaAlerta(string mensaje)
        {
            Console.ForegroundColor = AppConfig.TemaMensajeDeAlerta;
            Console.WriteLine($"\n[!] {mensaje}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static public void AdvertenciaPedirInformacionRelevante(string mensaje)
        {
            Console.ForegroundColor = AppConfig.TemaInformacionRelevate;
            Console.Write($"\n[!] {mensaje}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
