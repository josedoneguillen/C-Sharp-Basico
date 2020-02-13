using System;

namespace lista_de_contactos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2. Realizar una aplicación que permita administrar una lista de contacto, 
             * en este podemos agregar, listar, editar y eliminar contactos, la cantidad de contactos maximos es 15. 
             */

            /* Declaracion de variables */
            int opcion = 0;
            string[] contactos = new string[15];
            bool salir = false;

            /* Ciclo while para que el usuario pueda navegar dentro de las opciones */
            while (!salir)
            {

                /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                Console.Clear();

                /* Presentar menu de opciones principal al usuario */
                Console.WriteLine("Bienvenido a su lista de contactos, seleccione una opción:");
                Console.WriteLine("1- Agregar contacto");
                Console.WriteLine("2- Modificar contacto");
                Console.WriteLine("3- Eliminar contacto");
                Console.WriteLine("4- Ver lista completa");
                Console.WriteLine("5- Salir");

                /* Almacenar la opcion seleccionada por el usuario en la variable opcion */
                opcion = Convert.ToInt32(Console.ReadLine());

                /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                Console.Clear();

                /* Sentencia switch para realizar la opcion elegida por el usuario segun cada caso */
                switch (opcion)
                {
                    /* Agregar contacto */
                    case 1:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Declaración if para validar si la lista seleccionada no esta llena */
                        if (contactos[14] == null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 14; a++)
                            {
                                /* Declaración if para validar que espacio esta disponible */
                                if (contactos[a] == null)
                                {
                                    /* Solicitar al usuario el nombre del contacto */
                                    Console.WriteLine("Ingrese nombre del contacto que desea agregar: ");

                                    /* Almacenar el nombre del contacto en el espacio disponible */
                                    contactos[a] = Console.ReadLine();

                                    /* Romper el ciclo for ya que se encontro y utilizo el espacio disponible */
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta llena");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Modificar contactos */
                    case 2:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (contactos[0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 14; a++)
                            {
                                /* Declaración if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (contactos[a] != null)
                                {
                                    /* Imprimir listado de contactos */
                                    Console.WriteLine((a + 1) + "- " + contactos[a]);
                                }
                            }

                            /* Solicitar el indice del contacto a modificar */
                            Console.WriteLine("Ingrese indice numerico del contacto que desea editar: ");

                            /* Almacenar el indice del contacto en la variable editar */
                            int editar = (Convert.ToInt32(Console.ReadLine()) - 1);

                            /* Solicitar al usuario el nuevo nombre del contacto */
                            Console.WriteLine("Ingrese el nuevo nombre del contacto que desea editar: ");

                            /* Almacenar el nuevo nombre del contacto en la espacio especificado */
                            contactos[editar] = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un contacto primero!");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Eliminar contactos */
                    case 3:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (contactos[0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 14; a++)
                            {
                                /* Declaracion if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (contactos[a] != null)
                                {
                                    /* Imprimir listado de contactos */
                                    Console.WriteLine((a + 1) + "- " + contactos[a]);
                                }
                            }

                            /* Solicitar el indice del contacto a eliminar */
                            Console.WriteLine("Ingrese indice numerico del contacto que desea eliminar: ");

                            /* Almacenar el indice del contacto en la variable eliminar */
                            int eliminar = (Convert.ToInt32(Console.ReadLine()) - 1);

                            /* Almacenar el nuevo nombre del contacto en la espacio especificado */
                            contactos[eliminar] = null;

                            /* Luego de eliminar un elemento debemos re organizar la lista agrupando las posiciones con valor, 
                             * parecido a la desfragmentacion de discos duros
                             */
                            string[] reindex = new string[15];

                            /*Declarar index*/
                            var i = 0;

                            /* Recorrer todos los contactos de la categoria en curso */
                            for (int c = 0; c <= 14; c++)
                            {
                                /* Declaracion if validar si el espacio actual esta ocupado para agregarlo a re index */
                                if (contactos[c] != null)
                                {
                                    /* Almacenar valor en re index */
                                    reindex[i] = contactos[c];

                                    /* Aumentar contador index solo si se encuentra un valor que agregar */
                                    i++;
                                }
                            }


                            /* Asignar matriz re index a alimientos para igualar su contenido */
                            contactos = reindex;

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un contacto primero!");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Listar contactos */
                    case 4:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (contactos[0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 14; a++)
                            {
                                /* Declaracion if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (contactos[a] != null)
                                {
                                    /* Imprimir listado de contactos */
                                    Console.WriteLine((a + 1) + "- " + contactos[a]);
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un contacto primero!");
                        }

                        /* Esperar tecla para continuar */
                        Console.WriteLine("Pulse un tecla para volver al menu");
                        Console.ReadKey();

                        break;

                    case 5:

                        /* Cambiar el estado de la variable salir a true para romper el ciclo while */
                        salir = true;

                        break;

                    default:

                        /* Mensaje de opcion desconocida */
                        Console.WriteLine("La opcion seleccionada no existe, por favor intente de nuevo");

                        /* Esperar tecla para continuar */
                        Console.WriteLine("Pulse un tecla para volver al menu");
                        Console.ReadKey();

                        break;
                }

            }

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
