namespace Seccion11_315
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cadena con la ruta 
            string ruta = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_315\Seccion11_315\bin\Debug\net10.0\hola.txt.txt";

            // Llamamos al metodo y le asignamos la extension al mstring
            string extension = Path.GetExtension(ruta);

            //Mostramos la extension 
            Console.WriteLine($"La extension del archivo es: {extension}");
        }
    }
}
