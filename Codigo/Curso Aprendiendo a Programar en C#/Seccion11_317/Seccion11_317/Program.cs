namespace Seccion11_317
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origenDirectorio = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_317";

            string destinoDirectorio = @"C:\Users\User\Documents\Arduino\Estructura_y_funcionamiento\Seccion11";

            // Llamamams al metodo copiar directoio para mandar agumentos 
            CopiarDirectorio(origenDirectorio, destinoDirectorio);

        }

        static public void CopiarDirectorio (string origenDirectorioPa, string destinoDirectorioPa)
        {
            // Verificar si el directorio de destino no esxiste, crearlo si es necesario
            if (!Directory.Exists(destinoDirectorioPa))
            {
                Directory.CreateDirectory(destinoDirectorioPa);
            }

            // Matriz para guardar las rutas completas de los archivos del directorio de origen
            string[] archivos = Directory.GetFiles(origenDirectorioPa);


            // Copiar archivos desde el directorio de origen al directorio de destino 
            foreach (string archivoRutaOrigen in archivos)
            {
                // Asignamos el nombre del archivo (matriz) y su extension a la variable "nombre"
                string nombreArchivo = Path.GetFileName(archivoRutaOrigen);

                // concatenamos la ruta de destino con el nombre de cada archivo que obtuvimos de la matriz
                string rutaCompletaArchivoDestino = Path.Combine(destinoDirectorioPa, nombreArchivo);

                // Copiamos el archivo de la ruta original en la nueva ruta
                File.Copy(archivoRutaOrigen, rutaCompletaArchivoDestino);
            }

            // Matriz para los nombres de los directorios 
            string[] subdirectorios = Directory.GetDirectories(origenDirectorioPa);

            // recorrer y copiar subdirectorios de manera recursiva
            foreach (string subdirectorioRutaOrigen in subdirectorios)
            {
                // Obtenemos el nombre de cada directorio contenido en la matriz y se lo asignamos a la variable nombreSUbdirectori
                string nombreSubdirectorio = Path.GetFileName(subdirectorioRutaOrigen);

                // Concatenamos la ruta de destino con el nombre de cada directorio que obtuvimos de la matriz 
                string rutaCompletaSubdirectorioDestino = Path.Combine(destinoDirectorioPa, nombreSubdirectorio);
            }
        }
    }
}
