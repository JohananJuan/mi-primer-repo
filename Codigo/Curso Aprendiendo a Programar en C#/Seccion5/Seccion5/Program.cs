namespace Seccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Luis";
            byte calle = 50;
            long numero = 10;
            int calificacion = 000111222;

            // (tipo) identificado = (valor);
            (string nombre, byte edad, long numero, int calificacion) persona1 = ("Luis" ,50 ,10 ,000111222);

            Console.WriteLine(persona1.nombre);
                 
        }
    }
}
