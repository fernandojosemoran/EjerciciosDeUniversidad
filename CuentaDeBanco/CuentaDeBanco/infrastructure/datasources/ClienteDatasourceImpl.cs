using CuentaDeBanco.config;
using CuentaDeBanco.domain.datasources;
using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.helpers;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// el metodo interacturarConAtm no fue implmentado porque el programa interactua con el automaticamente a la hora de depositar y retirar por ejemplo

namespace CuentaDeBanco.infrastructure.datasources
{
    internal class ClienteDatasourceImpl : ClienteDatasource
    {
        private AtmRepository atmRepository = new AtmRepositoryImpl(); 
        public override void Depositar(CuentaEntity cuenta)
        {
            double saldo;

            Advertencias.AdvertenciaPedirInformacionRelevante("Quieres insertar la tarjeta? (y/n): ");
            string respuestaYesOrNo = Console.ReadLine().Trim().ToLower();

            // if se pone dentro del case se ejecuta varias veces porque esta dentro del bucle
            if (respuestaYesOrNo == "y")
            {
                atmRepository.InsertarTarjeta(true);
                atmRepository.ProcesarTransacion();
                Thread.Sleep(AppConfig.AtmResponseDelay); // simula el tiempo de la respuesta del servidor
            }

            for (int i = 0; i < AppConfig.Db.getCuentas().Count(); i++)
            {
                switch (respuestaYesOrNo)
                {
                    case "y":
                        string nombreDeCliente = AppConfig.Db.getCuentas()[i].getCliente().getNombre();

                        if (nombreDeCliente == cuenta.getCliente().getNombre())
                        {
                            saldo = AppConfig.Db.getCuentas()[i].getSaldo() + cuenta.getSaldo();
                            AppConfig.Db.getCuentas()[i].setSaldo(saldo);
                            Advertencias.AdvertenciaPositiva("Saldo depositado exitosamente.");
                        }
                        atmRepository.InsertarTarjeta(false);
                        break;
                    case "n":
                        break;
                    default:
                        Advertencias.AdvertenciaNegativo("Error la respuesta no fue y o no");
                        break;
                }
            }
        }

        public override void MostrarSaldoActual(string nombreDeCliente)
        {
            if (VerificarIfExisteCuenta.ExisteCuenta(nombreDeCliente))
            {
                Advertencias.AdvertenciaPositiva("Consulta de saldo realizada exitosamente");
                CuentaEntity cuenta = EncontrarCuenta(nombreDeCliente);
                Console.WriteLine($"\nEl saldo del cliente {nombreDeCliente} es: L{cuenta.getSaldo()}");
            }
            else
            {
                Advertencias.AdvertenciaNegativo("La cuenta no existe.");
            }

        }

        public override void Retirar(CuentaEntity cuenta)
        {
            double saldo;

            Advertencias.AdvertenciaPedirInformacionRelevante("Quieres insertar la tarjeta? (y/n): ");
            string respuestaYesOrNo = Console.ReadLine().Trim().ToLower();

            // if se pone dentro del case se ejecuta varias veces porque esta dentro del bucle
            if (respuestaYesOrNo == "y")
            {
                atmRepository.InsertarTarjeta(true);
                
                atmRepository.ProcesarTransacion();
                Thread.Sleep(AppConfig.AtmResponseDelay); // simula el tiempo de la respuesta del servidor
            }

            switch (respuestaYesOrNo)
            {
                case "y":
                    foreach (var item in AppConfig.Db.getCuentas())
                    {
                        // TODO: corregir que en vez de hacer transaciones de la cuenta con nombres usar identificadores como los id ya sea de cuenta o de cliente
                        if (item.getCliente().getNombre() == cuenta.getCliente().getNombre())
                        {
                            saldo = item.getSaldo() - cuenta.getSaldo();
                            if (saldo > 0)
                            {
                                item.setSaldo(saldo);
                                Advertencias.AdvertenciaPositiva("Saldo retirado exitosamente.");
                                break;
                            }
                            else
                            {
                                atmRepository.InsertarTarjeta(false);
                                Advertencias.AdvertenciaNegativo("No tines suficiente saldo para retirar.");
                                break;
                            }
                        }

                        atmRepository.InsertarTarjeta(false);
                    }
                    break;
                case "n":
                    break;
                default:
                    Advertencias.AdvertenciaNegativo("Error la respuesta no fue (y) o (no)");
                    break;
            }
        }

        private CuentaEntity EncontrarCuenta(string nombreDeCliente)
        {
            return AppConfig.Db.getCuentas().Find((cuentadb) => cuentadb.getCliente().getNombre() == nombreDeCliente);
        }
    }
}
