using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.datasources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.repositories
{
    public class AtmRepositoryImpl : AtmRepository
    {
        private AtmDatasourceImpl datasource = new AtmDatasourceImpl();
        public override void EjecutarTarjeta(bool estado)
        {
            datasource.EjecutarTarjeta(estado);
        }

        public override void InsertarTarjeta(bool estado)
        {
            datasource.InsertarTarjeta(estado);
        }

        public override void MostrarMenu()
        {
            datasource.MostrarMenu();
        }

        public override void ObtenerAtmAccion(int indiceDeAccion)
        {

            datasource.ObtenerAtmAccion(indiceDeAccion);
        }

        public override void ProcesarTransacion()
        {
            datasource.ProcesarTransacion();
        }

        public override void SolicitarPing()
        {
            datasource.SolicitarPing();
        }


    }
}
