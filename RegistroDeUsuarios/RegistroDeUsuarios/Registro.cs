using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuarios
{
    public class Registro
    {
        static public DataTable CrearTabla()
        {
            DataTable tabla = new DataTable("Usuarios");

            tabla.Columns.Add(CamposTabla.Id, typeof(string));
            tabla.Columns.Add(CamposTabla.Nombre, typeof(string));
            tabla.Columns.Add(CamposTabla.Apellido, typeof(string));
            tabla.Columns.Add(CamposTabla.Codigo, typeof(string));
            tabla.Columns.Add(CamposTabla.Rol, typeof(string));
            tabla.Columns.Add(CamposTabla.FechaApertura, typeof(DateTime));
            tabla.Columns.Add(CamposTabla.Password, typeof(string));
            tabla.Columns.Add(CamposTabla.Activo, typeof(bool));

            return tabla;
        }

        static public void AgregarRegistro(DataTable tabla, Usuario usuario)
        {
            DataRow row = tabla.NewRow();

            row[CamposTabla.Id] = usuario.getId();
            row[CamposTabla.Nombre] = usuario.getNombre();
            row[CamposTabla.Apellido] = usuario.getApellido();
            row[CamposTabla.Codigo] = usuario.getCodigo();
            row[CamposTabla.Rol] = usuario.getRol();
            row[CamposTabla.FechaApertura] = usuario.getFechaApertura();
            row[CamposTabla.Password] = usuario.getContrasena();
            row[CamposTabla.Activo] = usuario.getActivo();

            tabla.Rows.Add(row);
        }
    }
}
