namespace MatricesMultidimensiolaes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tipo [,] nombre = new tipo [filas, columnas]

            int i; // Control de ciclo exterior
            int j; // Control del ciclo interior

            double[,] ventas = { { 100, 120, 205 }, 
                                 { 115, 196, 300 }, 
                                 { 157, 172, 245 }, 
                                 { 130, 180, 281 } };

            for ( i = 0; i < 4; i ++)
            {
                for ( j = 0; j < 3; j ++)
                {
                    Console.WriteLine(ventas[i, j]);
                }
            }
        }
    }
}
