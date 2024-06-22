using CuentaDeBanco.domain.entities;
using CuentaDeBanco.infrastructure.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.config
{
    internal class SimuladorDataBaseBanco
    {
        private bool estaTarjetaInsertada = false;
        private bool estaTarjetaEjecutada = false;
        private bool estaAtmProcesandoTransacion = false;

        private List<CuentaEntity> cuentasDB = new List<CuentaEntity>() {
            new CuentaEntity(10000, new ClienteEntity("Fernando",   new TarjetaEntity(new DateTime(2024, 6, 1)))),
            new CuentaEntity(1000, new ClienteEntity("Sergio",      new TarjetaEntity(new DateTime(2024, 7, 1)))),
            new CuentaEntity(2000, new ClienteEntity("Maria",       new TarjetaEntity(new DateTime(2024, 8, 1)))),
            new CuentaEntity(1500, new ClienteEntity("Jose",        new TarjetaEntity(new DateTime(2024, 9, 1)))),
            new CuentaEntity(3000, new ClienteEntity("Lucia",       new TarjetaEntity(new DateTime(2024, 10, 1)))),
            new CuentaEntity(2500, new ClienteEntity("Carlos",      new TarjetaEntity(new DateTime(2024, 11, 1)))),
            new CuentaEntity(4000, new ClienteEntity("Ana",         new TarjetaEntity(new DateTime(2024, 12, 1)))),
            new CuentaEntity(3500, new ClienteEntity("Luis",        new TarjetaEntity(new DateTime(2025, 1, 1)))),
            new CuentaEntity(1200, new ClienteEntity("Elena",       new TarjetaEntity(new DateTime(2025, 2, 1)))),
            new CuentaEntity(2200, new ClienteEntity("Javier",      new TarjetaEntity(new DateTime(2025, 3, 1)))),
            new CuentaEntity(1800, new ClienteEntity("Marta",       new TarjetaEntity(new DateTime(2025, 4, 1)))),
            new CuentaEntity(2700, new ClienteEntity("Sergio",      new TarjetaEntity(new DateTime(2025, 5, 1)))),
            new CuentaEntity(3200, new ClienteEntity("Laura",       new TarjetaEntity(new DateTime(2025, 6, 1)))),
            new CuentaEntity(2900, new ClienteEntity("Raul",        new TarjetaEntity(new DateTime(2025, 7, 1)))),
            new CuentaEntity(2300, new ClienteEntity("Sofia",       new TarjetaEntity(new DateTime(2025, 8, 1)))),
            new CuentaEntity(2400, new ClienteEntity("Pedro",       new TarjetaEntity(new DateTime(2025, 9, 1)))),
            new CuentaEntity(3100, new ClienteEntity("Carmen",      new TarjetaEntity(new DateTime(2025, 10, 1)))),
            new CuentaEntity(2600, new ClienteEntity("Andres",      new TarjetaEntity(new DateTime(2025, 11, 1)))),
            new CuentaEntity(3300, new ClienteEntity("Eva",         new TarjetaEntity(new DateTime(2025, 12, 1)))),
            new CuentaEntity(3700, new ClienteEntity("Manuel",      new TarjetaEntity(new DateTime(2026, 1, 1)))),
            new CuentaEntity(3400, new ClienteEntity("Patricia",    new TarjetaEntity(new DateTime(2026, 2, 1)))),
        };

        public List<CuentaEntity> getCuentas() => cuentasDB;
        public void EliminarCuenta(CuentaEntity cuenta) => cuentasDB.Remove(cuenta);
        public void AgregarCuenta(CuentaEntity cuenta) => cuentasDB.Add(cuenta);

        public bool getEstaTarjetaInsertada() => estaTarjetaInsertada;
        public void setEstaTarjetaInsertada(bool estado) => this.estaTarjetaInsertada = estado;

        public bool getEstaAtmProcesandoTransacion() => this.estaAtmProcesandoTransacion;
        public void setEstaAtmProcesandoTransacion(bool estado) => this.estaAtmProcesandoTransacion = estado;
        public bool getEstaTarjetaEjecutada() => estaTarjetaEjecutada;
        public void setEstaTarjetaEjecutada(bool estado) => this.estaTarjetaEjecutada = estado;

    }
}