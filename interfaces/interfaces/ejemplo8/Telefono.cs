using interfaces.ejemplo8;
using System;

interface ITelefono
{
    BuilderTelefono SubirVolumen(int? volumen);
    BuilderTelefono BajarVolumen(int? volumen);
    BuilderTelefono HacerLlamada();
    BuilderTelefono EscribirMensaje();
    BuilderTelefono Apagar();
    BuilderTelefono Encender();
    BuilderTelefono TomarFoto();
}

namespace interfaces.ejemplo8
{
    public class BuilderTelefono : ITelefono
    {
        private int volumen = 0; // Asignar un valor inicial válido
        private bool isEncendido = false;

        public BuilderTelefono Apagar()
        {
            if (isEncendido)
            {
                isEncendido = false;
                Console.WriteLine("\nApagando telefono\n");
                return this;
            }

            throw new Exception("\nEl celular ya esta apagado\n");
        }

        public BuilderTelefono BajarVolumen(int? volumen = 0)
        {
            if (volumen > 0)
            {
                this.volumen -= volumen ?? 25;
            }

            this.volumen -= 25;

            if (this.volumen < 0)
            {
                this.volumen = 0;
                Console.WriteLine("\nEl telefono esta en modo silencioso\n");
                return this;
            }

            Console.WriteLine($"\nVolumen actual: {this.volumen}\n");
            return this;
        }

        public BuilderTelefono Encender()
        {
            if (!isEncendido)
            {
                isEncendido = true;
                Console.WriteLine("\nEncendiendo telefono\n");
                return this;
            }

            throw new Exception("\nEl celular ya esta encendido\n");
        }

        public BuilderTelefono EscribirMensaje()
        {
            Console.WriteLine("\nEscribiendo mensaje\n");
            return this;
        }

        public BuilderTelefono HacerLlamada()
        {
            Console.WriteLine("\nHaciendo llamada\n");
            return this;
        }

        public BuilderTelefono SubirVolumen(int? volumen = 0)
        {
            if (volumen > 0)
            {
                this.volumen = volumen ?? 25;
            }

            this.volumen += 25;

            if (this.volumen > 100)
            {
                this.volumen = 100;
                throw new Exception("\nLimite de volumen alcanzado\n");
            }

            this.volumen += volumen ?? this.volumen;
            Console.WriteLine($"\nVolumen actual: {this.volumen}\n");
            return this;
        }

        public BuilderTelefono TomarFoto()
        {
            Console.WriteLine("\nTomando foto\n");
            return this;
        }
    }
}