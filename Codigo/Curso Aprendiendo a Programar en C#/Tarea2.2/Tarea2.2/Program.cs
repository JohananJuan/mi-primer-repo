namespace Tarea2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double resultadoConv, gradosCent;

            Console.WriteLine("Programa para calcular Centigrados a Farenheit");
            Console.Write("Dame los grados que deseas convertir: ");
            gradosCent = Convert.ToDouble(Console.ReadLine());

            // Operaciones
            resultadoConv = (gradosCent * 1.8) + 32;

            // Resultados
            Console.Write("Los grados en Farenheit son: {0}", resultadoConv);

        }
    }
}
