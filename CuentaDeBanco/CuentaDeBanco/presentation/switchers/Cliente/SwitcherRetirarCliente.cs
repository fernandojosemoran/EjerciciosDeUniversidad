using CuentaDeBanco.config;
using CuentaDeBanco.domain.entities;
using CuentaDeBanco.domain.repositories;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.presentation.switchers.Cliente
{
    public class SwitcherRetirarCliente
    {
        static private ClienteRepository repository = new ClienteRepositoryImpl();
        static public void Retirar()
        {
            string nombre = SolicitarDatos();
            CuentaEntity cuenta = verificarDatos(nombre);

            repository.Retirar(cuenta);
        }

        static private string SolicitarDatos()
        {
            Advertencias.AdvertenciaPedirInformacionRelevante("Ingrese nombre del cliente: ");
            string nombre = Console.ReadLine().Trim();
            nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

            Advertencias.AdvertenciaPedirInformacionRelevante("Ingrese saldo del cliente: ");

            return nombre;
        }

        static private CuentaEntity verificarDatos(string nombre)
        {
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                return new CuentaEntity(saldo, new ClienteEntity(nombre));
            }

            Advertencias.AdvertenciaNegativo("Se solicito un valor numero y recivimos un caracter");
            return new CuentaEntity(0, new ClienteEntity(""));
        }
    }
}
