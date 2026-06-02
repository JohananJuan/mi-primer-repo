namespace EjemploConList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Necesarias
            int opcion, indice;
            string alumno;

            // instacnia de list
            List<string> Alumnos = new List<string>();

            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar estudiante\n" +
                                  "2. Eliminar estudiante\n" +
                                  "3. Mostrar estudiante\n" +
                                  "4. Buscar por nombre");

                // Escoger una opcion
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();

                        Alumnos.Add(alumno);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el numero del estudiante que quiera eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());

                        indice--;


                        if (indice >= Alumnos.Count() || indice < 0)
                        {
                            Console.WriteLine("El alumno no existe");
                        }
                        else
                        {
                            string alumnoElim = Alumnos[indice];
                            Alumnos.RemoveAt(indice);
                            Console.WriteLine($"{alumnoElim} se ha eliminado correctamente");
                        }

                        break;


                        Console.Write("\n Presione cualquier tecla para regresar al menu");
                        Console.ReadKey();

                    case 3:
                        int i = 1; // Nos sirve para mostrar el inidce de los alumnos
                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine($"{i++}. {estudiante} ");
                        }
                        Console.Write("\n Presione cualquier tecla para regresar al menu");
                        Console.ReadKey();
                        break;

                    case 4:
                        string encontrarAlumn;
                        int j;

                        Console.Write("Encribe el nombre del estudiante a buscar: ");
                        alumno = Console.ReadLine();


                        // Verificar si el alumno(elemnto) esta o no en la lista
                        if(Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlumn = Alumnos[Alumnos.IndexOf(alumno)];
                            j = Alumnos.IndexOf(alumno) + 1;

                            Console.WriteLine($"El estudiante {encontrarAlumn} se encuentra en el numero {j}");
                        }
                        else
                        {
                            Console.WriteLine($"El estudiante {alumno} no se encuentra en el sistema");

                        }
                        Console.Write("Presione cualquier tecla para regresar al menu");
                        Console.ReadKey();
                        break;

                }

            } while (opcion >= 1 && opcion <= 4);

        }
    }
}
