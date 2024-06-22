using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.config
{
    internal class AppConfig
    {
        static public readonly string AplicationName = "Cajero Automatico";
        static public readonly int AtmResponseDelay = 2000; // dos segundos de respuesta

        static public SimuladorDataBaseBanco Db = new SimuladorDataBaseBanco();
        static public ConsoleColor TemaDeErrores = ConsoleColor.Red;
        static public ConsoleColor TemaDeSolicitudesCorrectas = ConsoleColor.Green;
        static public ConsoleColor TemaMensajeDeAlerta = ConsoleColor.Magenta;
        static public ConsoleColor TemaInformacionRelevate = ConsoleColor.Cyan;
       
        static public void Banner()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
               .aMMMb  dMMMMb dMMMMMP dMMMMMP .aMMMb dMMMMMMP 
              dMP""dMP dMP""dMP    dMP dMP     dMP""VMP   dMP    
             dMP dMP dMMMMK""    dMP dMMMP   dMP       dMP     
            dMP.aMP dMP.aMFdK .dMP dMP     dMP.aMP   dMP      
            VMMMP"" dMMMMP"" VMMMP"" dMMMMMP  VMMMP""   dMP 

               .aMMMb  dMMMMb  dMP dMMMMMP dMMMMb dMMMMMMP dMMMMMP dMMMMb 
              dMP""dMP dMP.dMP amr dMP     dMP dMP   dMP   dMP     dMP VMP 
             dMP dMP dMMMMK"" dMP dMMMP   dMP dMP   dMP   dMMMP   dMP dMP  
            dMP.aMP dMP""AMF dMP dMP     dMP dMP   dMP   dMP     dMP.aMP   
            VMMMP"" dMP dMP dMP dMMMMMP dMP dMP   dMP   dMMMMMP dMMMMP""  

                dMMMMb  dMMMMb  .aMMMb  .aMMMMP dMMMMb  .aMMMb  dMMMMMMMMb dMMMMMMMMb dMP dMMMMb  .aMMMMP 
               dMP.dMP dMP.dMP dMP""dMP dMP""    dMP.dMP dMP""dMP dMP""dMP""dMPdMP""dMP""dMPamr dMP dMP dMP""     
              dMMMMP"" dMMMMK"" dMP dMP dMP MMP""dMMMMK"" dMMMMMP dMP dMP dMPdMP dMP dMPdMP dMP dMP dMP MMP""  
             dMP     dMP""AMF dMP.aMP dMP.dMP dMP""AMF dMP dMP dMP dMP dMPdMP dMP dMPdMP dMP dMP dMP.dMP    
            dMP     dMP dMP  VMMMP""  VMMMP"" dMP dMP dMP dMP dMP dMP dMPdMP dMP dMPdMP dMP dMP  VMMMP""                                                                                          ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
