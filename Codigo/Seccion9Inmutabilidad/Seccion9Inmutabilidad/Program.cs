namespace Seccion9Inmutabilidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inmutable
            string texto_Original = "             ------Cuando Gregorio Samsa se despertó una mañana después de un sueño intranquilo, se encontró sobre su cama convertido en un monstruoso insecto--------               ";

            // quitamos los guiones
            string textoReemplazo = texto_Original.Remove(33);

            Console.WriteLine(texto_Original);
            Console.WriteLine();
            Console.WriteLine(textoReemplazo);


        }
    }
}
