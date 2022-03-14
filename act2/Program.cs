// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using act2;
using System;
Inventario inv = new Inventario();
inv.agrega(new Producto("1", "jabon", 40, "higiene" ));
inv.agrega(new Producto("2", "shampoo", 70, "higiene"));
inv.agrega(new Producto("3", "toalla", 100, "higiene"));
inv.agrega(new Producto("4", "salero", 30, "cocina"));
inv.agrega(new Producto("5", "especiero", 100, "cocina"));
inv.agrega(new Producto("6", "camita", 300, "mascotas"));
inv.agrega(new Producto("7", "cojin", 80, "muebles"));
inv.agrega(new Producto("8", "lampara", 200, "electronicos"));
inv.agrega(new Producto("9", "cortina", 90, "decoracion"));
inv.agrega(new Producto("10", "marco", 40, "decoracion"));
inv.agrega(new Producto("11", "bombilla", 40, "electronicos"));
Random rand = new Random();
int r = rand.Next(10, 40);
for (int i = r; i > 0; i--) { //generando ventas aleatorias con productos aleatorios
    Venta venta = new Venta(DateTime.Now);
    int r2 = rand.Next(1, 7);
    for (int j = r2; j > 0; j--)
    {
        venta.agregarProduct(inv.getProductos()[rand.Next(0, 11)]);

    }
    inv.vender(venta);
}
Menu menu = new Menu(inv);