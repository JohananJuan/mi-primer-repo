namespace Tarea4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int potencia, numero, i;
            decimal resultado = 1, resultadoNegativo;

            Console.Write("Dame el numero que quieres calcular la potencia: ");
            numero = Convert.ToByte(Console.ReadLine());

            Console.Write("Cual es la potencia que quieres saber: ");
            potencia = Convert.ToByte(Console.ReadLine());

            
            //Validamos exponenete

            if (potencia < 0)
            {
                // Convertimos a mayor
                potencia *= -1;
                
                for(i = 1; i <= potencia; i ++)
                {
                    resultado *= numero;
                }
                // asignamos a resultadoNegativo
                resultadoNegativo = (1 / resultado);

                // Mostramos resultado
                Console.WriteLine("{0}^{1} = {2}", numero, potencia, resultado);

            }
            else 
            {
                for (i = 1; i <= potencia; i++)
                {
                    resultado *= numero;
                }

                // Mostramos resultado
                Console.WriteLine("{0}^{1} = {2}", numero, potencia, resultado);
            }
        }
    }
}
