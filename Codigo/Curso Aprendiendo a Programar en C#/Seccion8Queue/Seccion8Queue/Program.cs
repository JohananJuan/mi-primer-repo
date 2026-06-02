namespace Seccion8Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> miFila = new Queue<char>();


            // agregando objetos al Queue
            miFila.Enqueue('a');
            miFila.Enqueue('b');
            miFila.Enqueue('c');
            miFila.Enqueue('d');

            int i = 0;

            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }

            // Agregando otro elemento
            Console.WriteLine("\nDespues de agregar a (e)\n");
            miFila.Enqueue('e');

            i = 0;

            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }

            // Despues de quitar un elemento

            Console.WriteLine("\nDespues de quitar el elemnto");
            var objElimin = miFila.Dequeue();

            Console.WriteLine($"\nTal elemento se elimino ({objElimin})");

            i = 0;

            // Recorriendo la Queue
            foreach (char elemento in miFila)
            {
                Console.WriteLine($"{i++}.  {elemento}");
            }


        }
    }
}
