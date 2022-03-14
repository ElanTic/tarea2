using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2
{
    internal class Venta
    {
        private List<Producto> productos;
        double subtotal;
        private DateTime fecha;

        public Venta(DateTime fecha)
        {
            this.productos = new List<Producto>();
            this.subtotal = 0;
            this.fecha = fecha;
        }


        public void agregarProduct(Producto producto)
        {
           productos.Add(producto);
            subtotal += producto.price;
        }
        public double Subtotal { get { return subtotal; }}
        public DateTime Fecha { get { return fecha; }}
        public List<Producto> Productos { get { return productos; } }

        public double calculaSubtotal()
        {
            subtotal = 0;
            foreach (Producto producto in productos)
            {
                subtotal+= producto.price;
            }
            return subtotal;
        }
        override
        public string ToString()
        {
            string str = "";
            foreach (Producto producto in productos)
            {
                str += $"{producto}\n";
            }
            return $"{fecha} {str} \nsubtotal:{subtotal}"; 
        }

    }
}
