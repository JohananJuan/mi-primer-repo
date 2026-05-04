/*namespace DoWhile
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
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

            }
        }
    }
}// Fin de main 

        static void Sumar()
{
    //Variables del metodo Sumar
    decimal num1, num2, resultador;

    Console.Write("Ingresa el primer numero: ");
    num1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Ingresa el segundo numero: ");
    num2 = Convert.ToDecimal(Console.ReadLine());

    //opreacion
    resultador = num1 + num2;

    Console
}
*/