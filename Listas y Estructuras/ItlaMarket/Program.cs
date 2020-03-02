/*
 * debe realizar un pequeño sistema para un colmado , donde el colmadero puede agregar los productos de su negocio, 
 * los productos tienen nombre, precio y cantidad , lo puede editar y borrar, también puede mantener los clientes (Solo el nombre) 
 * así que puede agregar cliente, editarlo y borrarlos.
 * Por otra parte tiene la función de realizar ventas que le presentara una opción inicialmente de buscar al cliente introduciendo su nombre, 
 * una vez seleccionado el cliente, el sistema le permitirá buscar los productos disponible por su nombre, 
 * cuando se selecciona un producto pregunta la cantidad que desea de ese producto y si hay disponibilidad 
 * se agrega a la factura y se le pregunta si desea agregar mas productos o finalizar la venta 
 * pero sino tiene la cantidad debe decirle que no tiene y mostrale la cantidad que tiene , y preguntarle si desea introducir otra cantidad ,
 * buscar otro producto o cancelar la venta , en caso de que cancele la venta vuelve al menú principal.
 * Una vez finalizada la venta debe mostrase por pantalla el nombre del cliente , los productos que compro , 
 * con su cantidad y precio, un subtotal que es el precio por la cantidad y un total que es la suma de todos los subtotales.
 * Por ultimo el colmadero tiene una opción en el menú donde puede ver todas la ventas realizadas por clientes , 
 * en esta opción busca al cliente por su nombre una vez seleccionado el cliente se muestra el listado de todas sus facturas.
 */
using System;
using System.Collections.Generic;

namespace ItlaMarket
{
    class Program
    {
        /* Declaracion de estructura de producto */
        public struct producto { 
            public string nombre { get; set; }
            public double precio { get; set; }
            public int cantidad { get; set; }
        }

        /* Declaracion de estructura de facturas */
        public struct factura
        {
            public int idCliente { get; set; }
            public List<int> productos { get; set; }
            public double subTotal { get; set; }
            public double impuestos { get; set; }
            public double Total { get; set; }
        }

        /* Declarando e inicializando lista estatica de inventario para almacenar productos */
        public static List<producto> inventario = new List<producto>();

        /* Declarando e inicializando lista estatica de clientes */
        public static List<string> clientes = new List<string>();

        static void Main(string[] args)
        {   

            //Llamando metodo para mostrar el menu principal
                menuPrincipal();
            

            

            //inventario.Add(new producto { nombre = "Aguacate", precio = 25.00, cantidad = 12});

            /* foreach (producto unidad in inventario) 
             {
                 Console.WriteLine(unidad.nombre);
             }*/





        }

        /* Metodo para imprimir el menu principal */
        public static void menuPrincipal() 
        {
            Console.Clear();
            Console.WriteLine("Punto de venta - Menu principal");
            Console.WriteLine("1- Clientes");
            Console.WriteLine("2- Productos");
            Console.WriteLine("3- Facturas de venta");
            Console.WriteLine("4- Salir");

            //Declaracion de variable opcion
            int opcion;

            //Solicitar al usuario una opcion
            Console.WriteLine("Ingrese una de las opciones:");

            /* Almacenar opcion */
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Sentencia switch para evaluar la opcion escogida por el usuario */
            switch (opcion)
            {
                /* Clientes */
                case 1:

                    menuClientes();

                    break;

                /* Productos */
                case 2:

                    break;

                /* Facturas de venta */
                case 3:

                    break;

                /* Salir */
                case 4:
                    Console.WriteLine("Salir");
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }

        }

        /*
         * Metodos de clientes
         */

        /* Metodo para imprimir el menu de clientes */
        public static void menuClientes()
        {
            Console.Clear();
            Console.WriteLine("Punto de venta - Clientes");
            Console.WriteLine("1- Agregar Cliente");
            Console.WriteLine("2- Editar Cliente");
            Console.WriteLine("3- Borrar Cliente");
            Console.WriteLine("4- Listar Clientes");
            Console.WriteLine("5- Atras");

            //Declaracion de variable opcion
            int opcion;

            //Solicitar al usuario una opcion
            Console.WriteLine("Ingrese una de las opciones:");

            /* Almacenar opcion */
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Sentencia switch para evaluar la opcion escogida por el usuario */
            switch (opcion)
            {
                /* Agregar Cliente */
                case 1:

                    agregarCliente();

                    //Al terminar volver al menu de clientes
                    menuClientes();

                    break;

                /* Editar Cliente */
                case 2:
                    editarCliente();

                    //Al terminar volver al menu de clientes
                    menuClientes();

                    break;

                /* Borrar Cliente */
                case 3:

                    borrarCliente();

                    //Al terminar volver al menu de clientes
                    menuClientes();

                    break;

                /* Listar Clientes */
                case 4:
                    listarClientes();

                    //Al terminar volver al menu de clientes
                    menuClientes();

                    break;

                /* Atras */
                case 5:
                    menuPrincipal();
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }

           


        }

        /* Metodo para agregar clientes */
        public static void agregarCliente() 
        {
            Console.Clear();

            /* Solicitar al usuario el nombre del nuevo cliente */
            Console.WriteLine("Ingrese el nombre del nuevo cliente: ");
            clientes.Add(Console.ReadLine());

            //Al terminar volver al menu de clientes
            menuClientes();
        }

        /* Metodo para listar clientes */
        public static void listarClientes(bool esperar = true)
        {
            Console.Clear();

            /* Listar cliente */
            Console.WriteLine("Listado de clientes: ");
            int i = 1;

            foreach (string cliente in clientes)
            {
                Console.WriteLine(i + "- " + cliente);

                //Incrementar contador
                i++;

            }

            if (esperar)
            {
                /* Esperar letra para volver atras */
                Console.WriteLine("Pulse una tecla para volver atras.");
                Console.ReadKey();
            }
        }

        /* Metodo para editar clientes */
        public static void editarCliente()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay clientes
            if (clientes.Count > 0)
            {

                listarClientes(false);

                /* Solicitar al usuario el indice del cliente a modificar */
                Console.WriteLine("Ingrese el indice del cliente: ");

                int cliente = Convert.ToInt32(Console.ReadLine());

                /* Solicitar al usuario el nuevo nombre del cliente*/
                Console.WriteLine("Ingrese el nuevo nombre del cliente: ");

                clientes[(cliente - 1)] = Console.ReadLine();

            }
            else 
            {
                //Imprimir mensaje si no hay clientes
                Console.WriteLine("No hay clientes");
                Console.ReadKey();
            }

        }

        /* Metodo para borrar clientes */
        public static void borrarCliente()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay clientes
            if (clientes.Count > 0)
            {

                listarClientes(false);

                /* Solicitar al usuario el indice del cliente a borrar */
                Console.WriteLine("Ingrese el indice del cliente: ");

                int cliente = Convert.ToInt32(Console.ReadLine());

                /* Eliminar el cliente */
                clientes.RemoveAt(cliente - 1);

            }
            else
            {
                //Imprimir mensaje si no hay clientes
                Console.WriteLine("No hay clientes");
                Console.ReadKey();
            }

        }

        /*
         * Metodos de productos
         */

        /* Metodo para imprimir el menu de producto */
        public static void menuProductos()
        {
            Console.Clear();
            Console.WriteLine("Punto de venta - Productos");
            Console.WriteLine("1- Agregar Producto");
            Console.WriteLine("2- Editar Producto");
            Console.WriteLine("3- Borrar Producto");
            Console.WriteLine("4- Listar Productos");
            Console.WriteLine("5- Atras");

            //Declaracion de variable opcion
            int opcion;

            //Solicitar al usuario una opcion
            Console.WriteLine("Ingrese una de las opciones:");

            /* Almacenar opcion */
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Sentencia switch para evaluar la opcion escogida por el usuario */
            switch (opcion)
            {
                /* Agregar Producto */
                case 1:

                    agregarProducto();

                    //Al terminar volver al menu de Productos
                    menuProductos();

                    break;

                /* Editar Producto */
                case 2:
                    editarProducto();

                    //Al terminar volver al menu de Productos
                    menuProductos();

                    break;

                /* Borrar Producto */
                case 3:

                    borrarProducto();

                    //Al terminar volver al menu de Productos
                    menuProductos();

                    break;

                /* Listar Productos */
                case 4:
                    listarProductos();

                    //Al terminar volver al menu de Productos
                    menuProductos();

                    break;

                /* Atras */
                case 5:
                    menuPrincipal();
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }




        }

        /* Metodo para agregar productos */
        public static void agregarProducto()
        {
            Console.Clear();

            /* Solicitar al usuario el nombre del nuevo Producto */
            Console.WriteLine("Ingrese el nombre del nuevo producto: ");
            string nombre = Console.ReadLine();

            /* Solicitar al usuario el precio del nuevo Producto */
            Console.WriteLine("Ingrese el precio del nuevo producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            /* Solicitar al usuario la cantidad del nuevo Producto */
            Console.WriteLine("Ingrese la cantidad del nuevo producto: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            inventario.Add(new producto { nombre = nombre, precio = precio, cantidad = cantidad });

            //Al terminar volver al menu de Productos
            menuProductos();
        }

        /* Metodo para listar productos */
        public static void listarProductos(bool esperar = true)
        {
            Console.Clear();

            /* Listar producto */
            Console.WriteLine("Listado de productos: ");
            int i = 1;

            foreach (producto producto in inventario)
            {
                Console.WriteLine(i + "- " + producto);

                //Incrementar contador
                i++;

            }

            if (esperar)
            {
                /* Esperar letra para volver atras */
                Console.WriteLine("Pulse una tecla para volver atras.");
                Console.ReadKey();
            }
        }

        /* Metodo para editar productos */
        public static void editarProducto()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay productos
            if (inventario.Count > 0)
            {

                listarClientes(false);

                /* Solicitar al usuario el indice del producto a modificar */
                Console.WriteLine("Ingrese el indice del producto: ");

                int producto = Convert.ToInt32(Console.ReadLine());

                /* Solicitar al usuario el nuevo nombre del producto */
                Console.WriteLine("Ingrese el nuevo nombre del producto: ");

                string nombre = Console.ReadLine();

            }
            else
            {
                //Imprimir mensaje si no hay productos
                Console.WriteLine("No hay productos");
                Console.ReadKey();
            }

        }

        /* Metodo para borrar productos */
        public static void borrarProducto()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay productos
            if (inventario.Count > 0)
            {

                listarProductos(false);

                /* Solicitar al usuario el indice del cliente a borrar */
                Console.WriteLine("Ingrese el indice del producto: ");

                int producto = Convert.ToInt32(Console.ReadLine());

                /* Eliminar el producto */
                clientes.RemoveAt(producto - 1);

            }
            else
            {
                //Imprimir mensaje si no hay productos
                Console.WriteLine("No hay productos");
                Console.ReadKey();
            }

        }


    }
}
