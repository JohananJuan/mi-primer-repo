namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, j, salones, alumnos; // Variable de control
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;


            Console.Write("Cuantos salon tienes: ");
            salones = Convert.ToByte(Console.ReadLine());

            Console.Write("Cuantos alumnos por salon tienes: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            double[,] calificaciones = new double[salones, alumnos];


            for (i = 0; i < salones; i ++)
            {
                for (j = 0; j < alumnos; j ++)
                {
                    Console.Write($"Ingresa la calificacion del alumno {j} en el salon {i}: ");
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());

                    // acumulamos las calificaciones
                    sumaCalif += calificaciones[i , j];
                }
            }

            // Calculamos las calificaciones minimas

            for (i = 0; i < salones; i ++)
            {
                for (j = 0; j < alumnos; j ++)
                {
                    if (calificaciones[i, j] < califMin)
                    {
                        califMin = calificaciones[i, j];
                    }
                    else if (calificaciones [i, j] > califMax) 
                    {
                        califMax = calificaciones[i, j];
                    }

                }
            }

            // Calulamos el promedio
            promedio = sumaCalif / ( salones * alumnos);

            Console.WriteLine($"\nEl promedio de calificaciones es: {promedio}");

            Console.WriteLine($"\nLa calificacion minima es: {califMin}");

            Console.WriteLine($"La calificacion maxima es: {califMax}\n");

            for (i = 0; i < salones; i ++)
            {
                for (j = 0; j < alumnos; j ++)
                {
                    Console.WriteLine($"La calificacion del alumno {j} en el salon {i} fue: {calificaciones[i, j]}");
                }
            }
        }
    }
}
