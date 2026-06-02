namespace Tarea9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabraUsuario, palabraInvertida = "";

            // Pedimos la palabra
            Console.Write("Ingresa una palabra y veamos si s un palindromo: ");
            palabraUsuario = Console.ReadLine();

            foreach (char letra in palabraUsuario)
            {
                palabraInvertida = letra + palabraInvertida;
            }

            if (palabraUsuario.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{palabraUsuario}\" es una palabra palindroma");
            }
            else
            {
                Console.WriteLine($"\"{palabraUsuario}\" no es una palabra palindroma");
            }

        }
    }
}
