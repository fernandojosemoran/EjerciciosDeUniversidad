using CuentaDeBanco.config;
using CuentaDeBanco.domain.datasources;
using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.datasources
{
    internal class CuentaDatasourceImpl : CuentaDatasource
    {
        public override void VerCuentas()
        {
            // se que no es muy seguro exponer estos datos, pero es para que se miren los cambios realizados
            for (int i = 0; i < AppConfig.Db.getCuentas().Count; i++)
            {
                Console.WriteLine($@"
                    id: {AppConfig.Db.getCuentas()[i].getId()}
                    saldo: {AppConfig.Db.getCuentas()[i].getSaldo()}
                    cliente: [
                        clienteId: {AppConfig.Db.getCuentas()[i].getCliente().getIdCuenta()}
                        nombre: {AppConfig.Db.getCuentas()[i].getCliente().getNombre()}
                        tarjeta: [
                            tarjetaId: {AppConfig.Db.getCuentas()[i].getCliente().GetTarjeta().getId()}
                            numeroDeTarjeta: {AppConfig.Db.getCuentas()[i].getCliente().GetTarjeta().getCodigo()}
                            codigoDeSegutidad: {AppConfig.Db.getCuentas()[i].getCliente().GetTarjeta().getCodigoSeguridad()}
                            expiracion: {AppConfig.Db.getCuentas()[i].getCliente().GetTarjeta().getFechaExpiracion()}
                        ]
                    ],
                "
                );
            }
        }
    }
}
