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
    internal class CuentaRepositoryImpl : CuentaRepository
    {
        private CuentaDatasourceImpl datasource = new CuentaDatasourceImpl();

        public override void VerCuentas()
        {
            datasource.VerCuentas();
        }
    }
}
