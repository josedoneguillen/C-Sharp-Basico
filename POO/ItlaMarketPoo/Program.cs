using System;
using System.Collections.Generic;

namespace ItlaMarketPoo
{
    class Program
    {
        // Declaracion de enum para el menu principal de opciones
        enum MenuPrincipal { Clientes = 1, Productos, Facturas, Salir };

        static void Main(string[] args)
        {
            // Llamado al metodo menu de opciones
            menuPrincipal();


        }

        /* Metodo menu principa; */
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
                case (int)MenuPrincipal.Clientes:
                    Clientes.Menu();
                    break;

                /* Productos */
                case (int)MenuPrincipal.Productos:
                    Inventario.Menu();
                    break;

                /* Facturas de venta */
                case (int)MenuPrincipal.Facturas:
                    Facturas.Menu();
                    break;

                /* Salir */
                case (int)MenuPrincipal.Salir:
                    Console.WriteLine("Salir");
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }

        }
    }
}
