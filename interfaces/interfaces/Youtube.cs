using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface MyInterface
{
    void VerVideo();
    void DarLike();
    void Comentar();
}
public class Facebook
{
    public string nombre = "facebook";
    public void subirFoto()
    {
        Console.WriteLine("Subir foto");
    }

    public void VerVideo()
    {
        Console.WriteLine("ver video");
    }
    public void darLike()
    {
        Console.WriteLine("dar like");
    }
}



namespace interfaces
{
    internal class Youtube
    {

    }
}
