namespace Seccion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se necesita un Programa para hacer 4 de las operaciones basicas, con un menu de operaciones
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            Console.WriteLine("Menu de operaciones: \n" +
                               "1. Suma \n" +
                               "2. Rsta \n" +
                               "3. Multipliaccion \n" +
                               "4. Division");

            // Escogemos operacion
            Console.Write("Que operacion deseas hacer: ");
            opcion = Convert.ToByte(Console.ReadLine());

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Ciclos de operacion
            //Suma
            if (opcion == 1)
            {
                resultado = num1 + num2;
            }
            else if (opcion == 2) // Resta
             {
                    resultado = num1 - num2;
             }
            else if (opcion == 3)  //Multiplicacion
            {
                    resultado = num1 * num2;
            }
            else if (opcion == 4) // Division
            {
               if (num2 != 0)
               {
                resultado = num1 / num2;
               }
               else
               {
                    Console.Write("No se puede dividir entre 0");
               }
            }
            Console.Write("Tu resultado es: {0}", resultado);
        }
    }
}

