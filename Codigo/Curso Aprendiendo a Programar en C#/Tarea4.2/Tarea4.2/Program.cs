namespace Tarea4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor, numDivisores = 0;

            for (numero = 2; numero <= 100; numero ++)
            {
                for (divisor = 1; divisor <= numero; divisor ++)
                {
                    if (numero % divisor == 0 )
                    {
                        numDivisores += 1;
                    }
                }

                if (numDivisores <= 2)
                {
                    Console.WriteLine(numero);
                }

                numDivisores = 0;
            }

            Console.ReadKey();
        }
    }
}
