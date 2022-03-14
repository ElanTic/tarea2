using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1
{
    internal class Estanteria
    {
        private Pelicula[] estante;
        public Estanteria()
        {
            this.estante = new Pelicula[Enum.GetNames(typeof(Genero)).Length];
        }
        public void agregar(Pelicula peli)
        {
            Pelicula head = estante[(int)peli.Genero]; 
            if (head != null)
            {
                if (head.Nombre.CompareTo(peli.Nombre) < 0){ // si el nuevo es alfabeticamente menor sera la nueva cabeza  
                    head.agrega(peli);
                }
                else
                {
                    peli.agrega(head);
                    head = peli;
                }
            }
            else head = peli;
            estante[(int)peli.Genero] = head;
        }
        public void print() {
            foreach (Pelicula pelicula in estante)
            {
                Pelicula peli = pelicula;
                while(peli != null)
                {
                    Console.WriteLine(peli);
                    peli = peli.Next;
                }
            }
        }
        public Pelicula buscar_x_nombre(String nom)
        {
            foreach (Pelicula pelicula in estante)
            {
                Pelicula peli = pelicula;
                while (true)
                {
                    if (peli == null) break;
                    if (peli.Nombre.Equals(nom)) return peli;
                    peli = peli.Next;
                 
                }
            }
            return null;

        }
        public Pelicula buscar_x_genero(Genero gen)
        {
            if(gen == null) return null;
            return estante[(int) gen];
        }
   
    }
}
