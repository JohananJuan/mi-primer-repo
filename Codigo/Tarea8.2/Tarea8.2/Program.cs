using System.Security.Cryptography.X509Certificates;

namespace Tarea8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables requeridas
            double gasto;
            int opcion;


            // Declaramos Stack
            Stack<double> gastos = new Stack<double>();

            do
            {

                Console.Clear();

                Console.WriteLine("\tPrograma de App Bancaria\n");
                Console.WriteLine("\t\tMenu\n");
                Console.WriteLine("\n1. Ingresar gasto\n" +
                                    "2. Mostrar gatos\n" +
                                    "3. Sumar Gastos");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear() ;

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nIngresa el gasto que hiciste: ");
                        gasto = Convert.ToDouble(Console.ReadLine());


                        gastos.Push(gasto);

                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("\nEstos son tus gastos");

                        foreach (double elemento in gastos)
                        {
                            Console.WriteLine($"{elemento}");
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                        Console.ReadKey();

                        break;

                    case 3:
                        Console.WriteLine("\nEsta es la suma de tus gastos: ");

                        double total = 0;

                        foreach (double elemento in gastos)
                        {
                            total += elemento;                            
                        }

                        Console.WriteLine($"\nPago para no generar intereses:  {total} ");


                        Console.WriteLine("\nPresiona cualquier tecla para continuar");
                        Console.ReadKey();

                        break;
                }



            } while (opcion >= 1 && opcion <= 3);
        }
    }
}
