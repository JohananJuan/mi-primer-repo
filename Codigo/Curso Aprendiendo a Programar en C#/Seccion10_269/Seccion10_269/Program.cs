namespace Seccion10_269
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaramos una variable de Tipo "Type"y le asignamos muestras enumeracion 
            //Type tipoEnumeracion = typeof(Continenetes);

            //// Matriz para almacenar la devolucion de GetValues
            //Continenetes[] constantesContinentes;

            //// Le asignamos la devoulcion del metodo GetValues a nuestra matriz "ContantesContinenetes
            //constantesContinentes = (Continenetes[]) Enum.GetValues(typeof(Continenetes));

            foreach (var elemento in Enum.GetValues(typeof(Continenetes))) 
            {
                Console.WriteLine(elemento);
            }

        }
    }


    enum Continenetes
    {
        Africa,
        America,
        Asia,
        Europa,
        Oceania
    }
}
