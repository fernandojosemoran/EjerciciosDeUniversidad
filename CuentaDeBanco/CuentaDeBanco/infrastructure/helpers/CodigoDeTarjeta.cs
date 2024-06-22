using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco.infrastructure.helpers
{
    internal class CodigoDeTarjeta
    {
        static public string GenerarCodigo()
        {
            Random random = new Random();
            int[] tarjeta = new int[16];
            for (int i = 0; i < 15; i++)
            {
                tarjeta[i] = random.Next(0, 10);
            }

            // Calcular el dígito de control usando el algoritmo de Luhn
            int suma = 0;
            for (int i = 0; i < 15; i++)
            {
                int digito = tarjeta[i];
                if (i % 2 == 0) // Duplicar cada segundo dígito desde la derecha
                {
                    digito *= 2;
                    if (digito > 9) // Si el resultado es mayor que 9, sumar los dígitos del resultado
                    {
                        digito -= 9;
                    }
                }
                suma += digito;
            }

            int digitoDeControl = (10 - (suma % 10)) % 10;
            tarjeta[15] = digitoDeControl;

            return string.Join("", tarjeta);
        }

        static public bool ExisteCodigoYa(string codigo)
        {
                int suma = 0;
                bool duplicar = false;

                for (int i = codigo.Length - 1; i >= 0; i--)
                {
                    int digito = int.Parse(codigo[i].ToString());
                    if (duplicar)
                    {
                        digito *= 2;
                        if (digito > 9)
                        {
                            digito -= 9;
                        }
                    }
                    suma += digito;
                    duplicar = !duplicar;
                }

                return (suma % 10) == 0;
            }

        static public string GenerarCodigoDeSeguridad(int longitud)
        {
            Random random = new Random();
            string codigo = "";

            for (int i = 0; i < longitud; i++)
            {
                codigo += random.Next(0, 10).ToString();
            }

            return codigo;
        }
    }
}
