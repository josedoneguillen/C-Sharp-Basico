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
            public string idCliente { get; set; }
            public List<int> productos { get; set; }
            public double subTotal { get; set; }
            public int Total { get; set; }
        }

        static void Main(string[] args)
        {
            List<producto> inventario = new List<producto>();
            inventario.Add(new producto { nombre = "Aguacate", precio = 25.00, cantidad = 12});
            inventario.Add(new producto { nombre = "Manzana", precio = 30.00, cantidad = 24});

            foreach (producto unidad in inventario) 
            {
                Console.WriteLine(unidad.nombre);
            }

        }
    }
}
