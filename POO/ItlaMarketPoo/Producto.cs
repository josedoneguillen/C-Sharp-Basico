using System;
using System.Collections.Generic;
using System.Text;

namespace ItlaMarketPoo
{
    class Producto
    {
        public string nombre;
        public double precio;
        public int cantidad;
    

        // Metodo para editar producto
        public void Editar(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

    }
}
