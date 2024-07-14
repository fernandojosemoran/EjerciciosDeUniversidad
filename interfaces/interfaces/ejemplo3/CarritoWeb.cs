using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICarritoDeCompra
{
    List<string> Articulos { get; }
    double PrecioTotal { get; }
    void AgregarArticulo();
    void RemoverArticulo();

    void LimpiarCarrito();

    void AplicarDescuento();

    void VerDetallesDeArticulo ();

    void ActualizarCalidadDeArticulo();

    double CalcularImpuestos();
}


namespace interfaces
{
    public class ShoppingCart : ICarritoDeCompra
    {
        public List<string> Articulos => new List<string> { "telefono", "microondas"};

        public double PrecioTotal => throw new NotImplementedException();

        public void ActualizarCalidadDeArticulo()
        {
            Console.WriteLine("Calidad de articulo actualizado");
        }

        public void AgregarArticulo()
        {
            Console.WriteLine("Articulo agregado");
        }

        public void AplicarDescuento()
        {
            Console.WriteLine("Descuento aplicado");
        }

        public double CalcularImpuestos()
        {
            Console.WriteLine("Impuesto aplicado");
            return 15 * 0.13;
        }

        public void LimpiarCarrito()
        {
            Console.WriteLine("Carrito de compras limpio");
        }

        public void RemoverArticulo()
        {
            Console.WriteLine("Articulo removido");
        }

        public void VerDetallesDeArticulo()
        {
            Console.WriteLine("Mostrando detalles de articulo");
        }
    }

}
