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

            public void editar(string nombre, double precio, int cantidad)
            {
                this.nombre = nombre;
                this.precio = precio;
                this.cantidad = cantidad;
            }

        }

        /* Declaracion de estructura de facturas */
        public struct factura
        {
            public string cliente { get; set; }
            public List<producto> productos { get; set; }
            public double subTotal { get; set; }
            public double impuestos { get; set; }
            public double total { get; set; }
        }

        /* Declarando e inicializando lista estatica de inventario para almacenar productos */
        public static List<producto> inventario = new List<producto>();

        /* Declarando e inicializando lista estatica de clientes */
        public static List<string> clientes = new List<string>();

        /* Declarando e inicializando lista estatica de facturas */
        public static List<factura> facturas = new List<factura>();

        /* Declaracion de constante estatica para los impuestos */
        public static double ITBIS = 18.00;

        static void Main(string[] args)
        {   

            //Llamando metodo para mostrar el menu principal
                menuPrincipal();


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
            int? opcion = null;

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
                    menuProductos();
                    break;

                /* Facturas de venta */
                case 3:
                    menuFacturas();
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
            int? opcion = null;

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
            int? opcion = null;

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

            //Agregar producto a la lista de inventario
            inventario.Add(new producto { nombre = nombre, precio = precio, cantidad = cantidad });
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
                Console.WriteLine(i + "- Nombre: " + producto.nombre + ", Precio: RD$ " + producto.precio + ", Cantidad: " + producto.cantidad);

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

                listarProductos(false);

                /* Solicitar al usuario el indice del producto a modificar */
                Console.WriteLine("Ingrese el indice del producto: ");

                int indice = Convert.ToInt32(Console.ReadLine());

                //Creando instancia del producto elegido para poder modificarlo
                producto producto = inventario[indice -1];

                /* Solicitar al usuario el nuevo nombre del producto */
                Console.WriteLine("Ingrese el nuevo nombre del producto: ");

                string nombre = Console.ReadLine();

                /* Solicitar al usuario el nuevo precio del producto */
                Console.WriteLine("Ingrese el nuevo precio del producto: ");

                double precio = Convert.ToDouble(Console.ReadLine());
               
                /* Solicitar al usuario el nuevo nombre del producto */
                Console.WriteLine("Ingrese la nueva cantidad del producto: ");

                int cantidad = Convert.ToInt32(Console.ReadLine());

                /* Asignando valores al metodo editar de la instancia */
                producto.editar(nombre, precio, cantidad);


                /* Asignando instancia a su posicion en la lista */
                inventario[indice - 1] = producto;

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
                inventario.RemoveAt(producto - 1);

            }
            else
            {
                //Imprimir mensaje si no hay productos
                Console.WriteLine("No hay productos");
                Console.ReadKey();
            }

        }

        /*
         * Metodos de facturas
         */

        /* Metodo para imprimir el menu de factura */
        public static void menuFacturas()
        {
            Console.Clear();
            Console.WriteLine("Punto de venta - Facturas");
            Console.WriteLine("1- Agregar Factura");
            Console.WriteLine("2- Listar Facturas");
            Console.WriteLine("3- Atras");

            //Declaracion de variable opcion
            int? opcion = null;

            //Solicitar al usuario una opcion
            Console.WriteLine("Ingrese una de las opciones:");

            /* Almacenar opcion */
            opcion = Convert.ToInt32(Console.ReadLine());

            /* Sentencia switch para evaluar la opcion escogida por el usuario */
            switch (opcion)
            {
                /* Agregar Factura */
                case 1:

                    agregarFactura();

                    //Al terminar volver al menu de Facturas
                    menuFacturas();

                    break;

                /* Listar Facturas */
                case 2:
                    listarFacturas();

                    //Al terminar volver al menu de Facturas
                    menuFacturas();

                    break;

                /* Atras */
                case 3:
                    menuPrincipal();
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }




        }

        /* Metodo para agregar productos */
        public static void agregarFactura()
        {
            Console.Clear();

            bool seguirComprando = true;

            listarClientes(false);

            /* Solicitar al usuario el cliente que realizara la compra */
            Console.WriteLine("Ingrese el indice del cliente: ");
            int cliente = Convert.ToInt32(Console.ReadLine());

            //Crear factura dentro de la lista de facturas
            facturas.Add(new factura { cliente = clientes[cliente - 1], productos = new List<producto>(), subTotal = 0.00, impuestos = 0.00, total = 0.00 });

            //Creando variable para almacenar el indice de la factura actual
            int indiceFactura = facturas.Count - 1;

            //Crear instancia de la factura actual para ir agregandole los productos
            factura factura = facturas[indiceFactura];

            //Ciclo do while para agregar productos mientras el usuario quiera
            do {
                listarProductos(false);

                /* Solicitar al usuario el producto que desea agregar */
                Console.WriteLine("Ingrese el indice del producto a agregar: ");
                int indiceProducto = Convert.ToInt32(Console.ReadLine());

                /* Instanciar productos para actualizar el inventario */
                producto producto = inventario[indiceProducto - 1];


                //Declarar variable de cantidad y para ingresar otra cantidad
                bool otraCantidad = true;
                int cantidad;

                //Bucle do while para preguntar al usuario si desea ingresar otra cantidad
                do
                {
                    /* Solicitar al usuario la cantidad del nuevo Producto */
                    Console.WriteLine("Ingrese la cantidad: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    //Sentencia if para comparar si la cantidad ingresada por el usuario es mayor a la existente
                    if (cantidad > producto.cantidad || producto.cantidad == 0)
                    {
                        Console.WriteLine("La cantidad que ingreso supera la disponibilidad de este producto que es de solo {0} unidades", producto.cantidad);

                        /* Preguntar al usuario si desea ingresar otro monto */
                        Console.WriteLine("Ingrese (S) para agregar nueva cantidad y (N) para escoger otro producto: ");
                        otraCantidad = (Console.ReadLine() == "s") ? true : false;
                    }
                    else 
                    {
                        break;
                    }

                } while (otraCantidad);

                // Si otra cantidad es false reiniciamos el ciclo
                if (otraCantidad == false)
                {
                    continue;
                }

                /* Agregar producto a la nueva factura */
                factura.productos.Add(new producto { nombre =  producto.nombre, precio = (producto.precio * cantidad), cantidad = cantidad});
                
                /* Sumar el valor del precio del producto por la cantidad al subtotal */
                factura.subTotal += (producto.precio * cantidad);

                /* Decrementar la cantidad solicitada al producto en el inventario */
                producto.cantidad -= cantidad;
                inventario[indiceProducto - 1] = producto;

                /* Preguntar al usuario si desea salir de la facturacion */
                Console.WriteLine("Ingrese (S) para seguir comprando y (N) para salir: ");
                seguirComprando = (Console.ReadLine() == "s") ? true : false;

            } while (seguirComprando);

            //Calcular impuestos
            factura.impuestos = factura.subTotal * (ITBIS / 100);

            //Calcular total
            factura.total = factura.subTotal + factura.impuestos;

            /* Asignar la instancia modificada de la factura a su posicion en la lista de facturas*/
            facturas[indiceFactura] = factura;
        }

        /* Metodo para listar facturas */
        public static void listarFacturas(bool esperar = true)
        {
            Console.Clear();

            /* Listar factura */
            Console.WriteLine("Listado de facturas: ");

            /* Foreach para imprimir las facturas */
            for (int a = 1; a <= facturas.Count; a++) 
            {
                //Instanciar factura actual
                factura factura = facturas[a-1];

                /* Imprimir cliente */
                Console.WriteLine(Environment.NewLine + "Factura No. " + a + " del cliente: " + factura.cliente);

                /* Foreach para imprimir las facturas */
                for (int b = 1; b <= factura.productos.Count; b++)
                {
                    //Instanciar factura actual
                    producto producto = factura.productos[b-1];

                    Console.WriteLine(Environment.NewLine + b + "- Nombre: " + producto.nombre + ", Precio: RD$ " + producto.precio + ", Cantidad: " + producto.cantidad);

                }

                /* Imprimir subtotal */
                Console.WriteLine(Environment.NewLine + "SubTotal: RD$ " + factura.subTotal);

                /* Imprimir impuestos */
                Console.WriteLine("Impuestos: RD$ " + factura.impuestos);

                /* Imprimir total */
                Console.WriteLine("Total: RD$ " + factura.total);

                /* Imprimir separador */
                Console.WriteLine(Environment.NewLine + "==========================================================================" + Environment.NewLine);

            }

            if (esperar)
            {
                /* Esperar letra para volver atras */
                Console.WriteLine("Pulse una tecla para volver atras.");
                Console.ReadKey();
            }
        }
    }
}
