using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.Cuenta
{
    // se que esta raro el nombre pero queria poner un nombre siguiendo la nomenglatura (switcher + metodo + clase) 
    public class SwitcherVerCuentasCuenta
    {
        static private CuentaRepository repository = new CuentaRepositoryImpl();
        static public void VerCuentas()
        {
            repository.VerCuentas();
        }
    }
}
