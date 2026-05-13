namespace Seccion9_221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarando un objeto DateTime

            DateTime fechaHora = new DateTime(2002, 1, 05, 13, 54, 10);
            Console.WriteLine($"El valor del objeto DateTime es: {fechaHora}");

            // Convirtiedno el objeto DateTime es una cadena
            string cadenaFechHora = fechaHora.ToString("ddd dd MMMMM yyyy h:m:s tt");

            // Imprimiedo la representacion en cadena del objeto DateTime seguna la referencia cultural actual (es-Mx)
            Console.WriteLine($"La representacion en cadena es: {cadenaFechHora}");


        }
    }
}
