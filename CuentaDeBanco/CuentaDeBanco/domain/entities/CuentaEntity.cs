using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.entities
{
    public class CuentaEntity
    {
        private readonly string id = Guid.NewGuid().ToString();
        private double saldo;
        private ClienteEntity cliente;

        public CuentaEntity(double saldo, ClienteEntity cliente)
        {
            this.saldo = saldo;
            this.cliente = cliente;
        }

        public string getId() => id;
        public double getSaldo() => saldo;
        public ClienteEntity getCliente() => cliente;
        public void setId(ClienteEntity cliente) => this.cliente = cliente;
        public void setSaldo(double saldo) => this.saldo = saldo;
    }
}
