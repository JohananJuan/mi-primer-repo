namespace Seccion10_257
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            bool repetir = true; // Se encarga de repetir el menu hasta que nosotros decidamos salir del programa
            string opcion;

            Biblioteca biblioteca1 = new Biblioteca();

            do
            {
                Console.WriteLine("\nBiblioteca\n" +
                                  "1. Agregar Libro \n" +
                                  "2. Msotrar todos los libros\n" +
                                  "3. Busqueda exacta de un libro\n" +
                                  "4. Busqueda imparcial de un libro\n" +
                                  "5. Eliminar un libro\n" +
                                  "6. Salir");
                Console.Write("\nIngresa una opcion: ");
                opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1":
                        biblioteca1.AgregarLibro();
                        break;

                    case "2": 
                        biblioteca1.MostrarLibro();
                        break;

                    case "3": 
                        biblioteca1.BuscarLibro();
                        break;

                    case "4":
                        biblioteca1.BusquedaParcial();
                        break;

                    case "5":
                        biblioteca1.EliminarLibro();
                        break;

                    case "6":
                        repetir = false;
                        break;

                    default: 
                        Console.WriteLine("\nOpcion invalida");
                        break;
                }


            } while (repetir);

        }
    }

    class Biblioteca
    {
        Libro[] libros; // Declaramos una matriz de tipo struct "Libro"
        int cantidadLibros = 0;
        string buscarLibro;
        bool libroEncontrado;
        int posicionLibroEliminar;

        // Constructor
        public Biblioteca()
        {
            libros = new Libro[1000];
        }

        public void AgregarLibro()
        {
            if (cantidadLibros < libros.Length)
            { 
                Console.Clear();
                Console.WriteLine($"Ingresar informacion para el libro {cantidadLibros + 1}\n");

                Console.Write("Ingresa el nombre del libro: ");
                libros[cantidadLibros].Titulo = Console.ReadLine();
                Console.Write("Ingresa el autor: ");
                libros[cantidadLibros].Autor = Console.ReadLine();
                Console.Write("Ingresa el ano: ");
                libros[cantidadLibros].Ano = Console.ReadLine();

                cantidadLibros ++;

                Console.Clear ();
                Console.WriteLine("Libro agregado correctamente");

            }
            else
            {
                Console.WriteLine("BHiblioteca llena");
            }
        }

        public void MostrarLibro()
        {
            Console.Clear();

            if (cantidadLibros == 0)
            {
                // Si no existe ningun libro, mostramos el siguiente mensaje
                Console.WriteLine("Biblioteca Vacia");
            }
            else
            {
                for (int i = 0; i < cantidadLibros; i++)
                {
                    Console.WriteLine($"{i + 1}.- Titulo = {libros[i].Titulo}, Autor = {libros[i].Autor}, Ano = {libros[i].Ano}");
                }
                Console.WriteLine("\nPreione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine();

            }
        }

        public void BuscarLibro()
        {
            Console.Clear();

            Console.WriteLine("Ingresa el nombre exacto del libro para buscarlo: ");
            buscarLibro = Console.ReadLine();
            libroEncontrado = false;

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.Equals(buscarLibro))
                {
                    Console.WriteLine($"El libro \"{libros[i].Titulo}\" del autor(a): \"{libros[i].Autor}\" se encintra disponible en la biblioteca en el indice: {i + 1}");
                    libroEncontrado |= true;
                }
            }
            if (!libroEncontrado)
            {
                Console.WriteLine("Libro no encontrado");
            }
            
            
        }   

        public void BusquedaParcial()
        {
            Console.Clear();
            Console.Write("Ingresa al menos una parte del titulo o del nombre del autor de un libro para buscarlo: ");
            buscarLibro = Console.ReadLine().ToLower();

            libroEncontrado = false;

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].Titulo.ToLower().Contains(buscarLibro) || libros[i].Autor.ToLower().Contains(buscarLibro));
                {
                    Console.WriteLine($"La palabra \"{buscarLibro}\" fue encontrado en el libro: \"{ libros[i].Titulo}\" del autor: {libros[i].Autor} en el indice: {i + 1}");
                    libroEncontrado = true;
                }
            }

        }

        public void EliminarLibro()
        {
            Console.Clear();
            if (cantidadLibros == 0)
            {
                Console.WriteLine("La biblioteca esta vacia");
            }
            else
            {
                Console.Write($"Ingrese el numero del libro que desea eliminar ( Del 1 al {cantidadLibros}: ");
                posicionLibroEliminar = Convert.ToInt32( Console.ReadLine() ) - 1;

                //. Verificamos que el numero ingresado sea valido
                if (posicionLibroEliminar >= 0 && posicionLibroEliminar < cantidadLibros)
                {
                    // Confirmamos si el libro que ingreso es el que quiere eliminar
                    Console.Write($"El libro que quieres eliminar es: \"{libros[posicionLibroEliminar].Titulo}\" (si/no):  ");

                    string opcion = Console.ReadLine().ToLower();

                    if ( opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cual fue el libro eliminado

                        string tituloEliminado = libros[posicionLibroEliminar].Titulo;
                        string autorEliminado = libros[posicionLibroEliminar].Autor;

                        for (int i = posicionLibroEliminar; i < cantidadLibros; i++)
                        {
                            libros[i] = libros[i + 1];
                        }
                        cantidadLibros --;

                        // Le mostramos al usuario el libro que se elimino
                        Console.WriteLine($" \nEl libro \"{tituloEliminado}\" del autor \" {autorEliminado}\" fue eliminado" );

                    }
                    else
                    {
                        Console.WriteLine("Operacion \"eliminar libreo \" cancelada ");
                    }



                }
                else
                {
                    Console.WriteLine("El numero del libro no es valido! ");
                }



            }

        }
    }

    struct Libro
    {
        // Campos
        string titulo;
        string autor;
        string ano;


        // Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Ano { get => ano; set => ano = value; }

    }

    }
