namespace Seccion11_305
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string origenArchivo = "contra.txt";
                string destinoArchivo = "C:\\Users\\User\\Documents\\app\\johan\\product\\Pueba.txt";

                File.Move(origenArchivo, destinoArchivo, false);

        }
    }
}
