using CuentaDeBanco.config;
using CuentaDeBanco.presentation.switchers.Atm;
using CuentaDeBanco.presentation.switchers.Cuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.menus
{
    public class SwitcherMenuAtm
    {
        static public void MenuAtm()
        {
                Menus.MostrarMenu(MenuType.ATM, Cabeceras.ATM);

                Advertencias.AdvertenciaPedirInformacionRelevante("Seleccione un indice: ");

                if ((int.TryParse(Console.ReadLine(), out int indice)))
                {
                    switch (indice)
                    {
                        case 1:
                            SwitcherSolicitarPingAtm.SolicitarPing();
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
