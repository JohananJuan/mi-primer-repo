using System.Reflection.Metadata;

namespace EjemploMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double resultado;
            string opcionAr;


            Console.Write("Que deseas convertir? Radianes, Celcios, Millas: ");
            opcionAr = Console.ReadLine();

            valor = PedirNumero("\nDame el valor: ");

            resultado = Conversion(valor, opcionAr);

            Console.Write($"Resultado: {resultado}");

        }

        static double Conversion (double valor, string opcionPa)
        {
            switch(opcionPa)
            {
                case "Radianes":
                    return valor * (Math.PI / 100);
                    
                
                case "Celcios":
                    return (valor * 9 / 5) + 32;

                case "Millas":
                    return valor * 0.621371;

                default:
                    Console.Write("Opcion no valida");
                    return 0;
            }
        }

        static double PedirNumero( string peticion)
        {

            Console.Write(peticion);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
