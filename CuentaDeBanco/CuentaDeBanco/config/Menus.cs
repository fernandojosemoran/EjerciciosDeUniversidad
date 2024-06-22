using CuentaDeBanco.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CuentaDeBanco.config
{
    internal class Menus
    {
        static private List<string> listaMenuCliente = new List<string>()
        {
            "Ver saldo",
            "Procesar transacion"
        };

        static private List<string> listaSubMenuClienteProcesarTransacion = new List<string>()
        {
          "Depositar",
          "Retirar",
        };


        static private List<string> listaMenuPrincipal = new List<string>()
        {
            "Cuenta",
            "Banco",
            "Cliente",
            "ATM",
            "Limpiar pantalla"
        };

        static private List<string> listaMenuBanco = new List<string>()
        {
            "Buscar cliente"
        };

        static private List<string> listaMenuCuenta = new List<string>()
        {
            "Ver cuentas"
        };

        // varias opciones de la maquina atm estan implementadas internamente mediante se use el programa.
        static private List<string> listaMenuAtm = new List<string>() 
        {
            "Solicitar ping"
        };

        static public List<string> GetMenuPrincipal { get { return listaMenuPrincipal; } }
        static public List<string> GetListaMenuBanco { get { return listaMenuBanco; } }
        static public List<string> GetListaMenuCliente { get { return listaMenuCliente; } }
        static public List<string> GetListaSubMenuClienteProcesarTransacion { get { return listaSubMenuClienteProcesarTransacion; } }
        static public List<string> GetListaMenuCuenta { get { return listaMenuCuenta; } }

        static public void MostrarMenu(string tipoDeMenu, string cabecera = "Acciones")
        {
            List<string> actionList = new List<string>();

            switch (tipoDeMenu)
            {
                case "Cuenta":
                    actionList = listaMenuCuenta;
                    break;
                case "Banco":
                    actionList = listaMenuBanco;
                    break;
                case "Cliente":
                    actionList = listaMenuCliente;
                    break;
                case "SubMenuClienteProcesarTransacciones":
                    actionList = listaSubMenuClienteProcesarTransacion;
                    break;
                case "Atm":
                    actionList = listaMenuAtm;
                    break;
                case "Acciones":
                    actionList = listaMenuPrincipal;
                    break;
                default:
                    Advertencias.AdvertenciaNegativo("Error menu no encontrado");
                    break;
            }

            CrearMenu(actionList, cabecera);
        }

        static private void CrearMenu(List<string> actionList, string cabecera)
        {
            int columnWidth = 0;
            int index = 1;

            Console.WriteLine("\n");

            foreach (var action in actionList)
            {
                string indexedAction = $"({index}) {action}";
                if (indexedAction.Length > columnWidth)
                {
                    columnWidth = indexedAction.Length;
                }
                index++;
            }

            Console.WriteLine("| {0,-" + columnWidth + "} |", cabecera);
            Console.WriteLine(new string('-', columnWidth + 4)); 

            index = 1;
            foreach (var action in actionList)
            {
                string indexedAction = $"({index}) {action}";
                Console.WriteLine("| {0,-" + columnWidth + "} |", indexedAction);
                index++;
            }

            Console.WriteLine("\n");
        }
    }

    class MenuType
    {
        //static public readonly string atm = "atm";
        static public readonly string CUENTA = "Cuenta";
        static public readonly string CLIENTE = "Cliente";
        static public readonly string SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES = "SubMenuClienteProcesarTransacciones";
        static public readonly string BANCO = "Banco";
        static public readonly string MENU_PRINCIPAL = "Acciones";
        static public readonly string ATM = "Atm";
    }

    class Cabeceras
    {
        public static readonly string ACCIONES_PRINCIPALES = "Acciones Principales";
        //static public readonly string ATM = "Menu ATM";
        static public readonly string CUENTA = "Menu Cuenta";
        static public readonly string CLIENTE = "Menu Cliente";
        static public readonly string SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES = "Sub Menu Cliente Procesar Transaciones";
        static public readonly string BANCO = "Menu Banco";
        static public readonly string ATM = "Menu ATM";
    }
}
