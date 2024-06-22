using CuentaDeBanco.config;
using CuentaDeBanco.domain.Actions;
using CuentaDeBanco.domain.datasources;
using CuentaDeBanco.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.datasources
{
    public class AtmDatasourceImpl : AtmDatasource
    {
        public override void EjecutarTarjeta(bool estado)
        {
           AppConfig.Db.setEstaTarjetaEjecutada(estado);
        }

        public override void InsertarTarjeta(bool estado)
        {
           AppConfig.Db.setEstaTarjetaInsertada(estado);
        }

        public override void MostrarMenu()
        {
            string[] headers = { "Acción" };
            List<string> actionList = Menus.GetListaMenuCliente;


            int columnWidth = 0;
            int index = 1;
            foreach (var action in actionList)
            {
                string indexedAction = $"({index}) {action}";
                if (indexedAction.Length > columnWidth)
                {
                    columnWidth = indexedAction.Length;
                }
                index++;
            }


            Console.WriteLine("| {0,-" + columnWidth + "} |", "Acciones");
            Console.WriteLine(new string('-', columnWidth + 4)); // Separador


            index = 1;
            foreach (var action in actionList)
            {
                string indexedAction = $"({index}) {action}";
                Console.WriteLine("| {0,-" + columnWidth + "} |", indexedAction);
                index++;
            }

            Console.WriteLine("\n");
        }

        public override void ProcesarTransacion()
        {
            Advertencias.AdvertenciaAlerta("Atm esta procesando la transaccion");
        }

        public override void SolicitarPing()
        {
            // este metodo fue implementado porque no se que se supone que haga ese ping falta contexto.
            Console.WriteLine("Solicitando ping");
        }

        public override void ObtenerAtmAccion(int indiceDeAccion)
        {
            switch (indiceDeAccion)
            {
                case 1:
                    SolicitarPing();
                    break;
                case 2:
                    MostrarMenu();
                    break;
                case 3:
                    ProcesarTransacion();
                    break;
                default:
                    Advertencias.AdvertenciaNegativo("[x] Acción indicada no es correcta.");
                    break;
            }
        }
    }
}
