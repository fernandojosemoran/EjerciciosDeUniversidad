using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.datasources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.repositories
{
    internal class ClienteRepositoryImpl : ClienteRepository
    {
        private ClienteDatasourceImpl datasource = new ClienteDatasourceImpl();

        public override void Depositar(CuentaEntity cuenta)
        {
            datasource.Depositar(cuenta);
        }

        public override void MostrarSaldoActual(string nombreDeCliente)
        {
            datasource.MostrarSaldoActual(nombreDeCliente);
        }

        public override void Retirar(CuentaEntity cuenta)
        {
            datasource.Retirar(cuenta);   
        }
    }
}
