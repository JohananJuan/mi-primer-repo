namespace Seccion9_217
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Hola a todos";

            Console.WriteLine(cadena1);

            // Despues de Padleft
            Console.WriteLine(cadena1.PadLeft(20, '#' ));
        }
    }
}
