namespace Seccion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            string elem;
            int opcion;
            int i;

            List<string> Personas = new List<string>();


            //do
            //{
            //    Console.WriteLine("1. Agregar elemento");
            //    Console.WriteLine("2. Salir");
            //    opcion = Convert.ToInt16(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        Console.Write("Ingresa el numero a agregar en la lista: ");
            //        elem = Console.ReadLine();

            //        Personas.Add(elem);
            //    }

            //} while (opcion == 1);

            Personas.Add("Hugo");
            Personas.Add("Miguel");
            Personas.Add("Diana");
            Personas.Add("Hector");


            Console.WriteLine("Informacion en la List: \n");
            // Instruccion "Foreach" para recorrer una coleccion 
            foreach (string elemento in Personas)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("Ingresa el Elemnto a buscar en las list");
            elem = Console.ReadLine();

            // Buscar el elemento en la list
            Console.WriteLine($"El elemnto se enciuentra en el indice: {Personas.IndexOf(elem)}");

            Personas.Clear();

            Console.WriteLine("Informacion en la List: \n");
            // Instruccion "Foreach" para recorrer una coleccion 
            foreach (string elemento in Personas)
            {
                Console.WriteLine(elemento);
            }


        }

    }

}
