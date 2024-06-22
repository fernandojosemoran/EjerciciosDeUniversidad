using CuentaDeBanco.config;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using CuentaDeBanco.presentation.switchers.Cuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.menus
{
    public class SwitcherMenuCuenta
    {
        static private CuentaRepository repository = new CuentaRepositoryImpl();
        public static void MenuCuenta()
        {
            Menus.MostrarMenu(MenuType.CUENTA, Cabeceras.CUENTA);

            Advertencias.AdvertenciaPedirInformacionRelevante("Seleccione un indice: ");

            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                switch (indice)
                {
                    case 1:
                        SwitcherVerCuentasCuenta.VerCuentas();
                        break;
                    default:
                        Advertencias.AdvertenciaNegativo("El indice seleccionado no es valido.");
                        break;
                }
            }
            else
            {
                Advertencias.AdvertenciaNegativo("Indice no es valido");
            }
        }
    }
}
