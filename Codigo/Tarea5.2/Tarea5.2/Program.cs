using System.Runtime.ConstrainedExecution;

namespace Tarea5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double resultado = 0.0;
            int opcion;

            Console.Write("Que figura quieres cacular:\n" +
                              "1. Circulo \n" +
                              "2. Cuadrado \n" +
                              "3. Triangulo \n" +
                              "4. Rectangulo: ");

            opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = Circulo();
                    break;

                case 2:
                    resultado = Cuadrado();
                    break;

                case 3:
                    resultado = Triangulo();

                    break;

                case 4:
                    resultado = Rectangulo();
                    break;

                default:
                    Console.Write("No se encuentra eso aqui");
                    break;

            }

            Console.Write($"\nTu resultado es: {resultado}");
        }

        static double Circulo()
        {
            Console.Write("Cual es el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            return (Math.PI * (radio * radio));
        }


        static double Triangulo()
        {
            var (A, B) = PedirDatos();

            return (A * B) / 2;  

        }


        static double Cuadrado()
        {
            Console.Write("Cuanto mide un lado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            return lado * lado;
        }


        static double Rectangulo()
        {
            var (A, B) = PedirDatos();
            return A * B;
        }

        // Datos que regresa, nombre del metodo, datos que recibe
        static (double A, double B) PedirDatos ()
        {

            Console.Write("Cual es la base: ");
            double aAr = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cual es el la altura: ");
            double bAr = Convert.ToDouble(Console.ReadLine());


            return (aAr, bAr);

        }

    }
}
