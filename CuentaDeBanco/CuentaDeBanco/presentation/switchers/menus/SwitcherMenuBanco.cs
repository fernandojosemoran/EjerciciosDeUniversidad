using CuentaDeBanco.config;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using CuentaDeBanco.presentation.switchers.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.menus
{
    public class SwitcherMenuBanco
    {
        static public void MenuBanco()
        {
            Menus.MostrarMenu(MenuType.BANCO, Cabeceras.BANCO);

            Advertencias.AdvertenciaPedirInformacionRelevante("Seleccione un indice: ");

            if (int.TryParse(Console.ReadLine(), out int indice)) {
                SwitcherBuscarCuentaBanco.BuscarCuenta(indice);
            }
            else
            {
                Advertencias.AdvertenciaNegativo("Indice no es valido");
            }
        }
    }
}
