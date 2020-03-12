using System;
using System.Collections.Generic;
using System.Text;

namespace ItlaMarketPoo
{
    static class Clientes
    {
        // Declarando enum para menu de clientes
        enum MenuClientes { Agregar = 1, Editar, Borrar, Listar, Atras };
    

        /* Declarando e inicializando lista estatica de clientes */
        public static List<string> clientes = new List<string>();

        /* Metodo para imprimir el menu de clientes */
        public static void Menu()
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
                case (int)MenuClientes.Agregar:

                    Clientes.Agregar();

                    //Al terminar volver al menu de clientes
                    Clientes.Menu();

                    break;

                /* Editar Cliente */
                case (int)MenuClientes.Editar:
                    Clientes.Editar();

                    //Al terminar volver al menu de clientes
                    Clientes.Menu();

                    break;

                /* Borrar Cliente */
                case (int)MenuClientes.Borrar:

                    Clientes.Borrar();

                    //Al terminar volver al menu de clientes
                    Clientes.Menu();

                    break;

                /* Listar Clientes */
                case (int)MenuClientes.Listar:
                    Clientes.Listar();

                    //Al terminar volver al menu de clientes
                    Clientes.Menu();

                    break;

                /* Atras */
                case (int)MenuClientes.Atras:
                    Program.menuPrincipal();
                    break;

                /* Defecto */
                default:
                    Console.WriteLine("La opcion elegida no existe!");
                    break;
            }




        }

        /* Metodo para agregar clientes */
        public static void Agregar()
        {
            Console.Clear();

            /* Solicitar al usuario el nombre del nuevo cliente */
            Console.WriteLine("Ingrese el nombre del nuevo cliente: ");
            clientes.Add(Console.ReadLine());
        }

        /* Metodo para listar clientes */
        public static void Listar(bool esperar = true)
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
        public static void Editar()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay clientes
            if (clientes.Count > 0)
            {

                Clientes.Listar(false);

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
        public static void Borrar()
        {
            Console.Clear();

            //Sentencia if para comprobar si hay clientes
            if (clientes.Count > 0)
            {

                Clientes.Listar(false);

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

    }
}
