namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables 
            int opcion;
            decimal r; // Almacena el valor devuelto de Restar()
            decimal num1Ar, num2Ar; // Argumentos para enviar una copia de su nvalor a los metodos

            do
            {
                Console.Write("Que opcion deseas hacer: \n" +
                              "1. Suma\n" +
                              "2. Resta\n" +
                              "3. Multiplicacion\n" +
                              "4. Division: ");
                opcion = Convert.ToInt16(Console.ReadLine());


            } while ((opcion < 1) || (opcion > 4));

            switch (opcion)
            {
                case 1:
                    Sumar ();
                    break;

                case 2:
                    r = Restar(); //Asignamos a "r" el valor devuelto por return
                    Console.Write("El resultado es: {0} ", r);
                    break;

                case 3:

                    num1Ar = IngresarNumero("Ingresa el primer numero: ");
                    num2Ar = IngresarNumero("Ingresa el segundo numero: ");

                    // Invocamos al metodo
                    Multiplicar (num1Ar, num2Ar);

                    break;
                     
                case 4:
                    num1Ar = IngresarNumero("Ingresa el primer numero: ");
                    num2Ar = IngresarNumero("Ingresa el segundo numero: ");

                    // Invocamos al metodo

                    r = Dividir(num1Ar, num2Ar);

                    Console.Write("El resultado es: {0} ", r);

                    break;

            }
        }
   
        // Fin de main 

        static void Sumar()
        {
            //Variables del metodo Sumar
            decimal num1, num2, resultado;

            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //opreacion
            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }


        static decimal Restar()
        {
            decimal num1, num2, resultado;

            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //opreacion
            resultado = num1 - num2;

            // Devolvemos un tipo al autor del llamado
            return resultado;

        } // Restar


        // [Modificador] [Tipo] [Identificador] [Parametros]

        static void Multiplicar (decimal num1Pa, decimal num2Pa )
        {
            decimal resultado;

            // Multiplicacion con los mnumeros que mandaron los argumentos
            resultado = num1Pa  * num2Pa;

            // Mostramos el resultador
            Console.WriteLine("{0} * {1} = {2}", num1Pa, num2Pa, resultado);
        }

        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {
            // Variable resultado
            decimal resultado;
            if (num2Pa != 0)
            {
                // Dividimos con los valores de los argumentos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine ("No se puede dividir eentre 0");
                resultado = 0;
            }
            return resultado;
        }

        static decimal IngresarNumero(String peticion)
        {
            decimal numero;

            // Pedimos el valor segun corresponda
            Console.Write(peticion);

            // Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            // Devolvemos el valor del tipo decimal
            return numero;

        }

    }
}


