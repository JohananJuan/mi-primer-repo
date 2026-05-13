using System.ComponentModel.Design;

namespace Seccion9Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresa Correo: ");
            string correo = Console.ReadLine();


            Console.WriteLine("Ingresa tu correo nuevamente ");
            string correoConfirmar = Console.ReadLine();

            bool coincideCorreo;

            coincideCorreo = correo.Equals(correoConfirmar, StringComparison.OrdinalIgnoreCase);

            if (coincideCorreo)
            {
                Console.WriteLine("Acertaste");
            }
            else
            {
                Console.WriteLine("Lo siento");
            }
        }
    }
}
