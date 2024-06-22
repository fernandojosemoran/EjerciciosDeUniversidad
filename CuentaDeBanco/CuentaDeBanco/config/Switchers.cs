using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using CuentaDeBanco.presentation.Cuenta;
using CuentaDeBanco.presentation.switchers.menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.config
{
    public class Switchers
    {
         static public AtmRepository atmRepositoryImpl = new AtmRepositoryImpl();
         static public BancoRepository bancoRepositoryImpl = new BancoRepositoryImpl();
         static public CuentaRepository cuentaRepositoryImpl = new CuentaRepositoryImpl();
         static public ClienteRepository clienteRepositoryImpl = new ClienteRepositoryImpl();

        static public void SwitcherDeMenuPrincipal(int indiceMenuPrincipal)
        {
            int indice;

            switch (indiceMenuPrincipal)
            {
                case 1:
                    SwitcherCuenta.MenuCuenta();
                    break;
                case 2:
                    Menus.MostrarMenu(MenuType.BANCO, Cabeceras.BANCO);
                    Console.Write("\nSeleccione un indice: ");
                    indice = int.Parse(Console.ReadLine());
                    SwitcherMenuBanco(indice);
                    break;
                case 3:
                    Menus.MostrarMenu(MenuType.CLIENTE, Cabeceras.CLIENTE);
                    Console.Write("\nSeleccione un indice: ");
                    indice = int.Parse(Console.ReadLine());
                    SwitcherMenuCliente(indice);
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }

        static private void SwitcherMenuBanco(int indiceMenuBanco)
        {
            switch (indiceMenuBanco)
            {
                case 1:
                    Console.Write("\nIngrese nombre del cliente: ");
                    string nombre = Console.ReadLine().Trim();
                    nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

                    bancoRepositoryImpl.BuscarCuenta(nombre);
                    break;
            }
        }

        static private void SwitcherMenuCuenta(int indiceMenuCuenta)
        {
            switch (indiceMenuCuenta)
            {
                case 1:
                    FragmentCuentaDepositar.Depositar(cuentaRepositoryImpl);
                    break;
                case 2:
                    // TODO: indica que te pase un cliente nada mas y compruebas si existe la cuenta

                    FragmentCuentaRetirar.Retirar(cuentaRepositoryImpl);
                    break;
                case 3:
                    FragmentBancoVerCuentas.VerCuentas(cuentaRepositoryImpl);
                    break;
                default:
                    Advertencias.AdvertenciaNegativo("El indice seleccionado no es valido.");   
                    break;
            }
        }

        static private void SwitcherMenuCliente(int indiceMenuCliente)
        {
            switch (indiceMenuCliente)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Menus.MostrarMenu(MenuType.SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES, Cabeceras.SUB_MENU_CLIENTE_PROCESAR_TRANSACIONES);
                    Console.Write("\nSeleccione un indice: ");
                    int indice = int.Parse(Console.ReadLine());
                    break;
            }
        }
    }
}
