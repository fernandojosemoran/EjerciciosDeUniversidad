using CuentaDeBanco.config;
using CuentaDeBanco.domain.datasources;
using CuentaDeBanco.domain.entities;
//using CuentaDeBanco.presentation.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.datasources
{
    internal class BancoDatasourceImpl : BancoDatasource
    {
        // metodos del contrato del ejercicio

        public override void BuscarCuenta(string nombreDeCliente)
        {
            CuentaEntity cuentaProbable = AppConfig.Db.getCuentas().Find((cuentadb) => cuentadb.getCliente().getNombre() == nombreDeCliente);

            if (ExisteCuenta(cuentaProbable))
            {
                Advertencias.AdvertenciaPositiva("Consulta realizada exitosamente");
                Console.WriteLine($@"
                    cuenta: [
                        id: {cuentaProbable.getId()}
                        saldo: {cuentaProbable.getSaldo()}
                        cliente: [
                            clienteId: {cuentaProbable.getCliente().getId()}
                            nombre: {cuentaProbable.getCliente().getNombre()}
                            tarjeta: [
                                tarjetaId: {cuentaProbable.getCliente().GetTarjeta().getId()}
                                numeroDeTarjeta: {cuentaProbable.getCliente().GetTarjeta().getCodigoSeguridad()}
                                expiracion: {cuentaProbable.getCliente().GetTarjeta().getFechaExpiracion()}
                            ]
                        ]
                    ],
                ");
                return;
            }
            Advertencias.AdvertenciaPositiva("La cuenta no existe.");
        }

        public override bool ExisteCuenta(CuentaEntity cuenta)
        {
            // TODO: la idea es buscar por id de ser preferente la cuenta y mostrarla en pantalla como cuando observas todas las cuentas existentes
            // este metodo es mas bien verifica si existe la cuenta no la devuelve

            bool existeCuenta = AppConfig.Db.getCuentas().Any(data => data.getCliente().getNombre() == cuenta.getCliente().getNombre());

            return existeCuenta;
        }
    }
}
