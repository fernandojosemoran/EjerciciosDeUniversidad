using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.entities
{
    public class AtmEntity
    {
        private string ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        AtmEntity(string ubicacion)
        {
            this.ubicacion = ubicacion; 
        }
    }
}
