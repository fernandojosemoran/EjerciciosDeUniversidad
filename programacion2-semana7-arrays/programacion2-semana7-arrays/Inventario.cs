using System;

namespace programacion2_semana7_arrays
{
    public class Inventario
    {
        public void MainInventario()
        {
            // Método para mostrar el banner de la tienda
            void MostrarBanner()
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


            //Cabecera para la tabla del inventario
            string cabecera = $"ID \t Producto \t Precio \t Cantidad \t Fecha\n";

            //Instancia del objeto Crud para acceder a las funciones del inventario
            Crud instanciaCrud = new Crud();

            InteractuarConUsuario accion = new InteractuarConUsuario();

            //Obtenemos el inventario inicial
            Producto[] inventario = instanciaCrud.ObtenerProductos();

            //Mostramos el banner de la tienda y el inventario inicial
            MostrarBanner();
            accion.MostrarInventario(inventario, cabecera);

            //Bucle principal para el menú de opciones
            for (; ; )
            {
                //Mostramos el menú de opciones
                Console.WriteLine("\n1. Crear producto\n2. Actualizar producto\n3. Eliminar producto\n4. Vender producto\n5. Limpiar consola\n6. Salir");
                int solicitarId = int.Parse(Console.ReadLine());

                //Si el ID ortorgado es 5 entonces
                if ( solicitarId == 5)
                {
                    //Limpiamos la consola
                    Console.Clear();
                    //Mostramos el banner
                    MostrarBanner();
                    //Mostramos el inventario
                    accion.MostrarInventario(accion.GetInventarioActualizado(), cabecera);
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
                        accion.PedirNuevoProducto();
                        break;
                    case 2:
                        accion.PedirActualizarProducto();
                        break;
                    case 3:
                        accion.PedirEliminarProducto();
                        break;
                    case 4:
                        accion.PedirVenderProducto();
                        break;
                }
            }
        }
    }

    internal class Crud
    {
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

        // Propiedad para obtener el próximo identificador de producto
        public int id => inventario.Length + 1;

        // Método para agregar un nuevo producto al inventario
        public void CrearProducto(Producto nuevoProducto)
        {
            Array.Resize(ref inventario, this.inventario.Length + 1); // Aumentamos la longitud del array en 1
            inventario[inventario.Length - 1] = nuevoProducto; // Asignamos el nuevo producto en la última posición
        }


        // Método para obtener el inventario actual
        public Producto[] ObtenerProductos()
        {
            return inventario;
        }
        public void ActualizarProducto(int indice, Producto productoParaActualizar)
        {
            string nombre;

            if (indice >= 0 && indice < this.inventario.Length)
            {
                nombre = this.inventario[indice].Nombre;

                this.inventario[indice].Id = productoParaActualizar.Id;
                this.inventario[indice].Nombre = productoParaActualizar.Nombre;
                this.inventario[indice].Precio = productoParaActualizar.Precio;
                this.inventario[indice].Cantidad = productoParaActualizar.Cantidad;
                this.inventario[indice].Fecha = productoParaActualizar.Fecha;

                Console.WriteLine($"\nProducto {nombre} fue actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("\nEl indice esta fuera del rango del inventario.");
            }
        }

        public void EliminarProducto(int id)
        {
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
                    Console.WriteLine($"\nProducto {producto} ha sido eliminado exitosamente.\n");
                    //Redimensionar el array para eliminar el ultimo elemento
                    Array.Resize(ref this.inventario, this.inventario.Length - 1);
                }
            }

            //En caso de que el producto no sea encontrado mostramos mensaje informando al usuario
            Console.WriteLine($"\nEl producto con el ID {id} no se encuentra en el inventario.");
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

    internal class InteractuarConUsuario
    {
        //Cabecera para la tabla del inventario
        private string cabecera = $"ID \t Producto \t Precio \t Cantidad \t Fecha\n";
        private Crud instanciaCrud = new Crud();

        //Metodo para obtener los datos actualizado en tiempo real
        public Producto[] GetInventarioActualizado()
        {
            return this.instanciaCrud.ObtenerProductos();
        }

        //Metodo para mostrar el inventario
        public void MostrarInventario(Producto[] productos, string cabeceras)
        {
            //Mostramos las cabeceras del inventario
            Console.WriteLine(cabeceras);
            //Recorremos las filas del inventario
            foreach (Producto producto in productos)
            {
                //Mostramos los valores de cada fila
                Console.WriteLine(producto);
            }
        }

        //Metodo para crear un nuevo producto
        public void PedirNuevoProducto()
        {
            //Obtenemos el id proximo para crear el nuevo producto
            int identificador = this.instanciaCrud.id;

            //Le pedimos al usuario los datos correspondientes para crear el producto
            Console.Write("\nNombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("\nPrecio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("\nCantidad de productos disponibles: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("\nFecha use el formato YYY-MMM-DDD: \n");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            //Creamos un nuevo producto
            Producto nuevoProducto = new Producto(identificador, nombre, precio, cantidad, fecha);

            //Agregamos el nuevo producto al inventario
            this.instanciaCrud.CrearProducto(nuevoProducto);

            //Limpiamos la consola y mostramos el inventario actualizado
            this.MostrarInventario(this.instanciaCrud.ObtenerProductos(), this.cabecera);

            //Indicamos al usuario que el producto fue creado exitosamente
            Console.WriteLine($"\nProducto {nombre} creado exitosamente.");
        }

        public void PedirActualizarProducto()
        {
            Console.Write("\nIngrese indice del producto: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            // Utilizamos la misma instancia de Crud que se utilizó para obtener los productos inicialmente
            Producto[] productos = instanciaCrud.ObtenerProductos();

            Console.WriteLine("Producto a modificar:\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"nombre: {productos[indice].Nombre}\tprecio: {productos[indice].Precio}\tcantidad: {productos[indice].Cantidad}\tfecha: {productos[indice].Fecha}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\nNombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("\nPrecio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("\nCantidad de productos disponibles: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.Write("\nFecha use el formato YYY-MMM-DDD: ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
          
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

            //Obtenemos todos los datos
            Producto[] inventarioActualzado = this.instanciaCrud.ObtenerProductos();

            //Mostramos el inventario 
            this.MostrarInventario(inventarioActualzado, this.cabecera);
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

            //Mostramos un mensaje que informe al usuario que el producto fue eliminado
            Console.WriteLine($"\nSe ha eliminado el producto con ID {id} del inventario.");
            //Mostramos el inventario actualizado con los productos anteriormente creados
            this.MostrarInventario(inventarioActualzado, this.cabecera);
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
            //Indicamos al usuario que cantidad de productos quiere vender
            Console.Write("Ingrese cantidad a vender: ");
            //Convertimos la cantidad de productos que el usuario quiere vender a un numero entero
            int cantidadParaVender = int.Parse(Console.ReadLine());
      
            Console.ForegroundColor = ConsoleColor.Gray;

            //Si la cantidad que el usuario quiere vender es menor o igual a los existentes, entonces vendemos los productos
            if (cantidadParaVender <= cantidad)
            {
                //Calculamos los productos sobrantes, si es que quedan disponibles
                cantidadDeProductosRestantes = cantidad - cantidadParaVender;

                //Calculamos el pago del total a los productos que venderemos
                pago = (cantidadParaVender) * precio;
                //Mostramos el pago que el usuario quiere vender 
                Console.WriteLine($"\nMonto a pagar: {pago}");
            }
            else
            {
                //Si la cantidad no es menor o igual a los existentes entonces mostramos el siguiente mensaje 
                Console.WriteLine($"\nNo tienes suficientes {nombre} para vender");
            }

            //Si hay productos existentes entonces 
            if (cantidadDeProductosRestantes != 0)
            {
                //Modificamos la cantidad de productos
                producto.Cantidad = cantidadDeProductosRestantes;
                //Actualizamos el productos a vender
                instanciaCrud.ActualizarProducto(id, producto);
                //Mostramos el inventario actualizado
                MostrarInventario(instanciaCrud.ObtenerProductos(), cabecera);
            }

            //Si cantidadDeProductosRestantes es menor o igual a 0, quiere decir que el usuario quiere vender mas productos de los que tiene disponibles
            if (cantidadDeProductosRestantes <= 0)
            {
                //Mostramos un mensaje indicando que no tiene productos suficientes
                Console.WriteLine("\nTodos los productos han sido vendidos");
            }
        }
    }
}
