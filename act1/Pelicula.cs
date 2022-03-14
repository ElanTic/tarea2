using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace act1
{
    internal class Pelicula
    {
        private string nombre;
        private Genero genero;
        private int anio;
        private Pelicula next,prev;
        

        public Pelicula(string nomb, Genero gen, int anio)
        {
            this.nombre = nomb;
            this.genero = gen;
            this.anio = anio;
            next = null;
            prev = null;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public Genero Genero { get { return genero; } set { genero = value; } }
        public int Anio { get { return anio; } set { anio = value; } }
        public Pelicula Next { get { return next;} set { next = value; } }
        public Pelicula Previous { get { return prev;} set { prev = value; } }
        override
        public string ToString()
        {
            return $"{nombre} anio:{anio} generos:{genero} estante {(int) genero}";
        }
        
         public void agrega(Pelicula peli)
        {
            if (nombre.CompareTo(peli.Nombre) < 0) // alfabeticamente fue mayor
            {
                if (next == null) { next = peli; peli.prev = this; }
                else next.agrega(peli);
            }
            else 
            {//alfaxeticawente fue menor
                prev.Next = peli; //se liga el nuevo con el elemento anterior
                peli.Next = this; //se liga el nuevo con el elemento actual
                this.prev = peli;
            }
        }


    


    }
}
