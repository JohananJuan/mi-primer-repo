namespace EjecucionSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Colores
            string color;
            
            Console.WriteLine("\t Ejercicio con case");

            Console.Write("Que color quieres que te de el RGB?: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "RED":
                case "Red":
                case "red": 
                        Console.WriteLine("El RGB es 255,0,0");
                    break;

                case "Green":
                    Console.WriteLine("El RGB es 0,255,0");
                    break;

                case "Blue":
                    Console.Write("El RGB es 0,0, 255");
                    break;

                default:
                    Console.WriteLine("No se encontro bro, prueba con otro");
                    break;

            }
            Console.WriteLine("Gracias");
        }
    }
}
