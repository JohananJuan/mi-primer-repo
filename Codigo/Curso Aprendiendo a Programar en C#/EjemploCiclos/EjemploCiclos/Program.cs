namespace EjemploCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, resultado;
            Console.WriteLine("\t Tablas de multiplicar del 1 al 10\n");

            for (i = 1; i <= 10; i ++ )
            {
                Console.WriteLine("\nTabla de multiplicar de {0}\n", i);

                        for (j = 1; j <= 10; j ++)
                        {
                            resultado = i * j;
                            Console.WriteLine("{0} x {1} = {2}", i, j, resultado);
                        }
            }
        }
    }
}
