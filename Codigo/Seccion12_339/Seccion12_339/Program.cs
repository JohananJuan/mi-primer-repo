namespace Seccion12_339
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operador condicional ternario
            int edad = 20;
            string resultado;

            // Condicion ? valor_si_verdadero : valor_si_falso

            resultado = edad >= 18 ? "Mayor de edad" : "Menor de edad";

            Console.WriteLine(resultado);

        }
    }
}
