namespace GetLenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Invocamos la matriz

            ImprimirMatriz(matriz);

            // Matiz ,ulti

            double[,] matriz2d = { { 1 ,2 },
                                   { 2 ,3 } };


            ImprimirMatrizMulti(matriz2d);

        }


        // Metodo que imprime la matriz

        static void ImprimirMatriz(int[] matrizPa)
        {
            int i; // Variable para el conhtr0ool del flujo

            for (i = 0; i < matrizPa.Length; i++)
            {
                Console.WriteLine(matrizPa[i]);
            }
        }

        // Metodo que imprime los valores de la matriz multi
        static void ImprimirMatrizMulti(double[,] matriz2DPa)
        {
            int i, j;

            for (i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine($"Fila {i}");

                for (j = 0; j < matriz2DPa.GetLength (1); j++)
                {
                    Console.WriteLine(matriz2DPa[i, j]);
                }
            }
        }

    }
}



