 using System;

//Registro de clientes

/*
    Implementa un sistema de registro de clientes para una empresa. Utiliza un arreglo para 
    almacenar información como nombres, direcciones y números de teléfono de los clientes.
    Establecer una constante para definir el máximo de clientes a almacenar, también crear un 
    menú con las opciones: Agregar cliente, Mostrar cliente y Salir 
*/

namespace programacion2_semana7_arrays
{
    internal class SistemaDeRegistros
    {
        //Declaramos una variable global que instancie a la clase Registro
        private Registro _registro = new Registro();
        private Mostrar _mostrar = new Mostrar();

        //Un metodo para mostrar el banner
        public void MostrarBanner()
        {
            Console.Title = "Registro de clientes";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                     ________  ___    ___ _________  ___  ___  ________  ________      
                    |\   __  \|\  \  /  /|\___   ___\\  \|\  \|\   __  \|\   ___  \    
                    \ \  \|\  \ \  \/  / ||___ \  \_\ \  \\\  \ \  \|\  \ \  \\ \  \   
                     \ \   ____\ \    / /     \ \  \ \ \   __  \ \  \\\  \ \  \\ \  \  
                      \ \  \___|\/  /  /       \ \  \ \ \  \ \  \ \  \\\  \ \  \\ \  \ 
                       \ \__\ __/  / /          \ \__\ \ \__\ \__\ \_______\ \__\\ \__\
                        \|__||\___/ /            \|__|  \|__|\|__|\|_______|\|__| \|__|
                             \|___|/                                                                                                             
            ");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
        //Declaramos un metodo principal donde todo el codigo se ejecutara
        public void MainSistemasDeRegistros()
        {
            //Asignamos un titulo a nuestro programa
            Console.Title = "Registro de clientes";
            //Mostramos el banner
            this.MostrarBanner();


            //Creamos un bucle infinito
            for (; ; )
            {
                //Indicamos al usuario que acciones puede seleccionar
                Console.WriteLine("\n(1) Agregar Cliente\n(2) Mostrar Clientes\n(3) Limpiar consola \n(4) Salir");

                //Indicamos al usuario que escoja un indice
                Console.Write("\nSeleccione un indice: \n");
                //Convertimos el dato ingresado por el usuario en entero
                int indice = int.Parse(Console.ReadLine());

                if (indice == 1 || indice == 2 || indice == 3 || indice == 4)
                {
                    //Verificamos si el indice es 4 
                    if (indice == 4)
                    {
                        //Acabamos el programa
                        break;
                    }

                    //Verificamos el indice para que ejecute una accion
                    switch (indice)
                    {
                        case 1:
                            //Llamamos al metodo de pedir informacion del registro al usuario
                            (string nombre, string direccion, int telefono) = this._registro.PedirInformacionDeRegistro();
                            //Llamamos al metodo para crear un registro
                            this._registro.CrearRegistro(nombre, direccion, telefono);
                            //Acabamos el recorrido del switch
                            break;
                        case 2:
                            //Mostramos el banner con todos los productos
                            this._registro.MostrarRegistros();
                            //Acabamos el recorrido del switch
                            break;
                        case 3:
                            //Limpiamos la consola
                            Console.Clear();
                            //Acabamos el recorrido del switch
                            break;
                    }
                }
                else
                {
                    //Mostramos un mensaje indicando que el ID es invalido
                    this._mostrar.MostrarMensaje("\nEl indice es invalido\n",this._mostrar.MENSAJE_NEGATIVO);
                }

            }
        }
    }

    internal class Registro
    {
        //Creamos una array de registros predeterminados
        private Cliente[] _Registros = {
            new Cliente(id: 1,  nombre: "Fernando", direccion: "Honduras",      telefono: 32024930),
            new Cliente(id: 2,  nombre: "María",    direccion: "El Salvador",   telefono: 12345678),
            new Cliente(id: 3,  nombre: "Juan",     direccion: "Guatemala",     telefono: 98765432),
            new Cliente(id: 4,  nombre: "Ana",      direccion: "Costa Rica",    telefono: 56789012),
            new Cliente(id: 5,  nombre: "Pedro",    direccion: "Nicaragua",     telefono: 24680135),
            new Cliente(id: 6,  nombre: "Luisa",    direccion: "Panamá",        telefono: 13579246),
            new Cliente(id: 7,  nombre: "Carlos",   direccion: "Belize",        telefono: 87654321),
            new Cliente(id: 8,  nombre: "Sofía",    direccion: "Honduras",      telefono: 31415926),
            new Cliente(id: 9,  nombre: "José",     direccion: "El Salvador",   telefono: 27182818),
            new Cliente(id: 10, nombre: "Andrea",   direccion: "Guatemala",     telefono: 16180339)
        };

        private Mostrar _mostrar = new Mostrar();   

        //Creamos un metodo que cree registros
        public void CrearRegistro(string nombre, string direccion, int telefono)
        {
            //Creamos un array de registros con una longitud nueva
            Cliente[] copiaDeRegistros = new Cliente[this._Registros.Length + 1];
            //Declaramos y inicializamos una variable que guardara el indice del nuevo registro
            int indice = 1;

            //recorremos el array de registros existente
            for (int i = 0; i < this._Registros.Length; i++)
            {
                //Incrementamos el indice a un valor mas
                indice++;
                //Guardamos los productos en el nuevo array de productos
                copiaDeRegistros[i] = this._Registros[i];
            }

            //Creamos el nuevo producto
            Cliente registro = new Cliente(
                id: indice, 
                nombre: nombre, 
                direccion: direccion, 
                telefono:telefono
            );

            //Agregamos el registro nuevo al ultimo indice del arreglo de registros
            copiaDeRegistros[this._Registros.Length] = registro;

            //Mostramos un mensaje indicando que el registro fue exitosamente creado
            this._mostrar.MostrarMensaje("\nRegistro creado exitosamente\n", _mostrar.MENSAJE_POSITIVO);

            //Asignamos a la variable global del arreglo de registros un nuevo valor del mismo tipo
            this._Registros = copiaDeRegistros;
        }

        public void MostrarRegistros()
        {
            //Mostramos las cabeceras de registro
            Console.WriteLine($"Id\t Nombre\t\t Direccion\t Telefono\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            //Recorremos las filas de registro
            foreach (Cliente clientes in this._Registros)
            {
                //Mostramos los valores de cada fila
                Console.WriteLine(clientes);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Creamos un metodo pida al usuario los valores correspondietes
        public (string, string, int) PedirInformacionDeRegistro()
        {
            //Indicamos al usuario que inserte un nombre
            Console.Write("\nIngrese nombre de cliente: ");
            string nombre = Console.ReadLine();
            //Indicamos al usuario que inserte una direccion
            Console.Write("\nIngrese direccion de cliente: ");
            string direccion = Console.ReadLine();
            //Indicamos al usuario que inserte un numero telefonico
            Console.Write("\nIngrese telefono de cliente: ");
            int telefono = int.Parse(Console.ReadLine());

            //Devolvemos todos los datos del nuevo registro
            return (nombre, direccion, telefono);
        }
    }


    internal class Cliente
    {
        //Decaramos las variables que conforman un cliente
        public int Id;
        public string Nombre;
        public string Direccion;
        public int Telefono;

        //Creamos el constructor
        public Cliente(int id, string nombre, string direccion, int telefono)
        {
            //Asignamos los valores ingresados por el usuario al objecto creado mediante la clase Cliente
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        //Un metodo global que me permite asignar un comportamiento de identacion
        public override string ToString()
        {
            //Devolvemos las cabeceras de los productos
            return $"{Id,-3} \t {Nombre,-11} \t {Direccion,-10} \t {Telefono,-10}";
        }
    }
}
