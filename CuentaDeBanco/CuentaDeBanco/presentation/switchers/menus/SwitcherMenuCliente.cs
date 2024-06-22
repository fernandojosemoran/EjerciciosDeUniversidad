using CuentaDeBanco.config;
using CuentaDeBanco.presentation.switchers.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.menus
{
    public class SwitcherMenuCliente
    {
        static public void MenuCliente()
        {
            Menus.MostrarMenu(MenuType.CLIENTE, Cabeceras.CLIENTE);

            Advertencias.AdvertenciaPedirInformacionRelevante("Seleccione un indice: ");

            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                switch (indice)
                {
                    case 1:
                        SwitcherMostrarSaldoCliente.MostrarSaldo();
                        break;
                    case 2:
                        SubMenuProcesarTransaciones();
                        break;
                    default:
                        Advertencias.AdvertenciaNegativo("Indice no es valido");
                        break;
                }
            }
            else
            {
                Advertencias.AdvertenciaNegativo("Se solicito un indice y se recibio un caracter");  
            }
        }

        static private void SubMenuProcesarTransaciones()
        {
            Menus.MostrarMenu(MenuType.SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES, Cabeceras.SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES);

            Advertencias.AdvertenciaPedirInformacionRelevante("Seleccione un indice: ");

            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                switch (indice)
                {
                    case 1:
                        SwitcherDepositarCliente.Depositar();
                        break;
                    case 2:
                        SwitcherRetirarCliente.Retirar();
                        break;
                    default:
                        Advertencias.AdvertenciaNegativo("Indice no valido");
                        break;
                }
            }
            else
            {
                Advertencias.AdvertenciaNegativo("Se solicito un indice y se recibio un caracter");
            }
        }
    }
}
