using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IAnimal
{
    void Caminar();
    void Comer();
    void Respirar();
    void Cazar();
    void Dormir();
    void HaceRuido();
}

interface IAnimalVolador : IAnimal
{
    void Volar();
}

interface IPersona: IAnimal
{
    void Hablar();
    void HagarraObjecto();
}



namespace interfaces.ejemplo7
{
    public class Animal
    {
    }

    public class Ave
    {
    }
    public class Persona : IPersona
    {
        public void Caminar()
        {
            Console.WriteLine("caminando");
        }

        public void Cazar()
        {
            throw new NotImplementedException();
        }

        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }

        public void Hablar()
        {
            throw new NotImplementedException();
        }

        public void HaceRuido()
        {
            throw new NotImplementedException();
        }

        public void HagarraObjecto()
        {
            throw new NotImplementedException();
        }

        public void Respirar()
        {
            throw new NotImplementedException();
        }
    }
}
