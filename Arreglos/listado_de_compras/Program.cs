using System;

namespace listado_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.	Debe realizar aplicación que permita administrar el listado de la compra de alimentos, solo 10 alimentos por listado, 
             * en el mismo podemos agregar alimentos pero cada alimento pertenece a una de estas categorías: frutas, vegetales o lácteos, 
             * de manera que antes de agregar un alimento al listado debemos saber a cuál categoría pertenece. 
             * También el sistema permite listar la lista de compra de las siguientes maneras, el sistema nos permite elegir entre listar solo las frutas, solo los vegetales, 
             * solo los lácteos o todos los alimentos. Podemos editar los alimentos de las diferentes listas de compra, 
             * para editar algún alimento primero debemos seleccionar de cual lista es que modificaremos el alimento. 
             * Finalmente podemos borrar los alimentos de las diferentes listas de compra, 
             * para borrar algún alimento primero debemos seleccionar de cual lista es que borraremos el alimento. 
             */

            /* Declaracion de variables */
            int opcion = 0, categoria = 0;
            string[,] alimentos = new string[3,10];
            string[] categorias = {"Frutas", "Vegetales", "Lácteos"};
            bool salir = false;

            /* Ciclo while para que el usuario pueda navegar dentro de las opciones */
            while (!salir)
            {

                /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                Console.Clear();

                /* Presentar menu de opciones principal al usuario */
                Console.WriteLine("Bienvenido a su lista de compras, seleccione una opción:");
                Console.WriteLine("1- Agregar alimentos");
                Console.WriteLine("2- Modificar alimentos");
                Console.WriteLine("3- Eliminar alimentos");
                Console.WriteLine("4- Ver lista completa");
                Console.WriteLine("5- Salir");

                /* Almacenar la opcion seleccionada por el usuario en la variable opcion */
                opcion = Convert.ToInt32(Console.ReadLine());

                /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                Console.Clear();

                /* Presentar categorias */
                Console.WriteLine("Seleccione la categoria que desea afectar:");
                Console.WriteLine("1- Frutas");
                Console.WriteLine("2- Vegetales");
                Console.WriteLine("3- Lácteos");

                /* Almacenar la categoria seleccionada por el usuario en la variable categoria */
                categoria = (Convert.ToInt32(Console.ReadLine())-1);

                /* Sentencia switch para realizar la opcion elegida por el usuario segun cada caso */
                switch (opcion)
                {
                    /* Agregar alimentos */
                    case 1:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Mostrar al usuario en que categoria de lista se encuentra */
                        Console.WriteLine("Lista de " + categorias[categoria]);

                        /* Declaración if para validar si la lista seleccionada no esta llena */
                        if (alimentos[categoria, 9] == null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 9; a++)  
                            {
                                /* Declaración if para validar que espacio esta disponible */
                                if (alimentos[categoria, a] == null) 
                                {
                                    /* Solicitar al usuario el nombre del alimento */
                                    Console.WriteLine("Ingrese nombre del alimento que desea agregar: ");

                                    /* Almacenar el nombre del alimento en el espacio disponible */
                                    alimentos[categoria, a] = Console.ReadLine();

                                    /* Romper el ciclo for ya que se encontro y utilizo el espacio disponible */
                                    break;
                                }
                            }
                        }
                        else {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta llena");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Modificar alimentos */
                    case 2:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Mostrar al usuario en que categoria de lista se encuentra */
                        Console.WriteLine("Lista de " + categorias[categoria]);

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (alimentos[categoria, 0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 9; a++)
                            {
                                /* Declaración if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (alimentos[categoria, a] != null)
                                {
                                    /* Imprimir listado de alimentos */
                                    Console.WriteLine((a+1) + "- " + alimentos[categoria, a]);
                                }
                            }

                            /* Solicitar el indice del alimento a modificar */
                            Console.WriteLine("Ingrese indice numerico del alimento que desea editar: ");

                            /* Almacenar el indice del alimento en la variable editar */
                            int editar = (Convert.ToInt32(Console.ReadLine())-1);

                            /* Solicitar al usuario el nuevo nombre del alimento */
                            Console.WriteLine("Ingrese el nuevo nombre del alimento que desea editar: ");

                            /* Almacenar el nuevo nombre del alimento en la espacio especificado */
                            alimentos[categoria, editar] = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un alimento primero!");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Eliminar alimentos */
                    case 3:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Mostrar al usuario en que categoria de lista se encuentra */
                        Console.WriteLine("Lista de " + categorias[categoria]);

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (alimentos[categoria, 0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 9; a++)
                            {
                                /* Declaracion if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (alimentos[categoria, a] != null)
                                {
                                    /* Imprimir listado de alimentos */
                                    Console.WriteLine((a + 1) + "- " + alimentos[categoria, a]);
                                }
                            }

                            /* Solicitar el indice del alimento a eliminar */
                            Console.WriteLine("Ingrese indice numerico del alimento que desea eliminar: ");

                            /* Almacenar el indice del alimento en la variable eliminar */
                            int eliminar = (Convert.ToInt32(Console.ReadLine()) - 1);

                            /* Almacenar el nuevo nombre del alimento en la espacio especificado */
                            alimentos[categoria, eliminar] = null;

                            /* Luego de eliminar un elemento debemos re organizar la lista agrupando las posiciones con valor, 
                             * parecido a la desfragmentacion de discos duros
                             */
                             string[,] reindex = new string[3,10];

                            /* Recorrer todas las categorias */
                            for (int b = 0; b <=2; b++) 
                            {
                                /*Declarar index*/
                                var i = 0;

                                /* Recorrer todos los alimentos de la categoria en curso */
                                for (int c = 0; c <= 9; c++)
                                {
                                    /* Declaracion if validar si el espacio actual esta ocupado para agregarlo a re index */
                                    if (alimentos[b,c] != null) 
                                    {
                                        /* Almacenar valor en re index */
                                        reindex[b, i] = alimentos[b,c];

                                        /* Aumentar contador index solo si se encuentra un valor que agregar */
                                        i++;
                                    }
                                }
                            }

                            /* Asignar matriz re index a alimientos para igualar su contenido */
                            alimentos = reindex;

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un alimento primero!");

                            /* Esperar tecla para continuar */
                            Console.WriteLine("Pulse un tecla para volver al menu");
                            Console.ReadKey();
                        }

                        break;

                    /* Listar alimentos */
                    case 4:

                        /* Limpiar la consola en cada iteracion para mantener una buena legibilidad */
                        Console.Clear();

                        /* Mostrar al usuario en que categoria de lista se encuentra */
                        Console.WriteLine("Lista de " + categorias[categoria]);

                        /* Declaración if para validar si la lista seleccionada no esta vacia */
                        if (alimentos[categoria, 0] != null)
                        {
                            /* Recorrer el arreglo hasta encontrar un espacio vacio */
                            for (int a = 0; a <= 9; a++)
                            {
                                /* Declaracion if para validar que el espacio no esta vacio para imprimirlo en pantalla */
                                if (alimentos[categoria, a] != null)
                                {
                                    /* Imprimir listado de alimentos */
                                    Console.WriteLine((a + 1) + "- " + alimentos[categoria, a]);
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, la lista seleccionada esta vacia. por favor agrege un alimento primero!");
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
