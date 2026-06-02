namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero;

            Console.Write("Escribe un numero del 1 - 12: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if (numero <= 12)
            {
                switch (numero)
                {
                    case 1:
                        Console.Write("Tu mes es Enero");
                        break ;

                    case 2:
                        Console.Write("Tu mes es Febrero");

                        break;

                    case 3:
                        Console.Write("Tu mes es Marzo");

                        break;

                    case 4:
                        Console.Write("Tu mes es Abril");

                        break;

                    case 5:
                        Console.Write("Tu mes es Mayo");

                        break;

                    case 6:
                        Console.Write("Tu mes es Junio");

                        break;

                    case 7:
                        Console.Write("Tu mes es Julio");

                        break;

                    case 8:
                        Console.Write("Tu mes es Agosto");

                        break;

                    case 9:
                        Console.Write("Tu mes es Septiembre");

                        break;

                    case 10:
                        Console.Write("Tu mes es Octubre");

                        break;

                    case 11:
                        Console.Write("Tu mes es Noviembre");

                        break;

                    case 12:
                        Console.Write("Tu mes es Diciembre");

                        break;

                    default:
                        Console.Write("Ese numero no es valido");
                        break;
                }
            }
            
            else
            {
                Console.Write("Numero fuera del rango");
            }

        }
    }
}
