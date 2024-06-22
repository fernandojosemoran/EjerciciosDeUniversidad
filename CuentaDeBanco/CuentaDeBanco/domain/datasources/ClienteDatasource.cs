using CuentaDeBanco.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.datasources
{
    public abstract class ClienteDatasource
    {
        public abstract void MostrarSaldoActual(string nombreDeCliente);

        public abstract void Retirar(CuentaEntity cuenta);
        public abstract void Depositar(CuentaEntity cuenta);
    }
}
