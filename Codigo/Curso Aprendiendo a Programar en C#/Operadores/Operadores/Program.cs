namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float energia;
            bool propulsorIzquierdo, propulsorDerecho;

            Console.Write("Ingrese el nivel de energia: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.Write("El propulsor derecho esta en buen estado? (true/false): ");
            propulsorDerecho = Convert.ToBoolean(Console.ReadLine());

            Console.Write("El propulsor izquierdo esta en buen estado? (true/false): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());

            if (((( (propulsorDerecho)  && (propulsorIzquierdo)) == true) && (energia >= 75)) || (((propulsorDerecho) || (propulsorIzquierdo)) == true && (energia == 100)))
            {
                Console.Write("Puedes despegar");
            }
            else
            {
                Console.Write("Revisa la energia de tu nave");
            }


        }
    }
}
