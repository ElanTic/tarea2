using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2
{
    internal class Producto
    {
        private string _id;
        private string _name;
        private string _description;
        private double _price;
        private int _vendidos;
        private Producto next;
        //la IA los recemndo
       
        public Producto(string id, string name, double precio, string descripcion)
        {
            _id = id;
            _name = name;
            _description = descripcion;
            _price = precio;
        }
        public double price { set { _price = value; } get { return _price; } }
        public string name { set { _name = value; } get { return _name; } }
        public string description { set { _description = value; } get { return _description; } }
        public int vendios { set { _vendidos = value; } get { return _vendidos; } }
        public void ligar(Producto product)
        {
            if (next != null) next.ligar(product);
            else next = product;
        }
        public Producto getNext()
        {
            Producto tmp = next;
            this.next = null;
            return tmp;
        }
        override 
        public string ToString()
        {
            return $"{name} : {price}$ ";
        }
    }
}
