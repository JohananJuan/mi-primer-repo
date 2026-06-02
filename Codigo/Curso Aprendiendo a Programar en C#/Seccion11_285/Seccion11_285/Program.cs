using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Seccion11_285
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool repetir = true;
            string mensajeParaCifrar, contrasenaMensaje, mensajeCifrado;

            // Creamnois un flujo/stream en la memoria Ram
            MemoryStream memoryStream1 = new MemoryStream();

            // Pedimos la cadena que va a ser guardada en el flujo 
            Console.Write("Ingresa el mensje que quieres cifrar: ");
            mensajeParaCifrar = Console.ReadLine();

            // Pedimos una contrasena para proteger el mensaje cifrado
            Console.Write("Ingresa una contrasena para proteger el mensaje: ");
            contrasenaMensaje = Console.ReadLine();

            // ENviamos la cadena dada por el usuario para cig=frarla 
            mensajeCifrado = CifrarMensaje(mensajeParaCifrar);

            // Declaramos una matriz de bytes y le asignamos la codificacion del mensaje ya cifrado parta obtener una secuencai de bytes 
            byte[] matrizCadenaByte = Encoding.UTF8.GetBytes(mensajeCifrado);

            // Escribimos el mensaje cifgrado en el fl;ujo 
            memoryStream1.Write(matrizCadenaByte, 0, matrizCadenaByte.Length);

            //. Mensaje p[asra separar el antes y despues del write\
            Console.WriteLine("El mensaje esta protegido, preesiona cualkquier tecla para continuar ... ");
            Console .ReadKey();

            // Empoezamos a lee el string (cifrado) almacenado en el memoryStream


            // Buffer para almacenar lkos bytes leido por Read
            byte[] buferBytesLeidos = new byte[100];

            // mover el puntero al inicio del flujo
            memoryStream1.Seek(0, SeekOrigin.Begin);

            // Leemos el contenido de nuestro flujo usando el metodo Read
            memoryStream1.Read(buferBytesLeidos, 0, (int)memoryStream1.Length);

            // Descodificamos la matriz de bytes leida para convertirla en un string
            string cadenasDescodificadaCifrada = Encoding.UTF8.GetString(buferBytesLeidos);

            // Mostramos el Menu 
            do
            {
                Console.Clear();

                Console.WriteLine("1, Mostrar mensaje\n" +
                                  "2. Descifrar mensaje\n" +
                                  "3. Me rindo");
                Console.Write("Escoje una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine ());


                switch ( opcion)
                {
                    case 1:
                        Console.WriteLine($"Mensaje: {cadenasDescodificadaCifrada} ");

                        Console.Write("Presiona cualquier tecla para continuar ...");
                        Console.ReadLine();
                       break ;

                    case 2:
                        Console.Write("Escribe un acontrasena para continuar: ");
                        string posibleContrasena = Console.ReadLine();

                        if (posibleContrasena == contrasenaMensaje)
                        {
                            // Mandamos la cadena codificada al metodo para ser descifrada y la devolucion la guardamos en una variable local 
                            string mensajeDescifrado = DescifrarMensaje(cadenasDescodificadaCifrada);

                            // Mostramos la cadena decodificada y ya descifrada
                            Console.WriteLine($"Mensaje: {mensajeDescifrado}");



                            Console.Write("Presiona cualquier tecla para continuar ...");
                            Console.ReadLine();

                            // Cerramos el flujo 
                            memoryStream1.Close();

                            // Finalizamos el programa
                            repetir = false;

                        }
                        else
                        {
                            Console.WriteLine("Contraena Incorrecta");

                            Console.Write("Presiona cualquier tecla para continuar ...");
                            Console.ReadLine();

                        }


                        break;

                    case 3:
                        repetir = false;
                        break;

                        default:
                        Console.WriteLine("Demasiados intentos");
                        break;
                }

            }
            while (repetir);

        }

        static string CifrarMensaje(string mensajeCifrarPa)
        {
            // Variable que va a guardar el mensaje cifrado
            string mensajeCifrado;

            // Le asignamos el mnesaje original a nuestra cariable local vacia
            mensajeCifrado = mensajeCifrarPa;

            // Reemplazamos las vocales por numeros en nuestro  mensaje almacenado en la variable local 
            mensajeCifrado = mensajeCifrado.Replace('a', '1'); 
            mensajeCifrado = mensajeCifrado.Replace('e', '2'); 
            mensajeCifrado = mensajeCifrado.Replace('i', '3'); 
            mensajeCifrado = mensajeCifrado.Replace('o', '4'); 
            mensajeCifrado = mensajeCifrado.Replace('u', '5'); 

            // Defvolvemos el mensaje cifrado
            return mensajeCifrado;
        }

        static string DescifrarMensaje(string mensajeCifradoPa)
        {
            // Variables que va a guardar el mensaje cifrado 
            string mensajeDescifrado;

            // Le asignamos el mensaje cifrado a nuestra variable locacal
            mensajeDescifrado = mensajeCifradoPa;

            // Reemplazamos os numero vacuios por vocales en nuestro mensaje almacenado en la variablke local, de esta forma revertimos el cifrado 
            mensajeDescifrado = mensajeDescifrado.Replace('1', 'a');
            mensajeDescifrado = mensajeDescifrado.Replace('2', 'e');
            mensajeDescifrado = mensajeDescifrado.Replace('3', 'i');
            mensajeDescifrado = mensajeDescifrado.Replace('4', 'o');
            mensajeDescifrado = mensajeDescifrado.Replace('5', 'u');

            // Devolvemos el menmsaje Descifrado
            return mensajeDescifrado;
        }

    }
}
