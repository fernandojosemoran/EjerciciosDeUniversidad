using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Crea una lista de enteros y agrega 5 elementos a ella. Luego, encuentra
    la cantidad de elementos en la lista que son mayores que 10 
*/

namespace EjerciciosProgramacionllDespuesDeSemanaSanta.ejercicios
{
    internal class EncontrarNumerosMayoresQueDiez
    {
        public static void MainEncontrarNumerosMayoresQueDiez()
        {
            Console.Title = "Encontrar Numeros Mayores de 10";
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
                                                                                                                                                   
@@@@@@@   @@@ @@@  @@@@@@@  @@@  @@@   @@@@@@   @@@  @@@     @@@   @@@@@@      @@@@@@@  @@@  @@@  @@@@@@@@     @@@  @@@  @@@  @@@  @@@   @@@@@@@@  
@@@@@@@@  @@@ @@@  @@@@@@@  @@@  @@@  @@@@@@@@  @@@@ @@@     @@@  @@@@@@@      @@@@@@@  @@@  @@@  @@@@@@@@     @@@  @@@  @@@  @@@@ @@@  @@@@@@@@@  
@@!  @@@  @@! !@@    @@!    @@!  @@@  @@!  @@@  @@!@!@@@     @@!  !@@            @@!    @@!  @@@  @@!          @@!  !@@  @@!  @@!@!@@@  !@@        
!@!  @!@  !@! @!!    !@!    !@!  @!@  !@!  @!@  !@!!@!@!     !@!  !@!            !@!    !@!  @!@  !@!          !@!  @!!  !@!  !@!!@!@!  !@!        
@!@@!@!    !@!@!     @!!    @!@!@!@!  @!@  !@!  @!@ !!@!     !!@  !!@@!!         @!!    @!@!@!@!  @!!!:!       @!@@!@!   !!@  @!@ !!@!  !@! @!@!@  
!!@!!!      @!!!     !!!    !!!@!!!!  !@!  !!!  !@!  !!!     !!!   !!@!!!        !!!    !!!@!!!!  !!!!!:       !!@!!!    !!!  !@!  !!!  !!! !!@!!  
!!:         !!:      !!:    !!:  !!!  !!:  !!!  !!:  !!!     !!:       !:!       !!:    !!:  !!!  !!:          !!: :!!   !!:  !!:  !!!  :!!   !!:  
:!:         :!:      :!:    :!:  !:!  :!:  !:!  :!:  !:!     :!:      !:!        :!:    :!:  !:!  :!:          :!:  !:!  :!:  :!:  !:!  :!:   !::  
 ::          ::       ::    ::   :::  ::::: ::   ::   ::      ::  :::: ::         ::    ::   :::   :: ::::      ::  :::   ::   ::   ::   ::: ::::  
 :           :        :      :   : :   : :  :   ::    :      :    :: : :          :      :   : :  : :: ::       :   :::  :    ::    :    :: :: :   
                                                                                                                                                                                                             
            ");
            Console.ForegroundColor = ConsoleColor.Gray;

            List<int> enteros = new List<int>() { 1,10,20,30,40 };
            List<int> mayoresDeDiez = new List<int>();

            string listaDeNumeros = "";

            foreach (var item in enteros)
            {
                listaDeNumeros += item + ", ";
                if (item > 10)
                {
                    mayoresDeDiez.Add(item);    
                }
            }

            Console.WriteLine("\nLista de numeros\n");
            Console.WriteLine(listaDeNumeros);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nLos numeros mayores de Diez son: \n");
            Console.ForegroundColor = ConsoleColor.Gray;

            string listaDeNuMerosMayoresDeDiez = "";
            foreach (var item in mayoresDeDiez)
            {
                listaDeNuMerosMayoresDeDiez += item + ", ";
            }

            Console.WriteLine(listaDeNuMerosMayoresDeDiez);
        }
    }
}
