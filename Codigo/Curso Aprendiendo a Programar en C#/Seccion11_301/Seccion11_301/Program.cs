using System.Text;

namespace Seccion11_301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un archivo 
            FileStream fs = File.Create("Arhivo Creado con File.txt");

            // Codificamos una cadena pasra escribirla en el archivo 
            byte [] buffer = Encoding.UTF8.GetBytes("Prueba de texto");

            // Escribimos en el archivo
            fs.Write(buffer, 0, buffer.Length);

            // Cerramos el flujo de create 
            fs.Close();

            // Ecribimos o anexamos textp a miestro archivo
            File.AppendAllText("Arhivo Creado con File.txt", "Texto anexado");

        }
    }
}
