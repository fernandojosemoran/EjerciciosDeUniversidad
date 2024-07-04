using RegistroDeUsuarios;
using System.Collections.Generic;
using System;

public class Usuario
{
    private bool activo;
    private string apellido;
    private readonly string codigo = Guid.NewGuid().ToString();
    private readonly DateTime fechaApertura = DateTime.Now;
    private readonly string id = Guid.NewGuid().ToString();
    private string nombre;
    private string contrasena;
    private string rol;
    private List<Usuario> usuarios = new List<Usuario>();

    public Usuario(string nombre, string apellido, string contrasena, string rol, bool activo)
    {
        this.nombre = nombre;
        this.apellido = apellido;   
        this.contrasena = contrasena;
        this.rol = rol;
        this.activo = activo;
    }

    public string getNombre() => nombre;
    public string getApellido() => apellido;    
    public string getId() => id;    
    public string getCodigo() => codigo;
    public bool getActivo() => activo;
    public string getRol() => rol;
    public DateTime getFechaApertura() => fechaApertura;
    public string getContrasena() => contrasena;
    public List<Usuario> GetUsuarios() => usuarios;
}