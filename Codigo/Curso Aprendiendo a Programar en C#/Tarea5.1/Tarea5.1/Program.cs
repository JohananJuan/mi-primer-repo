namespace Tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradosAr;
            double resultado;

            Console.Write("Cantidad de grados que quieres convertir: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            resultado = Conversion(gradosAr);

            Console.WriteLine($"El resultado en radianes es: {resultado}");


        }

        static double Conversion(double gradosPa)
        {
            double radianes;
            radianes = gradosPa * (Math.PI / 180);

            return radianes;
        }

    }
}
