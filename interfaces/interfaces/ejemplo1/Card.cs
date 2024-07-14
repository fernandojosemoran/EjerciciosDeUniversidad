using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enum typeCards { credit, debit }


//Card card = new Card(
//    type: new CardType(((int)typeCards.debit))
//);

//card.DarCodigoDeTarjeta();
//card.DarNombreDeBanco();
//card.DarNombreDePropietario();
//card.DarCVS();
//card.FechaDeExpiracion();
//Console.WriteLine(card.TypoDeTarjeta);

interface ICard
{

    string TypoDeTarjeta { get; }
    void DarCodigoDeTarjeta();
    void DarCVS();
    void FechaDeExpiracion();
    void DarNombreDePropietario();
    void DarNombreDeBanco();
}

namespace interfaces
{
    internal class Card : ICard
    {
        private readonly string cardType;
        public Card(CardType type)
        {
            if (type is CardType)
            {
                this.cardType = type.getCardType();
            }
            else
            {
                throw new NotImplementedException(message: "Argument passed not is intance of CardType");
            }
        }

        public string TypoDeTarjeta { get => cardType; }

        public void DarCodigoDeTarjeta()
        {
            Console.WriteLine("Codigo de tarjeta dado");
        }

        public void DarCVS()
        {
            Console.WriteLine("CVS dado");
        }

        public void DarNombreDeBanco()
        {
            Console.WriteLine("Nombre de banco dado");
        }

        public void DarNombreDePropietario()
        {
            Console.WriteLine("Nombre de propietario");
        }

        public void FechaDeExpiracion()
        {
            Console.WriteLine("Fecha de expiracion entregada");
        }
    }


    class CardType
    {
        private string type;

        public CardType(int type) 
        {
            switch (type)
            {
                case 0:
                    this.type = "credit";
                    break;
                case 1:
                    this.type = "debit";
                    break;
                default: throw new NotImplementedException("Card type not is valid.");
            }
        }

        public string getCardType() => type;
    }
}

