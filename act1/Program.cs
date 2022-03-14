// See https://aka.ms/new-console-template for more information
using act1;
//Console.WriteLine("Hello, World!");
Estanteria estanteria = new Estanteria();
estanteria.agregar(new Pelicula("Frankenstein", Genero.horror, 1931));
estanteria.agregar(new Pelicula("Dracula", Genero.horror, 1931));
estanteria.agregar(new Pelicula("Nosferatu", Genero.horror, 1979));
estanteria.agregar(new Pelicula("Childs play (Chucky)", Genero.horror, 1988));
estanteria.agregar(new Pelicula("Scream", Genero.horror, 1996));

estanteria.agregar(new Pelicula("Supaida Man", Genero.comics, 2002));
estanteria.agregar(new Pelicula("the Darck knight", Genero.comics, 2007));
estanteria.agregar(new Pelicula("Aquaman", Genero.comics, 2018));
estanteria.agregar(new Pelicula("SpiderVerse", Genero.comics, 2018));

estanteria.agregar(new Pelicula("Harry potter", Genero.sci_fi, 2002));
estanteria.agregar(new Pelicula("El senior de los anillos ", Genero.sci_fi, 2001));
estanteria.agregar(new Pelicula("Piratas del caribe", Genero.sci_fi, 2003));
estanteria.agregar(new Pelicula("Star wars EI", Genero.sci_fi, 1999));

estanteria.agregar(new Pelicula("Arma mortal 2", Genero.accion, 1989));
estanteria.agregar(new Pelicula("kill bill ", Genero.accion, 2003));
estanteria.agregar(new Pelicula("Blade runer", Genero.accion, 2017));
estanteria.agregar(new Pelicula("Mision imposible 2", Genero.accion, 200));

estanteria.agregar(new Pelicula("Nightmare before christmas", Genero.animacion, 1993));
estanteria.agregar(new Pelicula("Los increibles", Genero.animacion, 2004));

estanteria.agregar(new Pelicula("Shrek", Genero.sci_fi, 2001));
estanteria.agregar(new Pelicula("Matrix", Genero.sci_fi, 1999));

estanteria.agregar(new Pelicula("Titanic", Genero.drama, 1998));

estanteria.agregar(new Pelicula("son como chavos", Genero.comedia, 1999));

estanteria.agregar(new Pelicula("10 milmillones ", Genero.documental, 2015));

estanteria.agregar(new Pelicula("ted", Genero.comedia, 2012));

estanteria.agregar(new Pelicula("lo que el viento se llevo", Genero.drama, 1939));

estanteria.agregar(new Pelicula("El renacido", Genero.drama, 2015));

menu menu = new menu(estanteria);



