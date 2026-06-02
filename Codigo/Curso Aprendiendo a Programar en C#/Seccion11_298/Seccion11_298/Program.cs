using System.Runtime.InteropServices;
using System.Text;

namespace Seccion11_298
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crando un flujo de archivo
            FileStream fs = new FileStream("Contrasena.txt", FileMode.Open);

            // buffer para lamcaenbra los bytes conteniudos en el archivo
            byte[] bufferLeerDatosArchivo = new byte[1024];

            // Leemos los bytes que contienen el archivop 
            fs.Read(bufferLeerDatosArchivo, 0, bufferLeerDatosArchivo.Length);

            // Dewscodificamos la matriz de bytes leida para convertirla en un string 
            string cadenaDescodificada = Encoding.UTF8.GetString(bufferLeerDatosArchivo);

            // Mostramos la cadena descodifcada (la informacion del archivo 
            Console.WriteLine($"Informacion obtenida del archivo: \" {cadenaDescodificada} \"");

        }
    }
}
