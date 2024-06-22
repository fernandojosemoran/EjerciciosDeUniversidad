using CuentaDeBanco.config;
using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.Banco
{
    public class SwitcherBancoRetirar
    {
        static private double nuevoSaldo = 0;
        static private BancoRepository repository = new BancoRepositoryImpl();
        static public void Retirar()
        {
            CuentaEntity cuenta = SolicitarDatos();

            foreach (var item in AppConfig.Db.getCuentas())
            {
                VericarDatos(item, cuenta);
            }

            repository.Retirar(cuenta);
        }

        static private CuentaEntity SolicitarDatos()
        {
            Console.Write("\nIngrese nombre de cuenta: ");
            string nombre = Console.ReadLine().Trim();
            nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

            Console.Write("\nIngrese saldo a retirar: ");
            double saldo = double.Parse(Console.ReadLine());

            return new CuentaEntity(saldo, new ClienteEntity(nombre));
        }

        static private void VericarDatos(CuentaEntity cuentadb, CuentaEntity cuentaToVerificar)
        {
            // TODO: corregir que en vez de hacer transaciones de la cuenta con nombres usar identificadores como los id ya sea de cuenta o de cliente
            if (cuentadb.getCliente().getNombre() == cuentaToVerificar.getCliente().getNombre())
            {
                nuevoSaldo = cuentadb.getSaldo() - cuentaToVerificar.getSaldo();

                if (nuevoSaldo > 0)
                {
                    cuentadb.setSaldo(nuevoSaldo);
                    Advertencias.AdvertenciaPositiva("Saldo retirado exitosamente.");
                }
                else
                {
                    Advertencias.AdvertenciaNegativo("No tines suficiente saldo para retirar.");
                }
            }
        }
    }
}
