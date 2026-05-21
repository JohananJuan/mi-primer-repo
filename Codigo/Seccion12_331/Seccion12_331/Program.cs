namespace Seccion12_331
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {   
                Console.Clear();
                // Menu 
                Console.WriteLine("1. Suma\n" +
                                  "2. Resta");

                Console.Write("Escoge una opcion: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Solo es posible un numero 1 o 2");
                    opcion = 5;
                }

                catch (OverflowException e)
                {
                    // Codigo para controlar la excepcion  de OverFlow
                    Console.WriteLine($"\aNumero my grande o pequeno, solo puedes escribir 1 o 2");
                    opcion = 5;

                }

                catch (Exception e)
                {
                    // Codigo para controlar la excepcion  de OverFlow
                    Console.WriteLine($"\aAlgo ha salido mal, solo es valido 1 o 2");
                    opcion = 5;

                }

                Console.ReadKey();

            }
            while (opcion != 1 && opcion != 2);


            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Sumar");
                    break;

                case 2:
                    Console.WriteLine("Resta");
                    break;

            }



        }
    }
}
