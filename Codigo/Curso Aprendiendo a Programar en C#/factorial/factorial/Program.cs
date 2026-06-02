namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal i, numero, factorial = 1;

            Console.Write("De que numero quieres el fatorial: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            for (i = numero; i >= 1; i --)
            {
                factorial = factorial * i; 
            }
            Console.Write("\nEl factorial de {0} es {1}\n ", numero, factorial);
        }
    }
}
