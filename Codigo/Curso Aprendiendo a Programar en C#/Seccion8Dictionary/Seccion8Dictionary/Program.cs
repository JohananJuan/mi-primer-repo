using System.Xml.Linq;

namespace Seccion8Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary, se compone de un par Clave-valor o key-value pair
            Dictionary<string, int> empleados = new Dictionary<string, int>();

            // Anadiendo key-value pairs a la coleccion
            empleados.Add("Hugo", 36);
            empleados.Add("Erika", 16);

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"{elemento.Key}, {elemento.Value}");
            }

            // Collection[key] = value
            empleados["Miguel"] = 45;

            // Despues de agregar un elemento con Item[]
            Console.WriteLine("\nDespuesd e agregar un elemento con Item[]\n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"key = {elemento.Key}, Value = {elemento.Value} ");
            }

            // Comprobando que Item[] reemplaza la key

            // Collection[key] = value
            empleados["Hugo"] = 45;

            // Despues de agregar un elemento con Item[]
            Console.WriteLine("\nComprobando que Item[] reemplaza la key\n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"key = {elemento.Key}, Value = {elemento.Value} ");
            }

            // Usando el "Get"de la propiedad Item[]

            Console.WriteLine($"\nLa edad de Erika es: {empleados["Erika"]} ");

            Console.WriteLine("\nDespues de remover un elemento\n");
            empleados.Remove("Erika");

            // Despues de agregar un elemento con Item[]
            Console.WriteLine("\nDespues de remover\n");

            foreach (KeyValuePair<string, int> elemento in empleados)
            {
                Console.WriteLine($"key = {elemento.Key}, Value = {elemento.Value} ");
            }

            Console.WriteLine();

            if (empleados.ContainsKey("Erika"))
            {
                Console.WriteLine("La key se encuentra en la coleccion");
            }
            else
            {
                Console.WriteLine("La key no se enceuntra en la coleccion");

            }

            Console.WriteLine();

            if (empleados.ContainsValue(50))
            {
                Console.WriteLine("Existe Alguien con esa edad");
            }
            else
            {
                Console.WriteLine("No se encontro nadie con esa edad");

            }


        }
    }
}

