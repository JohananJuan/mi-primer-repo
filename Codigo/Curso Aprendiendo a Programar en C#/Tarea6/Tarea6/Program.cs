namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, j, salones, alumnos; // Variable de control
            double sumaCalif = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;


            Console.Write("Cuantos salon tienes: ");
            salones = Convert.ToByte(Console.ReadLine());

            // Creacion de la matriz multidimensional
            double[][] calificaciones = new double[salones][];

            // Pedimos el numero de alumnos por salon
            for (i = 0; i < salones; i++)
            {
                Console.Write($"Cuantos alumnos tienes en el salon {i}: ");
                alumnos = Convert.ToByte(Console.ReadLine());

                //acumulamos el numero de alumnos totales, para el promedio de toda la escuela
                sumaAlumnos += alumnos;

                // Instanciamos las matrices internas (Alumnos en cada salon)
                calificaciones[i] = new double[alumnos];

            }


            // Pedimos las calificaciones de los alumnos en cada salon 
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine($"Salon {i}");

                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write($"Ingresa la calificacion del alumno {j} en el salon {i}: ");
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    // acumulamos las calificaciones
                    sumaCalif += calificaciones[i][j];
                }
            }

            // Calculamos las calificaciones minimas y maximas

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                    else if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }

                }
            }

            // Calulamos el promedio
            promedio = sumaCalif / sumaAlumnos;

            Console.WriteLine($"\nEl promedio de calificaciones es: {promedio}");

            Console.WriteLine($"\nLa calificacion minima es: {califMin}");

            Console.WriteLine($"La calificacion maxima es: {califMax}\n");

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine($"La calificacion del alumno {j} en el salon {i} fue: {calificaciones[i][j]}");
                }
            }
        }
    }
}
