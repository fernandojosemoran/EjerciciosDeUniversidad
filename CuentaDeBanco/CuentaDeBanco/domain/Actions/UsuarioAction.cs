using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.domain.Actions
{
    // esta clase pudo haber sido un Enum pero preferi hacer una clase
    internal class UsuarioAction
    {
        public static readonly string accionInsertarTarjeta = "insertarTarjeta";
        public static readonly string accionEjecutarTarjeta = "ejecutarTarjeta";
        public static readonly string accionSolicitarPing = "solicitarPing";
        public static readonly string accionMostrarMenu = "mostrarMenu";
        public static readonly string procesarTransacion = "procesarTransacion";
    }
}
