namespace Seccion11_314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // cadena de la ruta 
            string ruta = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0\Mi primer Directorio\Nueva carpeta\Nueva carpeta\text.txt";

            // Llamamos al metodo y le asignamos la devolucion a una matriz de string
            string[] archivosDirectorios = Directory.GetFileSystemEntries(ruta, "Documento?.txt");

            // Recorremos la matriz y mostramos sus elementos
            foreach (string elememto in archivosDirectorios)
            {
                Console.WriteLine(elememto);
            }
        }
    }
}
