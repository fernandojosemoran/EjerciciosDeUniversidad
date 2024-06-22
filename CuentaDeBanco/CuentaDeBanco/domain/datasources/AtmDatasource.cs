using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.datasources
{
    public abstract class AtmDatasource
    {
        public abstract void InsertarTarjeta(bool estado);
        public abstract void EjecutarTarjeta(bool estado);
        public abstract void SolicitarPing();
        public abstract void MostrarMenu();
        public abstract void ProcesarTransacion();
        public abstract void ObtenerAtmAccion(int indiceDeAccion);
    }
}
