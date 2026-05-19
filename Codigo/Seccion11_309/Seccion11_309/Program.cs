namespace Seccion11_309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origenDirectorio = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0\Mi primer Directorio\Nueva carpeta\Nueva carpeta";

            string destinoDirectorio = @"D:\repos\ejercicios-johanan\Codigo\Seccion11_309\Seccion11_309\bin\Debug\net10.0\Nueva carpeta";

            if ( Directory.Exists(origenDirectorio))
            {
                if (!Directory.Exists(destinoDirectorio))
                    {
                    Directory.Move(origenDirectorio, destinoDirectorio);
                    }
                else
                {
                    Console.Write("Directory dont esist");
                }
            }
            else
            {

                Console.Write("No se encontro");   
            }
        }
    }
}
