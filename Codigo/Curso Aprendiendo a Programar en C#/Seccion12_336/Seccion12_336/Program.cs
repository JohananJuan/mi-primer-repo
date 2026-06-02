namespace Seccion12_336
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double sueldoBase, sueldoFinal;
            bool cumpleBono;

            sueldoBase = 3500;
            cumpleBono = true;

            // Asignamos valores para el emplqeado 
            sueldoFinal = BonoPuntualidad(sueldoBase, cumpleBono);

            Console.WriteLine(sueldoFinal);

        }

        static double BonoPuntualidad(double sueldoPa, bool cumpleBonoPa)
        {
            if (sueldoPa < 0)
            {
                throw new ArgumentException("El sueldo no puede ser negativo");
            }

            if (cumpleBonoPa)
            {
                sueldoPa = sueldoPa * 1.1;
            }
            return sueldoPa;
        }


    }
}




//  throw