using CuentaDeBanco.infrastructure.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.entities
{
    public class TarjetaEntity
    {
        private readonly string id = Guid.NewGuid().ToString();
        private readonly string codigo = CodigoDeTarjeta.GenerarCodigo();

        private DateTime? fechaExpiracion;
        private string codigoSeguridad = CodigoDeTarjeta.GenerarCodigoDeSeguridad(4);

        public TarjetaEntity(DateTime fechaExpiracion)
        {
            this.fechaExpiracion = fechaExpiracion;
        }

        public string getId() => id;    
        public string getCodigo() => codigo;
        public DateTime? getFechaExpiracion() => fechaExpiracion;
        public string getCodigoSeguridad() => codigoSeguridad;
    }
}
