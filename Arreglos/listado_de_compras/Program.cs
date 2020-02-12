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

            Console.WriteLine("Bienvenido a su lista de compras");
            Console.WriteLine("1- Agregar alimentos");
            Console.WriteLine("2- Modificar alimentos");
            Console.WriteLine("3- Eliminar alimentos");
            Console.WriteLine("4- Ver lista completa");

            /* Esperar letra para cerrar */
            Console.WriteLine("Pulse una tecla para cerrar el programa.");
            Console.ReadKey();
        }
    }
}
