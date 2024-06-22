using CuentaDeBanco.config;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.Cliente
{
    internal class SwitcherMostrarSaldoCliente
    {
        static private ClienteRepository repository = new ClienteRepositoryImpl();
        static public void MostrarSaldo()
        {
            Advertencias.AdvertenciaPedirInformacionRelevante("Ingrese nombre de cliente: ");
            string nombre = Console.ReadLine().Trim();
            nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

            repository.MostrarSaldoActual(nombre);
        }
    }
}
