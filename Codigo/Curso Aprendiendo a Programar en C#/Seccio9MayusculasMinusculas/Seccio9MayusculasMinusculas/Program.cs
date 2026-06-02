namespace Seccio9MayusculasMinusculas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu correo electronico: ");
            string email = Console.ReadLine();

            Console.Clear();            
            Console.WriteLine("Verifica tu informacion: \n");

            Console.WriteLine($"Nombre: {nombre.ToUpper()} ");
            Console.WriteLine($"Correo: {email.ToLower()} ");

        }
    }
}
