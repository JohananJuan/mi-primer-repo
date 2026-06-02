namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa de computadora que haga el calculo'del area y perimetro de un rectangulo

            double altura, ancho, area, perimetro;

            // Pedimos la altura y convertimos a tipo douuble
            Console.Write("Dame la base: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Pedimos la base y convertimos a tipo douuble
            Console.Write("Dame la base: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            // Calculamos el area
            area = altura * ancho;
            
            //Calculamos perimetro
            perimetro = 2 * area;

            // Mostramos los resultados en la pantalla
            Console.Write("El area es: {0}, y el perimetro es {1} ", area, perimetro);
        }
    }
}
