namespace MenuCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos variables
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            Console.Write("Que deseas realizar: \n" +
                           "1. Suma \n" +
                           "2. Resta \n" +
                           "3. Multiplicacion \n" +
                           "4. Division -- >  ");

            opcion = Convert.ToByte (Console.ReadLine());

            if (opcion <= 4)
            {
                Console.Write("Dame el primer numero: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Dame el segundo numero: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;

                    case 2:
                        resultado = num1 - num2;
                        break;

                    case 3:
                        resultado = num1 * num2;
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("Eso no existe bro");
                        break;
                }
                     Console.Write("Tu resultado es: {0}", resultado);
            }else
            {
                Console.Write("Por favor, escribe un numero valido");
            }

                    Console.WriteLine("\n Gracias");
         }
    }
}
