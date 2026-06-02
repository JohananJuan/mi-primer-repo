using System.Globalization;

namespace Seccion9Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cadena1 = "z";
            string cadena2 = "ö";

            int ordenar;

            ordenar = String.Compare(cadena1, cadena2, new CultureInfo("sv-SE"), CompareOptions.None);

            switch(ordenar)
            {
                case -1:
                    Console.WriteLine($" ({cadena1}) es menor que ({cadena2}) segun el criterio de ordenacion");
                    break;

                case 0:
                    Console.WriteLine($" ({cadena1}) y ({cadena2}) son iguales segun el criterio de ordenacion");
                    break;


                case 1:
                    Console.WriteLine($" ({cadena1}) es mayor que ({cadena2}) segun el criterio de ordenacion");
                    break;

            }

        }
    }
}
