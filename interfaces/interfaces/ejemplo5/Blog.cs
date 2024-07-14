using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IBlog
{
    void EscribirPublicacion();
    void EliminarPublicacion();
    void EditarPublicacion();
    void VerPublicacion();
    void BuscarPublicacion();
    void VerTotalDePublicaciones();
    void VerCantidadDePaginas();
}

namespace interfaces.ejemplo5
{
    public class Blog : IBlog
    {
        public void BuscarPublicacion() => Console.Write("Buscando Publicacion.\n\n");
        public void EditarPublicacion() => Console.Write("Editando publicacion.\n\n");
        public void EliminarPublicacion() => Console.Write("Eliminar publicacion.\n\n");
        public void EscribirPublicacion() => Console.Write("Escribir publicacion.\n\n");
        public void VerCantidadDePaginas() => Console.Write("Mirando cantidad de paginas.\n\n");
        public void VerPublicacion() => Console.Write("Ver publicaciones.\n\n");
        public void VerTotalDePublicaciones() => Console.Write("Publicaciones mostradas.\n\n");
    }
}
