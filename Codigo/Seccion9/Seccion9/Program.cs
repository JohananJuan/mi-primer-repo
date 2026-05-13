
using System.Xml.Schema;

namespace Seccion9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Contains", "StarsWith","EndsWith", "IndexOff" y "LastIndex"

            string parrafo = "- Siento llegar tarde, Dorian. Fui en busca de una pieza de brocado antiguo en Wardour Street, y he tenido que regatear durante horas para conseguirla. En los dias que corren la gente sabe el; precio de todo y el valo de nada.";

            Console.WriteLine($"Extracto del Retrato de Dorain Gray: \n\n{parrafo}\n");

            Console.Write("Ingresa el texto mque quieres buscar: ");
            string buscarTexto = Console.ReadLine();

            if(parrafo.EndsWith(buscarTexto))
            {
                Console.WriteLine($"El texto ({buscarTexto}) fue encontrado");
            }
            else
            {
                Console.WriteLine($"No se encontro el texto ({buscarTexto})");
            }

        }
    }
}




