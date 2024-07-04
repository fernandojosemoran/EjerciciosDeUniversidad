using RegistroDeUsuarios.helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuarios
{
    public class Menu
    {
        static private DataTable tablaUsuarios = Registro.CrearTabla();
        // sirve para modificar strings de una forma mas sensilla, por ejemplo convertir el primer caracter a mayuscula
        static private TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        static public void ShowMenu()
        {
            Mensaje.MensajeInformativo("Escoja una opcion:\n\n");
            Console.WriteLine("1. Agregar datos");
            Console.WriteLine("2. Buscar datos");
            Console.WriteLine("3. Ver todos los registros");
            Console.WriteLine("4. Limpiar consola");
            Console.WriteLine("5. Salir");
            Mensaje.MensajeInformativo("Seleccione un indice: ");
        }

        static public void AgregarDatos()
        {
            Mensaje.MensajeInformativo("Ingrese el nombre: ");
            string nombre = textInfo.ToTitleCase(Console.ReadLine().Trim().ToLower());
            Mensaje.MensajeInformativo("Ingrese el apellido: ");
            string apellido = CapitalizarPalabra.Capitalizar(Console.ReadLine().Trim(), textInfo);
            Mensaje.MensajeInformativo("Ingrese el rol: ");
            string rol = Console.ReadLine().Trim();
            Mensaje.MensajeInformativo("Ingrese el password: ");
            string password = Console.ReadLine().Trim();
            Mensaje.MensajeInformativo("Ingrese si esta activo (true/false): ");
            string isActivo = Console.ReadLine().Trim();

            if (bool.TryParse(isActivo, out bool activo))
            {
                Usuario nuevoUsuario = new Usuario(nombre, apellido, password, rol, activo);

                Registro.AgregarRegistro(tablaUsuarios, nuevoUsuario);

                Mensaje.MensajePositivo("Datos agregados exitosamente.");

                Mensaje.MensajeDeCabecera("Registro: ");

                Console.WriteLine($@"
                    {CamposTabla.Id}: --------->  {nuevoUsuario.getId()},
                    {CamposTabla.Nombre}: ----->  {nuevoUsuario.getNombre()},
                    {CamposTabla.Apellido}: --->  {nuevoUsuario.getApellido()}
                    {CamposTabla.Codigo}: ----->  {nuevoUsuario.getCodigo()},
                    {CamposTabla.Rol}: -------->  {nuevoUsuario.getRol()},
                    {CamposTabla.Password}: --->  {nuevoUsuario.getContrasena()}
                    {CamposTabla.Activo}: ----->  {nuevoUsuario.getActivo()}
                    {CamposTabla.FechaApertura}:  {nuevoUsuario.getFechaApertura()}
                ");
            }
            else
            {
                Mensaje.MensajeNegativo("Valor invalido, Intente nuevamente.");
            }
        }
        static public void BuscarDatos()
        {
            Mensaje.MensajeInformativo("Seleccione el campo por el cual desea buscar:\n");
            Console.WriteLine("\n1. Id");
            Console.WriteLine("2. Nombre");
            Console.WriteLine("3. Apellido");
            Console.WriteLine("4. Codigo");
            Console.WriteLine("5. Rol");
            Console.WriteLine("6. Activo");
            Mensaje.MensajeInformativo("Ingrese el numero de campo: ");
            string opcionCampo = Console.ReadLine();

            string campo = "";
            string valorBusqueda = "";

            switch (opcionCampo)
            {
                case "1":
                    campo = CamposTabla.Id;
                    Mensaje.MensajeInformativo("Ingrese el Id: ");
                    break;
                case "2":
                    campo = CamposTabla.Nombre;
                    Mensaje.MensajeInformativo("Ingrese el Nombre: ");
                    break;
                case "3":
                    campo = CamposTabla.Apellido;
                    Mensaje.MensajeInformativo("Ingrese el Apellido: ");
                    break;
                case "4":
                    campo = CamposTabla.Codigo;
                    Mensaje.MensajeInformativo("Ingrese el Codigo: ");
                    break;
                case "5":
                    campo = CamposTabla.Rol;
                    Mensaje.MensajeInformativo("Ingrese el Rol: ");
                    break;
                case "6":
                    campo = CamposTabla.Activo;
                    Mensaje.MensajeInformativo("Ingrese el Activo: ");
                    break;
                default:
                    Mensaje.MensajeNegativo("Opcion no valida.");
                    return;
            }

            valorBusqueda = Console.ReadLine().Trim();

            var resultados = tablaUsuarios.AsEnumerable().Where(row => row[campo].ToString().Equals(valorBusqueda, StringComparison.OrdinalIgnoreCase));

            if (resultados.Any())
            {
                Mensaje.MensajePositivo("Registro encontrado exitosamente.");
                Mensaje.MensajeDeCabecera("Registros");

                foreach (var row in resultados)
                {
                    Console.WriteLine($@"
                        {CamposTabla.Id}: ---------> {row[CamposTabla.Id]}, 
                        {CamposTabla.Nombre}: -----> {row[CamposTabla.Nombre]}, 
                        {CamposTabla.Apellido}: ---> {row[CamposTabla.Apellido]}, 
                        {CamposTabla.Codigo}: -----> {row[CamposTabla.Codigo]}, 
                        {CamposTabla.Rol}: --------> {row[CamposTabla.Rol]}, 
                        {CamposTabla.Activo}: -----> {row[CamposTabla.Activo]}
                        {CamposTabla.FechaApertura}: {row[CamposTabla.FechaApertura]}, 
                    ");
                }
            }
            else
            {
                Mensaje.MensajeNegativo("No se encontraron resultados.");
            }
        }


        static public void VerTodosLosRegistros()
        {
            Mensaje.MensajeInformativo($"Existen {tablaUsuarios.Rows.Count} registros.\n");
            Mensaje.MensajeDeCabecera("Registros: ");
            

            foreach (DataRow row in tablaUsuarios.Rows)
            {
                Console.WriteLine($@"
                    {CamposTabla.Id}: -------> {row[CamposTabla.Id]}, 
                    {CamposTabla.Nombre}: ---> {row[CamposTabla.Nombre]}, 
                    {CamposTabla.Apellido}: -> {row[CamposTabla.Apellido]}
                    {CamposTabla.Codigo}: ---> {row[CamposTabla.Codigo]}, 
                    {CamposTabla.Rol}: ------> {row[CamposTabla.Rol]}, 
                ");
            }
            Console.WriteLine();
        }

        static public void LimpiarConsola()
        {
            Console.Clear();
        }
    }
}
