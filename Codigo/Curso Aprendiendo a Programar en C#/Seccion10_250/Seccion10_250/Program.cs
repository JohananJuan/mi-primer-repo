namespace Seccion10_250
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaReproduccion listaReproduccion1 = new ListaReproduccion
            {
                Nombre = "Clasicos",
                cancion1 =
                {
                    Titulo = "Bohemian Rhapsody",
                    Artista = "Queen",
                    Duracion = 500
                },
                cancion2 =
                {
                    Titulo = "Vivas las vegas",
                    Artista = "Elvis Presley",
                    Duracion = 200
                }
            };

            

            //// Nombramos a la lista
            //listaReproduccion1.Nombre = "Clasicos";

            ////agregamos informacion a las canciones contenidas en la lista dereproduccion
            //listaReproduccion1.cancion1.Titulo = "Bohemian Rhapsody";
            //listaReproduccion1.cancion1.Artista = "Queen";
            //listaReproduccion1.cancion1.Duracion = 500;

            //listaReproduccion1.cancion2.Titulo = "Vivas las vegas";
            //listaReproduccion1.cancion2.Artista = "Elvis Presley";
            //listaReproduccion1.cancion2.Duracion = 200;

            // Msotramos la informacion de la lista
            Console.WriteLine(listaReproduccion1.ToString());

        }
    }

    struct Cancion
    {
        // Campos
        string titulo;
        string artista;
        int duracion;

        // Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Artista { get => artista; set => artista = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public override string ToString()
        {
            string mensaje = $"Titulo: {Titulo}\nArtista: {Artista}\nDuracion: {Duracion} segundos";
            return mensaje;
        }


    }

    struct ListaReproduccion
    {
        string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        // Anidamos a la struct "Cancion"
        public Cancion cancion1;
        public Cancion cancion2;

        public override string ToString()
        {
            string mensaje = $"Lista de reproduccion: {Nombre}\n\nCancion1:\n{cancion1.ToString()}\n\nCancion 2: {cancion2.ToString()}\n ";
            return mensaje; 
        }


    }


}
