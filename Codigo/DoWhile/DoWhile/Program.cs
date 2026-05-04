namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables 
            decimal num1, num2, resultado = 0.0M;
            byte opcion = 0;

            do
            {
                Console.Write("Que opcion deseas hacer: \n" +
                              "1. Suma\n" +
                              "2. Resta\n" +
                              "3. Multiplicacion\n" +
                              "4. Division\n");
                opcion = Convert.ToByte(Console.ReadLine());


            } while ((opcion < 1) || (opcion > 4));

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal (Console.ReadLine());

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
                    resultado = num1 / num2;
                    }
                    else
                    {
                        Console.Write("Tu numero no es valido");
                    }
                    break;

            }

            Console.Write("Tu resultado es: {0}", resultado);



        }
    }
}
