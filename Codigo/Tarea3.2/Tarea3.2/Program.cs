namespace Tarea3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero;

            Console.WriteLine("\t Numero par o impar");

            Console.Write("Por favor digite su numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if ( (numero %2) == 0 )
            {
                Console.Write("Tu numero es par");
            }
            else
            {
                Console.Write("Tu numero es impar");
            }
        }
    }
}
