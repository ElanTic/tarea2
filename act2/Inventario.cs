using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2
{
    internal class Inventario
    {
        private List<Producto> products;
        private List<Venta> sells;
        public Inventario()
        {
            products = new List<Producto>();
            sells = new List<Venta>();
        }
        public void agrega(Producto product)
        {
            products.Add(product);
        }
        public void vender(Venta venta)
        {
            sells.Add(venta);
            List<Producto> pVendidos = venta.Productos;
            foreach (Producto p in pVendidos)
            {
                p.vendios = p.vendios+1;
            }
        }
        public List<Producto> getProductos() { return products; }

        public List<Venta> getVentas() { return sells; }
        public Producto[] masVendidos()
        {
            //Counting sort;
            int mayor = 0;
            //obtengo al mayor
            foreach (Producto product in products)
            {
                if (product.vendios> mayor) mayor = product.vendios;

            }
            Producto[] temporal = new Producto[mayor+1];
            foreach (Producto product in products) {
                int orden = mayor - product.vendios; //orden decendente
                if (temporal[orden] != null) temporal[orden].ligar(product);
                else temporal[orden] = product; 
            }
            List<Producto> salida = new List<Producto>();
            foreach (Producto product in temporal)
            {
                Producto temporal2 = product;
                while (temporal2 != null)
                {
                    salida.Add(temporal2);
                    temporal2 = temporal2.getNext();
                }
            }
            return salida.ToArray();
        }
    }
}
