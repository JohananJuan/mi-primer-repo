namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLados;
            double lonLado, perimetro;

            Console.Write("Dame el numero de lados: ");
            numLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dame la longitud de uno de sus lados: ");
            lonLado = Convert.ToDouble(Console.ReadLine());


            perimetro = lonLado * numLados;

            Console.Write("El perimetro de tu figura es: {0}", perimetro);


        
        }
    }
}
