namespace Tarea9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacnimiento;

            // Pedimos la fecha de nacimiento
            Console.Write("Dime la fecha de tu nacimiento (dias, mes, ano) y te dire que dia de la semana era: ");
            cadenaFechaNacimiento = Console.ReadLine();

            //Convertimos la cadena en un objeto DatyeTime
            dateTimeFechaNacnimiento = DateTime.Parse(cadenaFechaNacimiento);

            Console.WriteLine($"Naciste un {dateTimeFechaNacnimiento.ToString("dddd")}");
        }
    }
}
