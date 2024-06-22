using CuentaDeBanco.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.datasources
{
    public abstract class BancoDatasource
    {
        public abstract void BuscarCuenta(string nombreDeCliente);
        public abstract bool ExisteCuenta(CuentaEntity cuenta);
    }
}
