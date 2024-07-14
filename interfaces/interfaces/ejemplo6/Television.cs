using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ITelevision
{
    void Apagar();
    void Encender();
    void VerCanalSiguiente();
    void SubirVolumen();
    void BajarVolumen();
    void VerCanalAnterior();
    void VerCanalEspesifico(string numeroDeCanal);
}


namespace interfaces.ejemplo6
{
    public abstract class TelevisionModel
    {
        public abstract void Apagar();
        public abstract void VerCanalSiguiente();
        public abstract void Encender();
        public abstract void SubirVolumen();
        public abstract void BajarVolumen();
        public abstract void VerCanalAnterior();
        public abstract void VerCanalEspesifico(string numeroDeCanal);
    }

    public class Television : ITelevision
    {
        public void Apagar()
        {
            Console.WriteLine();
        }

        public void BajarVolumen()
        {
            throw new NotImplementedException();
        }

        public void Encender()
        {
            throw new NotImplementedException();
        }

        public void SubirVolumen()
        {
            throw new NotImplementedException();
        }

        public void VerCanalAnterior()
        {
            throw new NotImplementedException();
        }

        public void VerCanalEspesifico(string numeroDeCanal)
        {
            throw new NotImplementedException();
        }

        public void VerCanalSiguiente()
        {
            throw new NotImplementedException();
        }
    }
}
