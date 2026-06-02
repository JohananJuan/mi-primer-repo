using System.Security.Cryptography.X509Certificates;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instanciamos la clase Random 
            Random random = new Random();

            Console.WriteLine(random.Next(20, 35));

        }
        
    }
}
