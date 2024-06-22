using CuentaDeBanco.config;
using CuentaDeBanco.presentation.switchers.menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation
{
    public class InitialApp
    {
        static public void Iniciar()
        {
            for (; ; )
            {
                Menus.MostrarMenu(MenuType.MENU_PRINCIPAL, Cabeceras.ACCIONES_PRINCIPALES);
                // necesitas verificar que el usuario no envie un caracter
                Advertencias.AdvertenciaPedirInformacionRelevante("Ingresa un índice de las acciones: ");

                if (int.TryParse(Console.ReadLine(), out int indiceMenuPrincipal))
                {
                    EjecutarMenuPrincipal(indiceMenuPrincipal);
                }
                else
                {
                    Advertencias.AdvertenciaNegativo("Entrada no válida. Ingresa un número.");
                }
            }
        }

        static private void EjecutarMenuPrincipal(int indice)
        {
            // vericamos que el indice dado por el usuario no sea menor de 1 y mayor a la cantidad de acciones
            if (indice >= 1 && indice <= Menus.GetMenuPrincipal.Count)
            {
                Switcher.MenuPrincipal(indice);
            }
            else
            {
                Advertencias.AdvertenciaNegativo("El índice es inválido.");
            }
        }
    }
}
