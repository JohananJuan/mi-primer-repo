namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, j, numSalones, alumnos; // Variable de control
            double sumaCalif = 0, totalAlumnos = 0, promedio, califMin = 10, califMax = 0, sumaCalifSalon;


            Console.Write("Cuantos salon tienes: ");
            numSalones = Convert.ToByte(Console.ReadLine());

            // Creacion de la matriz multidimensional
            double[][] calificaciones = new double[numSalones][];

            // Espacio en blanco
            Console.WriteLine();

            // Creacion de la matriz unidimensional de cada salones 
            double[] calificacionMinSalon = new double[numSalones];
            double[] calificacionMaxSalon = new double[numSalones];
            double[] promedioSalon = new double[numSalones];



            // Pedimos el numero de alumnos por salon
            for (i = 0; i < numSalones; i++)
            {


                Console.Write($"Cuantos alumnos tienes en el salon {i}: ");
                alumnos = Convert.ToByte(Console.ReadLine());
                
                //acumulamos el numero de alumnos totales, para el promedio de toda la escuela
                totalAlumnos += alumnos;

                // Instanciamos las matrices internas (Alumnos en cada salon)
                calificaciones[i] = new double[alumnos];

            } 

            
            // Pedimos las calificaciones de los alumnos en cada salon 
            for (i = 0; i < numSalones; i++)
            {
                // Los valores de calificaciones tienen que reiniciarse para cada salon.

                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 10;


                Console.WriteLine($"Salon {i}");

                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write($"Ingresa la calificacion del alumno {j} en el salon {i}: ");
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    // acumulamos las calificaciones de toda la escuela
                    sumaCalif += calificaciones[i][j];

                    // Acumulamos las calificaciones por salon 
                    sumaCalifSalon += calificaciones[i][j];

                    // Encontramos la calificaion minima en cada salon

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    // Asignamos la calificacion mas baja encontrada, en la casilla correspondiente al salon
                    calificacionMinSalon[i] = califMin;


                    // Encontramos la calificacion maxima en cada salon

                    if (calificaciones[1][j] > califMax )
                    {
                        califMax = calificaciones[1][j];
                    }

                    // Asignamos la calificacion mas alta encontradaa en la casilla  correspondiente al salon

                    calificacionMaxSalon[i] = califMax;
                }

                // Calculamos el prmedio de cada salon
                promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            // Calculamos las calificaciones minimas y maximas para toda la escuela en un mismo for

            for (i = 0; i < numSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i] [j] < califMin)
                    {
                        califMin = calificaciones[i] [j];
                    }

                    if (calificaciones[i] [j] > califMax)
                    {
                        califMax = calificaciones[i] [j];
                    }

                }
            }

            // Calulamos el promedio
            promedio = sumaCalif / totalAlumnos;

            Console.WriteLine($"\nEl promedio de calificaciones es: {promedio}");

            Console.WriteLine($"\nLa calificacion minima es: {califMin}");

            Console.WriteLine($"La calificacion maxima es: {califMax}\n");

            for (i = 0; i < numSalones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine($"La calificacion del alumno {j} en el salon {i} fue: {calificaciones[i] [j]}");
                }
            }

            // Mostramos los resultados de cada salon
            for (i = 0; i < numSalones; i++)
            {
                Console.WriteLine($"Informacion del salon {i}");
                Console.WriteLine($"Calificacion maxima: {calificacionMaxSalon[i]}, calificacion minima: {calificacionMinSalon[i]}");
                Console.WriteLine($"Promedio: {promedioSalon}");
            }

        }
    }
}
