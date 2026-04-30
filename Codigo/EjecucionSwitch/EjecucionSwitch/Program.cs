namespace EjecucionSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Colores
            string color;

            Console.Write("que color quieres que te de el RGB?: ");
            color = Console.ReadLine();

            switch (color)
            {
                case "Red":
                        Console.WriteLine("El RGB es 255,0,0");
                    break;

                case "Green":
                    Console.WriteLine("El RGB es 0,255,0");
                    break;

                case "Blue":
                    Console.Write("El RGB es 0,0, 255");
                    break;

            }
            Console.WriteLine("Gracias");
        }
    }
}
