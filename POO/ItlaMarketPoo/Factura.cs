using System;
using System.Collections.Generic;
using System.Text;

namespace ItlaMarketPoo
{
    class Factura
    {
        public string cliente;
        public List<Producto> productos;
        public double subTotal;
        public double impuestos;
        public double total;
    }
}
