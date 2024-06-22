using CuentaDeBanco.config;
using CuentaDeBanco.presentation;
using System;
using System.Collections.Generic;

// no logre implementar ciertas funcionalidades como las de atm.

// ### Utiliza principios de programacion orientada a objectos

/*
    clase Cuenta: Representa una cuenta bancaria con propiedades como ( numeroDeCuenta, saldo ) y metodos como ( Depositar, Retirar ).
    clase ATM: Representa el cajero automatico. Puede tener propiedades como ( ubicacion ) y metodos como ( InsertarTarjeta, EjecutarTarjeta, SolicitarPing, MostrarMenu, ProcesarTransacion ).
    clase Cliente: Representa al usuario del cajero automatico con propiedades como ( nombre, cuenta ) que seria un objecto de la clase Cuenta y metodos para interactuar con el cajero automatico.
    clase Banco Puede contener una lista de cuentas y clientes, y metodos para buscar cuentas o validar transaciones.
*/

// El uso de clases en plural no es mala practica https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

// me esforce por aplicar las mejores practicas posible como principios (solid, clean architecture, clean code) pero no siempre es posible seguir todo al pie de la letra.

namespace CuentaDeBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = AppConfig.AplicationName;
            AppConfig.Banner();

            InitialApp.Iniciar();
            Console.ReadKey();
        }
    }
}
