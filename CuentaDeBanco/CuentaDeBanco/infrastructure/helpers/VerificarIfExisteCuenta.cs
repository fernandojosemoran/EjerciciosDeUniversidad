using CuentaDeBanco.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.helpers
{
    public class VerificarIfExisteCuenta
    {
        static public bool ExisteCuenta(string nombreDeCliente)
        {
            // TODO: la idea es buscar por id de ser preferente la cuenta y mostrarla en pantalla como cuando observas todas las cuentas existentes
            // este metodo es mas bien verifica si existe la cuenta no la devuelve

            bool existeCuenta = AppConfig.Db.getCuentas().Any(data => data.getCliente().getNombre() == nombreDeCliente);

            return existeCuenta;
        }
    }
}
