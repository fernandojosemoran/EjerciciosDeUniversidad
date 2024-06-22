using CuentaDeBanco.config;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.Banco
{
    public class SwitcherBuscarCuentaBanco
    {
        static private BancoRepository repository = new BancoRepositoryImpl();
        static public void BuscarCuenta(int indice)
        {
            switch (indice)
            {
                case 1:
                    Advertencias.AdvertenciaPedirInformacionRelevante("Ingrese nombre del cliente: ");
                    string nombre = Console.ReadLine().Trim();
                    nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

                    repository.BuscarCuenta(nombre);
                    break;
            }
        }
    }
}
