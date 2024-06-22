using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.entities
{
    public class ClienteEntity
    {
        private readonly string id = Guid.NewGuid().ToString();
        private readonly string nombre;
        private readonly TarjetaEntity tarjeta;

        public ClienteEntity(string nombre, TarjetaEntity tarjeta = null)
        {
            this.nombre = nombre;
            this.tarjeta = tarjeta;
        }

        public string getId() => id;
        public string getIdCuenta() => tarjeta.getId();
        public string getNombre() => nombre;

        public TarjetaEntity GetTarjeta() => tarjeta;
    }
}
