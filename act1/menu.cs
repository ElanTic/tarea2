using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1
{
    internal class menu
    {
        Estanteria estanteria;
       public menu(Estanteria e) {
            estanteria = e;
            inicio();
        }

        public void inicio() {
            Console.WriteLine($"[1]consultar, [2]agregar pelicua, [3] salir");
            string input = Console.ReadLine();
            switch (input) {
                case "1":consulta(); break;
                case "2":alta();break;
                //case "3":baja(); break;
                case "3": return;
                default: Console.WriteLine("No disponible"); inicio();break;
            }
        }
        public void alta() {
            int genre = -1;
            do { genre = leerGenero(); } while (genre == -1);
            if (genre == -2) {inicio();return;}
            Console.WriteLine("nombre de la pelicula:");
            string name = Console.ReadLine();
            Console.WriteLine("anio de salida:");
            int anio = 0;
            do { anio = leerEntero(); } while (anio < 0);
            estanteria.agregar( new Pelicula(name, (Genero)genre, anio) );
            Console.WriteLine("nice");
            inicio();
        }
        //public void baja() { }
        public void consulta (){
            Console.WriteLine("consultar por nombre [1], consultar por genero[2], imprimir lista completa[3]");
            string input = Console.ReadLine();
            Pelicula peli = null;
            switch (input)
            {
                case "1":
                    Console.WriteLine("Nombre:");
                    peli = estanteria.buscar_x_nombre(Console.ReadLine());
                    if (peli == null) Console.WriteLine("no la tienes");
                    else Console.WriteLine(peli);
                    break;

                case "2":
                    int genero = leerGenero();
                    if (genero < 0) break;
                    peli = estanteria.search((Genero)genero);
                    while (peli != null) { 
                        Console.WriteLine(peli); peli = peli.Next;}
                    break;
                case "3": estanteria.print();break;
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

        private int leerGenero()
        {
            int tamano = Enum.GetValues(typeof(Genero)).Length;
            foreach (int genero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"[{genero}]  {Enum.GetName(typeof(Genero), genero)}");
            }
            int genre = leerEntero();
            if (genre < 0 || genre >= tamano)
            {
                if (genre == tamano) return -2;
                Console.WriteLine("asi no era");
                return -1;
            }
            return genre;
        }
    }
}
