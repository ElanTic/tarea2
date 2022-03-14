using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act2
{
    internal class Menu
    {
        private Inventario _inventario;
        public Menu(Inventario inventario)
        {
            _inventario = inventario;
            inicio();
        }

        public void inicio()
        {
            Console.WriteLine($"[1]consultar, [2]agregar venta, [3] salir");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": consulta(); break;
                case "2": alta(new Venta( DateTime.Now)); break;
                //case "3":baja(); break;
                case "3": return;
                default: Console.WriteLine("No disponible"); inicio(); break;
            }
        }
        public void alta(Venta venta)
        {
            int input = 1;
            do {
                    Console.WriteLine("[0] cancelar, [1] agregar articulo, [2] finalizar ");
                input = leerEntero(); 
            } while (input < 0);

            if (input == 0) inicio();
            else if (input == 1) { 
                Producto temp = leerIndice();
                if (temp != null) { 
                    venta.agregarProduct(temp);
                }
                alta(venta);
            }
            else if (input == 2) { 
                _inventario.vender(venta); 
                inicio();}
        }
        //public void baja() { }
        public void consulta()
        {
            Console.WriteLine("consultar ventas  [1], consultar los mas vendios[2], imprimir lista de articulos[3]");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    List<Venta> sells = _inventario.getVentas();
                    foreach (Venta v in sells) Console.WriteLine(v);
                    break;

                case "2":
                    Producto[] bestSeller = _inventario.masVendidos();
                    foreach (Producto p in bestSeller)
                    {
                        Console.WriteLine($"{p} total vendidos:{p.vendios}");
                    }
                    break;
                case "3":
                    List<Producto> productos = _inventario.getProductos();
                    foreach (Producto p in productos) Console.WriteLine(p);
                    break;
                default: Console.WriteLine("No disponible"); break;
            }
            inicio();
        }
        public int leerEntero()
        {
            int input;
            try
            {
                input = int.Parse(Console.ReadLine());
                return input;
            }
            catch { return -1; }
        }

        private Producto leerIndice()
        {
        
            int tamano = _inventario.getProductos().Count;
            for(int indice=0;indice<tamano;indice++)
            {
                Console.WriteLine($"[{indice}]  {_inventario.getProductos()[indice]}");
            }
            Console.WriteLine("cancelar [*]");
            int p = leerEntero();
            if (p < 0 || p >= tamano)
            {
                return null;
            }
            return _inventario.getProductos()[p];
        }
    }
}
