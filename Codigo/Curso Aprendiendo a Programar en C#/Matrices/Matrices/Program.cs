namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, alumnos; // Variable de control
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;


            Console.Write("Cuantos alumnos tienes: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            double[] calificaciones = new double[alumnos];



            for (i = 0; i < alumnos; i++)
            {
                Console.Write($"Ingresa la calificacion del alumno {i}: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                // acumulamos las calificaciones
                sumaCalif += calificaciones[i];
            }


            // Calculamos las calificaciones minimas

            for (i = 0; i < alumnos; i++)
            {
                if (calificaciones[i] < califMin)
                {
                    califMin = calificaciones[i];
                }

            }

            // Calculamos las calificaciones maximas 
            for ( i = 0; i < alumnos; i ++)
            {
                if (calificaciones[i] > califMax)
                {
                    califMax = calificaciones[i];
                }
            }
           
            promedio = sumaCalif / alumnos;   

            Console.WriteLine($"\nEl promedio de calificaciones es: {promedio}");

            Console.WriteLine($"\nLa calificacion minima es: {califMin}");

            Console.WriteLine($"La calificacion maxima es: {califMax}\n");

            for (i = 0; i < alumnos; i++)
            {
                Console.WriteLine($"Las calificacion del alumno {i} fue: {calificaciones[i]}");
            }
        }
    }
}
