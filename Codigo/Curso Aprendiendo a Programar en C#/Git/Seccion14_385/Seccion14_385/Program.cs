namespace Seccion14_385
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclo for de 0 al 100 y de 10 en 10
            for (int i = 0; i <= 100;  i +=10)
            {
                Console.Clear();

                // Marca el inicio de la barra
                Console.Write("\n[");

                // Simulacion de llenado
                Console.ForegroundColor = ConsoleColor.Green;

                int barrasLlenas = i / 5;

                Console.Write(new string('▌',barrasLlenas));

                // Despes de dibujar los caracteres de la tarea vacia 
                Console.ForegroundColor = ConsoleColor.Yellow;
                int barrasVacias = 20 - barrasLlenas;
                Console.Write(new string('▌',barrasVacias));

                Console.ResetColor();

                // Marca el final de la tabla y nos muestra el porcentaje
                Console.Write($"] {i}%\n");

                Thread.Sleep(300);

            }
        }
    }
}
