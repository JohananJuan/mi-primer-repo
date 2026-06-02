using System;

namespace PrecioEstacionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal horas = 0;
            string tiempo;

            Console.WriteLine("\tPrecio a pagar por estacionamiento");

            Console.Write("Ingresar en horas o minutos?: ");
            tiempo = Console.ReadLine();

            switch (tiempo)
            {
                case "horas":
                    Console.Write("Cuántas horas estuvo?: ");
                    horas = Convert.ToDecimal(Console.ReadLine());
                    break;

                case "minutos":
                    Console.Write("¿Cuántos minutos estuvo?: ");
                    decimal minutos = Convert.ToDecimal(Console.ReadLine());
                    horas = minutos / 60; 
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    return;
            }

            // Cálculo de precio
            if (horas <= 1)
            {
                Console.WriteLine("Tu cuota es de $5.00");
            }
            else if (horas <= 2)
            {
                Console.WriteLine("Tu cuota es de $15.00");
            }
            else
            {
                Console.WriteLine("Tu cuota es de $40.00");
            }
        }
    }
}