using System.Xml;

namespace Seccion11_313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaInicial = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0\Mi primer Directorio\Nueva carpeta\Nueva carpeta\text.txt";

            // el metodo quita el ultimo elemento de la ruta y lo almacena en la variable string
            string rutaSinUltimoElemento = Path.GetDirectoryName(rutaInicial);

            // Mostramos la cadena devuelta por el metodo
            Console.WriteLine(rutaSinUltimoElemento);

            // Llamo al metodo mandandole la ultima cadena que me devolvio 
            Console.WriteLine(Path.GetDirectoryName(rutaSinUltimoElemento));
            
        }
    }
}
