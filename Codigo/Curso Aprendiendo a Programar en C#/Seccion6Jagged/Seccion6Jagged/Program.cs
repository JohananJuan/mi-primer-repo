namespace Seccion6Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo [][] nombre = new tipo [filas] [];
            double[] [] ventas = new double[4][]
            {
                new double [] { 155, 100, 170},
                new double [] { 205, 120 },
                new double [] { 115, 190, 104, 130},
                new double [] { 163, 218, 125},
            };

            int i, j;

            for (i = 0; i < ventas.Length; i ++)
            {
                Console.WriteLine($"Elemento: {i}");

                for (j = 0; j < ventas[i].Length; j ++) 
                {
                    Console.WriteLine(ventas[i][j]);
                }
            }
        }
    }
}
