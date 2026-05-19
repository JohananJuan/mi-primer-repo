namespace Seccion11_312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz para almacenar los nombres de los archivos
            string[] nombresArchivos;

            // Buscamos archivos en la ruta del proyecto y asignamos la devolucion a la maatriz string 
            nombresArchivos = Directory.GetFiles(@"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0");

            int indice = 1;

            // Recorremos a la matriz y mostramos sus elementos 
            foreach (string elemento in nombresArchivos)
            {
                Console.WriteLine($"{indice ++ }.- {Path.GetFileName(elemento)}");
            }


            // Matriz para almacenar los nombres de los archivos
            string[] nombresDirectories;

            // Buscamos archivos en la ruta del proyecto y asignamos la devolucion a la maatriz string 
            nombresDirectories = Directory.GetDirectories(@"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0");

            // Espacio para un mejor formato
            Console.WriteLine();

            int indice1 = 1;
           

            // Recorremos a la matriz y mostramos sus elementos 
            foreach (string elemento in nombresDirectories)
            {
                Console.WriteLine($"{indice1++}.- {Path.GetFileName(elemento)}");
            }
        }
    }
}
