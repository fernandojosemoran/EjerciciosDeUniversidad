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
    internal class BancoRepositoryImpl : BancoRepository
    {
        private BancoDatasourceImpl datasource = new BancoDatasourceImpl();

        public override void BuscarCuenta(string nombreDeCliente)
        {
            datasource.BuscarCuenta(nombreDeCliente);
        }

        public override bool ExisteCuenta(CuentaEntity cuenta)
        {
            return datasource.ExisteCuenta(cuenta);
        }
    }
}
