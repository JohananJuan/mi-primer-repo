namespace Seccion10_271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaConvertir;

            Console.Write("Ingresa un color perteneciente a RGB: ");
            cadenaConvertir = Console.ReadLine();

            // Variable de tipo  enum "RGB" donse se va a almacenar el valor de la string
            RGB cadenaConvertidaAEnum;

            // Asignamos la devolucion del metodo en la variable enum RGB
            cadenaConvertidaAEnum = (RGB)Enum.Parse(typeof(RGB), cadenaConvertir);

        }
    }

    enum RGB
    {
        Rojo,
        Verde,
        Azul
    }
}
