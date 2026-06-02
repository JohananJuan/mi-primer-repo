namespace Seccion8Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack
            Stack<double> miPila = new Stack<double>();

            // Insertar objetos al principio del stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);


            int i = 0;

            // Mostrar l,a informacion del stack

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            // Despues de insertar un elemneto
            Console.WriteLine("\nDespues de insertar un elemento\n");
            miPila.Push(1.5);

            i = 0;

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            // Despoues de quitar un elemento
            Console.WriteLine("\nDespues de quitar un elemento\n");
            var eliminado = miPila.Pop();
            i = 0;



            // Mostrar la informacion del stack

            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"\nEl elemnto ({eliminado}) ha sido eliminado con exito");

            // Despues de usar peek
            Console.WriteLine("\nDespues de usar peek\n");
            var primerObj = miPila.Peek();

            i = 0;

            // Mostrar la informacion  del stack
            foreach (double elemento in miPila)
            {
                Console.WriteLine($"{i++}. {elemento}");
            }

            Console.WriteLine($"El primer elemento del Stack es: ({primerObj})");

            bool contiene;
            double buscarElem;

            Console.Write("\nIngresa el numero buscar: ");
            buscarElem = Convert.ToDouble(Console.ReadLine());

            contiene = miPila.Contains(buscarElem);

            if (contiene)
            {
                Console.WriteLine($"El objeto ({buscarElem}) se encuentra en el stack");
            }
            else
            {
                Console.WriteLine($"No se encontro el objeto ({buscarElem}) en el satck");
            }

            Console.Write($"\nEl Stack tiene {miPila.Count} elementos");

            // Borrando el stack
            Console.WriteLine("\nDespues de borrar el Stack");
            miPila.Clear();

            Console.WriteLine($"\nEl stack tiene {miPila.Count} elemntos");

        }
    }
}
