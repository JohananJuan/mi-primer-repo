namespace Seccion10_253
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un estudiante
            Estudiante estudiante1 = new Estudiante();

            estudiante1.Nombre = "Luis";
            estudiante1.Apellido = "Dominguez";

            // Creamos la mnatriz
            Calificacion[] calificaciones = new Calificacion[]
                {
                    new Calificacion { Materia = "matematicas", Puntaje = 9},
                    new Calificacion { Materia = "Historia", Puntaje = 8.5},
                    new Calificacion { Materia = "Fisica", Puntaje = 7 } 

                };

            // Asignamos la matriz "Calificaiones"a nuestros estudaintes
            estudiante1.Calificaciones = calificaciones;

            // Mostrar los datos del estudiante y susu calificaiones
            Console.WriteLine($"Nombre: {estudiante1.Nombre} {estudiante1.Apellido}\n ");

            foreach (Calificacion elemento in estudiante1.Calificaciones)
            {
                Console.WriteLine($"{elemento.Materia} = {elemento.Puntaje}");
            }


        }
    }

    struct Calificacion
    {
        string materia;
        double puntaje;

        public string Materia { get => materia; set => materia = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
    }

    struct Estudiante
    {
        // Campos
        string nombre;
        string apellido;
        Calificacion[] calificaciones;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        internal Calificacion[] Calificaciones { get => calificaciones; set => calificaciones = value; }
    }


}
