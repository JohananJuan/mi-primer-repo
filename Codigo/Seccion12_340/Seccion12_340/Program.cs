namespace Seccion12_340
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros = "123";
            string letras = "abc";
            string nulo = null;
            string vacio = "";

            bool conversionExitosa = int.TryParse(numeros, out int variableConvertida);

            Console.WriteLine($"Conversion exitosa: {conversionExitosa}");
            Console.WriteLine($"Valor Convertido: {variableConvertida}");

            Console.Write("Ingresa tu edad: ");
            string entrada = Console.ReadLine();

            // Intentamos convertir a int usando TryParse
            if (int.TryParse(entrada, out int edad))
            {
                Console.WriteLine("Tu edad es:{entrada}");
            }
            else
            {
                Console.WriteLine("Edad invalida");

            }

        }
    }
}
