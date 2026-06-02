using System.Text;

namespace Seccion9StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string numeros = "";

            //for ( int i = 1; i <= 100; i ++)
            //{
            //    numeros += i + ",";
            //}

            //Console.WriteLine(numeros);

            StringBuilder numeros = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                numeros.Append(i);
                numeros.Append(' ');
            }

            string cadenaNumeros = numeros.ToString();
            Console.WriteLine(cadenaNumeros);

        }
    }
}
