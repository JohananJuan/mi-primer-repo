namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable del bucle 
            int i, numAlumnos;
            decimal calificacion, sumCalif = 0, promedio;

            Console.Write("Cuantos Alumnos son: ");
            numAlumnos = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Cual es la calificaion del alumno {0}: ", i);
                calificacion = Convert.ToDecimal(Console.ReadLine());
                    
                sumCalif += calificacion;
            }
            Console.Write("\n\nLa suma de calificaciones es de: {0}", sumCalif);

            promedio = sumCalif / numAlumnos;
            Console.Write("\nEl promedio de calificaciones de tus alumnos es de: {0} \n\n", promedio);


        }
    }
}
