using System;
using System.Collections.Generic;
using System.Text;

namespace ItlaMarketPoo
{
    static class Inventario
    {
        // Declarando enum para menu de clientes
        enum MenuInventario { Agregar = 1, Editar, Borrar, Listar, Atras };

        // Lista para almacenar los productos
        public static List<Producto> inventario = new List<Producto>();

        //Metodo para agregar productos al inventario
        public static void Agregar(string nombre, double precio, int cantidad) {

            inventario.Add(new Producto { nombre = nombre, precio = precio, cantidad = cantidad });

        }

        /* Metodo para imprimir el menu de producto */
        public static void Menu()
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
                case (int)MenuInventario.Agregar:

                    Inventario.Agregar();

                    //Al terminar volver al menu de Productos
                    Inventario.Menu();

                    break;

                /* Editar Producto */
                case (int)MenuInventario.Editar:
                    Inventario.Editar();

                    //Al terminar volver al menu de Productos
                    Inventario.Menu();

                    break;

                /* Borrar Producto */
                case (int)MenuInventario.Borrar:

                    Inventario.Borrar();

                    //Al terminar volver al menu de Productos
                    Inventario.Menu();

                    break;

                /* Listar Productos */
                case (int)MenuInventario.Listar:
                    Inventario.Listar();

                    //Al terminar volver al menu de Productos
                    Inventario.Menu();

                    break;

                /* Atras */
                case (int)MenuInventario.Atras:
                    Program.menuPrincipal();
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }




        }


        /* Metodo para agregar productos */
        public static void Agregar()
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
            inventario.Add(new Producto { nombre = nombre, precio = precio, cantidad = cantidad });
        }

        /* Metodo para listar productos */
        public static void listarProductos(bool esperar = true)
        {
            Console.Clear();

            /* Listar producto */
            Console.WriteLine("Listado de productos: ");
            int i = 1;

            foreach (Producto producto in inventario)
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


        /* Metodo para listar los productos del inventario */
        public static void Listar(bool esperar = true)
        {
            Console.Clear();

            /* Listar producto */
            Console.WriteLine("Listado de productos: ");
            int i = 1;

            foreach (Producto producto in inventario)
            {
                Console.WriteLine(i + "- Nombre: " + producto.nombre + " Precio: " + producto.precio + " Cantidad: " + producto.cantidad);

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
        public static void Editar()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay productos
            if (inventario.Count > 0)
            {

                Inventario.Listar(false);

                /* Solicitar al usuario el indice del producto a modificar */
                Console.WriteLine("Ingrese el indice del producto: ");

                int indice = Convert.ToInt32(Console.ReadLine());

                //Creando instancia del producto elegido para poder modificarlo
                Producto producto = inventario[indice - 1];

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
                producto.Editar(nombre, precio, cantidad);


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
        public static void Borrar()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay productos
            if (inventario.Count > 0)
            {

                Inventario.Listar(false);

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

    }
}
