using CuentaDeBanco.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.menus
{
    public class Switcher
    {
        public static void MenuPrincipal(int indiceMenuPrincipal)
        {
            switch (indiceMenuPrincipal)
            {
                case 1:
                    SwitcherMenuCuenta.MenuCuenta();
                    break;
                case 2:
                    SwitcherMenuBanco.MenuBanco();
                    break;
                case 3:
                    SwitcherMenuCliente.MenuCliente();
                    break;
                case 4:
                    SwitcherMenuAtm.MenuAtm();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }


        }
    }
}
