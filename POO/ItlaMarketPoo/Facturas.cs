using System;
using System.Collections.Generic;
using System.Text;

namespace ItlaMarketPoo
{
    static class Facturas
    {
        // Declarando enum para menu de facturas
        enum MenuFacturas { Agregar = 1, Listar, Atras };

        /* Declarando e inicializando lista estatica de facturas */
        public static List<Factura> facturas = new List<Factura>();

        /* Declaracion de constante estatica para los impuestos */
        public static double ITBIS = 18.00;

        /* Metodo para imprimir el menu de factura */
        public static void Menu()
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
                case (int)MenuFacturas.Agregar:

                    Facturas.Agregar();

                    //Al terminar volver al menu de Facturas
                    Facturas.Menu();

                    break;

                /* Listar Facturas */
                case (int)MenuFacturas.Listar:
                    Facturas.Listar();

                    //Al terminar volver al menu de Facturas
                    Facturas.Menu();

                    break;

                /* Atras */
                case (int)MenuFacturas.Atras:
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

            bool seguirComprando = true;

            Clientes.Listar(false);

            /* Solicitar al usuario el cliente que realizara la compra */
            Console.WriteLine("Ingrese el indice del cliente: ");
            int cliente = Convert.ToInt32(Console.ReadLine());

            //Crear factura dentro de la lista de facturas
            facturas.Add(new Factura { cliente = Clientes.clientes[cliente - 1], productos = new List<Producto>(), subTotal = 0.00, impuestos = 0.00, total = 0.00 });

            //Creando variable para almacenar el indice de la factura actual
            int indiceFactura = facturas.Count - 1;

            //Crear instancia de la factura actual para ir agregandole los productos
            Factura factura = facturas[indiceFactura];

            //Ciclo do while para agregar productos mientras el usuario quiera
            do
            {
                Inventario.Listar(false);

                /* Solicitar al usuario el producto que desea agregar */
                Console.WriteLine("Ingrese el indice del producto a agregar: ");
                int indiceProducto = Convert.ToInt32(Console.ReadLine());

                /* Instanciar productos para actualizar el inventario */
                Producto producto = Inventario.inventario[indiceProducto - 1];


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
                factura.productos.Add(new Producto { nombre = producto.nombre, precio = (double)(producto.precio * cantidad), cantidad = cantidad });

                /* Sumar el valor del precio del producto por la cantidad al subtotal */
                factura.subTotal += (double)(producto.precio * cantidad);

                /* Decrementar la cantidad solicitada al producto en el inventario */
                producto.cantidad -= cantidad;
                Inventario.inventario[indiceProducto - 1] = producto;

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
        public static void Listar(bool esperar = true)
        {
            Console.Clear();

            /* Listar factura */
            Console.WriteLine("Listado de facturas: ");

            /* Foreach para imprimir las facturas */
            for (int a = 1; a <= facturas.Count; a++)
            {
                //Instanciar factura actual
                Factura factura = facturas[a - 1];

                /* Imprimir cliente */
                Console.WriteLine(Environment.NewLine + "Factura No. " + a + " del cliente: " + factura.cliente);

                /* Foreach para imprimir las facturas */
                for (int b = 1; b <= factura.productos.Count; b++)
                {
                    //Instanciar factura actual
                    Producto producto = factura.productos[b - 1];

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
