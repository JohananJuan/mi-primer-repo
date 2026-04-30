namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            byte edad;
            bool licencia;

            Console.Write("Que edad tienes: ");
            edad = Convert.ToByte(Console.ReadLine());



            // Ciclos

            if (edad >= 18)
            {
                Console.Write("Tienes licencia?: (true/false) ");
                licencia = Convert.ToBoolean(Console.ReadLine());

                if (edad >= 18 && licencia == true)
                {
                    Console.Write("You can drive a car");
                }
                else
                {
                    Console.Write("Please, come back your home");
                }
            }
            else
            { 
                Console.Write("Please, come back your home");
            }

        }
    }

}