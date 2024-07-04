using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeUsuarios.helpers
{
    public class CapitalizarPalabra
    {
        static public string Capitalizar(string palabra, TextInfo textInfo)
        {
            return string.Join(" ", palabra.Split(' ')
            .Where(word => !string.IsNullOrWhiteSpace(word))
            .Select(word => textInfo.ToTitleCase(word.ToLower())));
        }
    }
}
