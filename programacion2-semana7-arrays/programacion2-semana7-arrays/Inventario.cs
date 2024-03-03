using System;


/*
    Crea un programa que gestione el inventario de una tienda. Utiliza un arreglo para mantener
    un registro de los productos disponibles, un arreglo para sus precios y un arreglo para sus 
    cantidades en stock. Permite al usuario elegir a través de un menú las opciones: agregar, 
    vender, actualizar productos y salir 
*/

//Ejercicio mas o menos resuelto

namespace programacion2_semana7_arrays
{
    public class Inventario
    {
        //Instancia del objeto Crud para acceder a las funciones del inventario
        private Crud instanciaCrud = new Crud();
        private InteractuarConUsuario accion = new InteractuarConUsuario();
        private Mostrar mostrar = new Mostrar();

        //Cabecera para la tabla del inventario
        private string cabecera = $"ID \t Producto \t Precio \t Cantidad \t Fecha\n";

        public void MainInventario()
        {
            //Obtenemos el inventario inicial
            Producto[] inventario = instanciaCrud.ObtenerProductos();

            //Mostramos el banner de la tienda y el inventario inicial
            this.mostrar.MostrarBanner();
            this.mostrar.MostrarInventario(inventario, cabecera);

            //Bucle principal para el menú de opciones
            for (; ; )
            {
                //Mostramos el menú de opciones
                Console.WriteLine("\n1. Crear producto\n2. Actualizar producto\n3. Eliminar producto\n4. Vender producto\n5. Limpiar consola\n6. Salir");
                Console.Write("\nSeleccione un indice: ");
                int solicitarId = int.Parse(Console.ReadLine());

                //Si el ID ortorgado es 5 entonces
                if (solicitarId == 5)
                {
                    //Limpiamos la consola
                    Console.Clear();
                    //Mostramos el banner
                    this.mostrar.MostrarBanner();
                    //Mostramos el inventario
                    this.mostrar.MostrarInventario(this.accion.GetInventarioActualizado(), this.cabecera);
                }

                //Salir del programa si se selecciona la opción 5
                if (solicitarId == 6)
                {
                    //Acabamos el programa
                    break;
                }

                //Ejecutar la opción seleccionada
                switch (solicitarId)
                {
                    case 1:
                        this.accion.PedirNuevoProducto();
                        break;
                    case 2:
                        this.accion.PedirActualizarProducto();
                        break;
                    case 3:
                        this.accion.PedirEliminarProducto();
                        break;
                    case 4:
                        this.accion.PedirVenderProducto();
                        break;
                }
            }
        }
    }

    internal class Crud
    {
        private Mostrar mostrar = new Mostrar();

        //Array que almacena los productos del inventario
        private Producto[] inventario = new Producto[]
        {
            new Producto(1, "Laptop", 999.99, 50, DateTime.Parse("2024-02-28")),
            new Producto(2, "Smartphone", 699.99, 100, DateTime.Parse("2024-02-28")),
            new Producto(3, "Headphones", 99.99, 200, DateTime.Parse("2024-02-28")),
            new Producto(4, "Keyboard", 49.99, 150, DateTime.Parse("2024-02-28")),
            new Producto(5, "Mouse", 29.99, 300, DateTime.Parse("2024-02-28")),
            new Producto(6, "Monitor", 299.99, 80, DateTime.Parse("2024-02-28")),
            new Producto(7, "Tablet", 399.99, 70, DateTime.Parse("2024-02-28")),
            new Producto(8, "Speaker", 149.99, 120, DateTime.Parse("2024-02-28")),
            new Producto(9, "Camera", 599.99, 40, DateTime.Parse("2024-02-28")),
            new Producto(10, "Smartwatch", 199.99, 90, DateTime.Parse("2024-02-28"))
        };

        //Propiedad para obtener el proximo identificador de producto
        public int id => inventario.Length + 1;

        // Metodo para agregar un nuevo producto al inventario
        public void CrearProducto(Producto nuevoProducto)
        {
            //Aumentamos el rango del array en 1 valor
            Array.Resize(ref inventario, this.inventario.Length + 1);
            //Asignamos el nuevo producto a la ultima posición del array
            inventario[inventario.Length - 1] = nuevoProducto; 
        }


        // Método para obtener el inventario actual
        public Producto[] ObtenerProductos()
        {
            return inventario;
        }
        public void ActualizarProducto(int indice, Producto productoParaActualizar)
        {
            //Declaramos una variable para guardar el nombre
            string nombre;

            // Verificamos que el indice otorgado por el usuario sea valido 
            if (indice >= 0 && indice < this.inventario.Length)
            {
                //Guardamos el nombre del producto
                nombre = this.inventario[indice].Nombre;

                //Modificamos los valores del producto a modificar
                this.inventario[indice].Id = productoParaActualizar.Id;
                this.inventario[indice].Nombre = productoParaActualizar.Nombre;
                this.inventario[indice].Precio = productoParaActualizar.Precio;
                this.inventario[indice].Cantidad = productoParaActualizar.Cantidad;
                this.inventario[indice].Fecha = productoParaActualizar.Fecha;

                //Mostramos un mensaje indicando que el producti fue actualizado correctamente
                this.mostrar.MostrarMensaje($"\nProducto {nombre} fue actualizado exitosamente.\n", this.mostrar.MENSAJE_POSITIVO);
            }
            else
            {
                //Mostramos un mensaje indicando que el indice no es valido
                this.mostrar.MostrarMensaje("\nEl indice esta fuera del rango del inventario.\n", this.mostrar.MENSAJE_NEGATIVO);
            }
        }

        //Metodo del crud que eliminara el producto
        public void EliminarProducto(int id)
        {
            if (id == 0)
            {
                id = 1;
            }

            //Declaramos un variable para guardar el nombre del producto a buscar
            string producto;
            //Buscar el producto en el inventario
            for (int i = 0; i < this.inventario.Length; i++)
            {
                //Si encotramos el id del producto entonces
                if (this.inventario[i].Id == id)
                {
                    //Obtenemos el nombre del producto
                    producto = this.inventario[i + 1].Nombre;
                    //Mover los elementos restantes hacia atras en el array
                    for (int j = i; j < this.inventario.Length - 1; j++)
                    {
                        //recorremos todos los productos a indices para que los indices sin valor sean eliminados
                        this.inventario[j] = this.inventario[j];
                        //modificamos el indice del producto
                        this.inventario[j].Id = j + 1;
                    }

                    //Indicamos al usuario que el producto fue eliminado
                    this.mostrar.MostrarMensaje($"\nProducto {producto} ha sido eliminado exitosamente.\n", this.mostrar.MENSAJE_POSITIVO);
                    //Redimensionar el array para eliminar el ultimo elemento
                    Array.Resize(ref this.inventario, this.inventario.Length - 1);
                }
            }
        }

    }
    internal class Producto
    {
        //Asignamos propiedades y metodos de modificacion y obtencion del producto
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        //Creamos el constructor del producto
        public Producto(int id, string nombre, double precio, int cantidad, DateTime fecha)
        {
            //modificamos las propiedades  de la clase Producto mediante los parametros otorgados por el usuario 
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Fecha = fecha;
        }

        //Metodo para representar el producto como una cadena de texto pero de una forma mas estructurada
        public override string ToString()
        {
            return $"{Id,-3} \t {Nombre,-11} \t {Precio,-10:C2} \t {Cantidad,-10} \t {Fecha}";
        }
    }

    internal class Mostrar {
        public int MENSAJE_POSITIVO = 0;
        public int MENSAJE_NEGATIVO = 1;

        //Asignamos un metodo que muestre un mensaje positivo o negativo
        public void MostrarMensaje(string mensaje, int tipo)
        {
            const int positivo = 0;
            const int negativo = 1;

            if (tipo == negativo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(mensaje);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            if (tipo == positivo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(mensaje);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        //Metodo para mostrar el inventario
        public void MostrarInventario(Producto[] productos, string cabeceras)
        {
            //Mostramos las cabeceras del inventario
            Console.WriteLine("\n" + cabeceras);
            //Recorremos las filas del inventario
            foreach (Producto producto in productos)
            {
                //Mostramos los valores de cada fila
                Console.WriteLine(producto);
            }
        }

        //Metodo para mostrar el banner de la tienda
        public void MostrarBanner()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                @"
                    =======================================================================
                    =====    ==============================================================
                    ======  ===============================================================
                    ======  ===========================================================  ==
                    ======  ====   ===  =  ===   ====   ====   ===  =   ===  ==    ===    =
                    ======  ===  =  ==  =  ==  =  ==  =  ==  =  ==    =  ======  =  ===  ==
                    ======  ======  ===   ======  ===  ====  =====  =======  ==  =  ===  ==
                    =  ===  ====    ===   ====    ====  ===  =====  =======  ==    ====  ==
                    =  ===  ===  =  ==== ====  =  ==  =  ==  =  ==  =======  ==  ======  ==
                    ==     =====    ==== =====    ===   ====   ===  =======  ==  ======   =
                    =======================================================================
                "
            );

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public (string, double, int, DateTime) MostrarSolicitudDeProducto()
        {
            //Le pedimos al usuario los datos correspondientes para crear el producto
            Console.Write("\nNombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("\nPrecio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("\nCantidad de productos disponibles: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("\nFecha use el formato YYY-MMM-DDD: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            //Devolvemos los datos otorgados por el usuario
            return (nombre,precio,cantidad,fecha);
        }

        //Creamos un metod que muestre la informacion de un producto a modificar
        public void MostrarProductoParaInteractuar(string informacionDeProducto)
        {
            Console.WriteLine("Producto a modificar:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(informacionDeProducto);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }

    internal class InteractuarConUsuario
    {
        //Cabecera para la tabla del inventario
        private string cabecera = $"ID \t Producto \t Precio \t Cantidad \t Fecha\n";
        private Crud instanciaCrud = new Crud();
        private Mostrar mostrar = new Mostrar();    

        //Metodo para obtener los datos actualizado en tiempo real
        public Producto[] GetInventarioActualizado()
        {
            return this.instanciaCrud.ObtenerProductos();
        }

        //Metodo para crear un nuevo producto
        public void PedirNuevoProducto()
        {
            //Obtenemos el id proximo para crear el nuevo producto
            int identificador = this.instanciaCrud.id;

            //Le pedimos al usuario los datos correspondientes para crear el producto
            (string nombre, double precio, int cantidad, DateTime fecha) = this.mostrar.MostrarSolicitudDeProducto();

            //Creamos un nuevo producto
            Producto nuevoProducto = new Producto(identificador, nombre, precio, cantidad, fecha);

            //Agregamos el nuevo producto al inventario
            this.instanciaCrud.CrearProducto(nuevoProducto);

            //Limpiamos la consola y mostramos el inventario actualizado
            this.mostrar.MostrarInventario(this.instanciaCrud.ObtenerProductos(), this.cabecera);

            //Indicamos al usuario que el producto fue creado exitosamente
            this.mostrar.MostrarMensaje($"\nProducto {nombre} creado exitosamente.", this.mostrar.MENSAJE_POSITIVO);
        }

        //Creamos un metodo el cual ejecute la logica que interactue con la actualizacion de un producto
        public void PedirActualizarProducto()
        {
            //Pedimos al usuario que ingrese un ID
            Console.Write("\nIngrese indice del producto: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            //Utilizamos la misma instancia de Crud que se utilizó para obtener los productos inicialmente
            Producto[] productos = instanciaCrud.ObtenerProductos();

            //Mostramos informacion del producto a modificar
            this.mostrar.MostrarProductoParaInteractuar($"nombre: {productos[indice].Nombre}\tprecio: {productos[indice].Precio}\tcantidad: {productos[indice].Cantidad}\tfecha: {productos[indice].Fecha}");

            //Le pedimos al usuario los datos correspondientes para crear el producto
            (string nombre, double precio, int cantidad, DateTime fecha) = this.mostrar.MostrarSolicitudDeProducto();

            //Creamos un nuevo producto
            Producto productoParaActualizar = new Producto(
                id: (indice + 1),
                nombre: nombre,
                precio: precio,
                cantidad: cantidad,
                fecha: fecha
            );

            //Utilizamos la misma instancia de crud para actualizar el producto, de esta forma hacemos cambios que se mire reflejados a lo largo de la ejecucion del programa
            //De lo contrario los datos se resetearian causando que cada vez que ejecute una funcionalidad las anteriores vuelvan a los valores predeterminados
            this.instanciaCrud.ActualizarProducto(
                indice: indice,
                productoParaActualizar: productoParaActualizar
            );

            //Mostramos el inventario 
            this.mostrar.MostrarInventario(this.instanciaCrud.ObtenerProductos(), this.cabecera);
        }

        //Metodo que contiene la logica para pedir la informacion correspondiente para eliminar un producto
        public void PedirEliminarProducto()
        {
            //Pedimos al usuario que nos otorgue un ID 
            Console.Write("\nIngrese ID del producto a eliminar: ");
            //Convertimos el id en numero entero
            int id = int.Parse(Console.ReadLine()) - 1;

            //Llamamos el metodo EliminarProducto y le pasamos el argumento ID que hace referencia al producto
            this.instanciaCrud.EliminarProducto(id);

            //Creamos un lista de productos que hace referencia a una actualizacion de los productos anteriormente creados
            Producto[] inventarioActualzado = this.instanciaCrud.ObtenerProductos();

            //Mostramos el inventario actualizado con los productos anteriormente creados
            this.mostrar.MostrarInventario(inventarioActualzado, this.cabecera);
        }

        public void PedirVenderProducto()
        {
            //Indicamos al usuario que nos otorgue un ID 
            Console.Write("\nIngrese ID de producto a vender: ");
            //Convertimos el ID a numero entero
            int id = int.Parse(Console.ReadLine());

            //Creamos una lista de productos la cual obtendra todos los productos actuales actualizados
            Producto[] productos = instanciaCrud.ObtenerProductos();
            //Asignamos un producto
            Producto producto = null;

            //Recorremos los productos para encontrar el id que coincida con el ID otorgado por el usuario
            foreach (Producto item in productos)
            {
                //Comparamos si los ID coinciden 
                if (item.Id == id)
                {
                    //Si los productos coinciden entonces guardamos el producto
                    producto = item;
                    //Acabamos el recorrido de los productos
                    break;
                }
            }

            //Guardamos el nombre del producto
            string nombre = producto.Nombre;
            //Guardamos la cantidad de productos existentes
            int cantidad = producto.Cantidad;
            //Guardamos el precio del producto
            double precio = producto.Precio;
            //Declaramos una variable de pago
            double pago;
            //Declaramos una variable para guardar los productos sobrantes
            int cantidadDeProductosRestantes = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            //Asignamos una cabecera indicando los producto que se vendera
            Console.WriteLine($"\nNombre: {nombre}\tPrecio: {precio}\t Cantidad: {cantidad}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            //Indicamos al usuario que cantidad de productos quiere vender
            Console.Write("Ingrese cantidad a vender: ");
            //Convertimos la cantidad de productos que el usuario quiere vender a un numero entero
            int cantidadParaVender = int.Parse(Console.ReadLine());

            //Si la cantidad que el usuario quiere vender es menor o igual a los existentes, entonces vendemos los productos
            if (cantidadParaVender <= cantidad)
            {
                //Calculamos los productos sobrantes, si es que quedan disponibles
                cantidadDeProductosRestantes = cantidad - cantidadParaVender;

                //Calculamos el pago del total a los productos que venderemos
                pago = (cantidadParaVender) * precio;
                //Mostramos el pago que el usuario quiere vender 
                this.mostrar.MostrarMensaje($"\nMonto a pagar: {pago}", this.mostrar.MENSAJE_POSITIVO);
            }
            else
            {
                //Si la cantidad no es menor o igual a los existentes entonces mostramos el siguiente mensaje 
                this.mostrar.MostrarMensaje($"\nNo tienes suficientes {nombre} para vender", this.mostrar.MENSAJE_NEGATIVO);
            }

            //Si hay productos existentes entonces 
            if (cantidadDeProductosRestantes != 0)
            {
                //Modificamos la cantidad de productos
                producto.Cantidad = cantidadDeProductosRestantes;
                //Actualizamos el productos a vender
                instanciaCrud.ActualizarProducto(id - 1, producto);
                //Mostramos el inventario actualizado
                this.mostrar.MostrarInventario(instanciaCrud.ObtenerProductos(), cabecera);
            }

            //Si cantidadDeProductosRestantes es menor o igual a 0, quiere decir que el usuario quiere vender mas productos de los que tiene disponibles
            if (cantidadDeProductosRestantes <= 0)
            {
                //Mostramos un mensaje indicando que no tiene productos suficientes
                this.mostrar.MostrarMensaje("\nTodos los productos han sido vendidos", this.mostrar.MENSAJE_NEGATIVO);
            }
        }
    }
}
