using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ICar
{
    void Encender();
    void Apagar();
    void Manejar();
    void EncenderRadio();
    void HacerCambio();
    void LimpiarEspejoFrontal();
    void EncenderLaCalefaccion();
}


namespace interfaces
{
    public class CarroCombustion : ICar
    {
        public string nombre = "carro de combustion";
        private string color = "black";

        public void Apagar()
        {
            Console.WriteLine("Apagando carro");
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo carro");
        }

        public void EncenderLaCalefaccion()
        {
            Console.WriteLine("Encendiendo calefacion");
        }

        public string getColor()
        {
            return color;
        }

        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo raido");
        }

        public void HacerCambio()
        {
            Console.WriteLine("Haciendo cambio");
        }

        public void LimpiarEspejoFrontal()
        {
            Console.WriteLine("Limpiando espejo frontal");
        }

        public void LlenarTanque()
        {
            Console.WriteLine("Llenando tanque");
        }

        public void Manejar()
        {
            Console.WriteLine("Manejando auto");
        }
    }

    class CarroElectronico : CarroCombustion
    {
        public void CargarCarro()
        {
            Console.WriteLine("Cargar carro");
        }
    }
}
