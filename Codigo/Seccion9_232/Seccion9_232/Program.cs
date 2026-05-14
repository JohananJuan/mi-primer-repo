using System.Numerics;
using System.Text;

namespace Seccion9_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            string nombreUsuario, opcion, contrasena;
            // Declaramos una tupla de nombre "Veriicar contyrtasena" para que reciba dos valores del metodo que valida la contrasena
            (bool contrasenaValida, string mensajeError) verificarContrasena;


            // Titulo mpara el programa
            Console.WriteLine("\t\tRegistro\n\n");

            Console.Write("Ingrese un nombre de usuario: ");
            nombreUsuario = Console.ReadLine();

            // Preguntamos si se desea hacer uso del generador de contrasenas o escribirla nosotros
            Console.Write("Desea que le generemos una contrasena segura? (si/no): ");
            opcion = Console.ReadLine();

            opcion = opcion.ToLower();

            switch (opcion)
            {
                case "si":
                    // Instanciamos a la clase Contrasena para poder hacer uso de ella
                    Contrasena contrasena1 = new Contrasena();

                    // Llamamos a su metodo "Genererar Contrasena"y le asignamos lo que devueleve a  nustra variable local "contrasena"
                    contrasena = contrasena1.GenerarContrasena();

                    Console.WriteLine($"\n\nEsta es tu contrasena: {contrasena}");

                    Console.Write("\nPresiona cualquier tecla para terminar tu registro: ");
                    Console.ReadKey();
                    Console.Clear();

                    // Mostramos el resumen de los datos
                    Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tUsuario: {nombreUsuario}\n\tcontrasena:{contrasena}");

                    break;

                case "no":
                    Console.Write("\nIngrese una contrasena segura (La contrasena debe tener entre 8-20 caracteres, incluido un numnero, una mayuscula, una minuscula y de los siguientes caracteres especiales ($%#&!?): ");
                    contrasena = Console.ReadLine();

                    // Instanciamos a la clase Contrasena para poder hacer uso de ella 
                    Contrasena contrasena2 = new Contrasena();

                    // Le asignamos  a la tupla lo que deuevuela el metoedo  "Comprobar contrtasena"y tambioen le mandamos como argumento a la variable local "contrasena"
                    verificarContrasena = contrasena2.ComprobarContrasena(contrasena);
                    if (verificarContrasena.contrasenaValida)
                    {
                        Console.Write("\nPresiona cualquier tecla para terminar tu registro: ");
                        Console.ReadKey();
                        Console.Clear();

                        // Mostramos el resumen de los datos
                        Console.WriteLine($"\nTus datos de acceso son los siguientes:\n\tUsuario: {nombreUsuario}\n\tcontrasena:{contrasena}");

                    }
                    else
                    {
                        // USamos al segundo elemento de la tupla ("mensajke Error) al que se le asigno una de las devoluciones del metodo, para despues msotrarlo
                        Console.WriteLine(verificarContrasena.mensajeError + "\a. Ingresa una contrasena valida");
                    }
                    break;
            }
        }
    }


    class Contrasena
    {
        // Campos
        // 4 colecciones de caracteres para escoger y generar la contrasena

        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnopqrstuvwxyz";
        string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string caracteresEspacial = "$%#&!?";

        // Contadores para verificar el numero de caracteres de cada grupo
        int numContiene = 0, minContiene = 0, mayContiene = 0, espContiene = 0;

        // Metodo para generar una contrasena

        public string GenerarContrasena()
        {
            //// Aqui guardamos la contrasena
            //string contrasenaGenerada = "";

            StringBuilder contrasenaGeneradaSB = new StringBuilder();

            // Instanciamos a la clase random para uysarla mas adelante
            Random random = new Random();

            // Declaramos una variable que guarda el tamano que tendra la contrasena, generamos un numero aleatorio que determine una l;ongitud de entre 8 y 20 caracteres y se lo asignamos a la variable 
            int longitudContrasena = random.Next(8, 21);

            // Variables que van a determinar el numero de caracteres que se usaran de cada grupo. Basandose en un porcentaje de la longitud de la contrasena
            double numTener = longitudContrasena * .15; // El 15% de los caracteres seran numeros
            double minTener = longitudContrasena * .35; // El 15% de los caracteres seran numeros
            double mayTener = longitudContrasena * .55; // El 15% de los caracteres seran numeros
            double espTener = longitudContrasena * .15; // El 15% de los caracteres seran numeros

            // Variable de tipo char que va a almacenar a cada uno de los carcateres
            char caracterEscogido;

            // Usamos una iteracion while para ir colocanbdo un caractes hasta completar la contrasena

            while (contrasenaGeneradaSB.Length < longitudContrasena)
            {
                switch(random.Next(0, 4))
                { 
                    case 0:
                        // Si los caracteres numericos que contiene la contrasena son menores a los que debe contener entonces ingresa ak blkoque del codigo y los genera
                        if (numContiene < numTener)
                        {
                            caracterEscogido = numeros[random.Next(numeros.Length)];
                            // Se le acumula el caracter escogido por Random a la contrasena Generada
                            contrasenaGeneradaSB.Append(caracterEscogido);
                            // Se aumenta en 1 a los caracteres numericos que contienen la contrasena
                            numContiene ++;
                        }

                        break;


                    case 1:
                        if (minContiene < minTener)
                        {
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            contrasenaGeneradaSB.Append(caracterEscogido);
                            minContiene ++;
                        }

                        break;


                    case 2:
                        if (mayContiene < mayTener)
                        {
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            contrasenaGeneradaSB.Append(caracterEscogido);
                            mayContiene ++;
                        }

                        break;


                    case 3:
                        if (espContiene < espTener)
                        {
                            caracterEscogido = caracteresEspacial[random.Next(caracteresEspacial.Length)];
                            contrasenaGeneradaSB.Append(caracterEscogido);
                            espContiene ++;
                        }

                        break;

                }
            } 
            return contrasenaGeneradaSB.ToString();
        }

        // Metodo para comprobar contrasenas
        public (bool, string) ComprobarContrasena(string contrasenaPa)
        {
            // Variable que guardara el valor bool cuando compruebe que todas las caracteristicas de las contrasena
            bool contrasenaValida = false;

            //Variables para cada criterio de la contrasena
            bool hayNumero = false, hayMinuscula = false, hayMayuscula = false, hayEspecial = false;

            // Variable que contendra el mensaje de error
            string mensajeError = "\a ";

            // Verificar primero que se cumpla la longitud 
            if (contrasenaPa.Length >= 8 && contrasenaPa.Length <= 20)
            {
                // Verificamos que contenga al menos un numero
                foreach (char elemento in numeros)
                {
                    // Si el elemento de numeros se encuentras en la contrasena dada por el usuario entonces ingresa al if y esNumero se convieret en trtue
                    if (contrasenaPa.IndexOf(elemento) >= 0)
                    {
                        hayNumero = true;
                        break; // Instruccion "Break" fuerza la terminacion del foreach en el momento en que encuentra el numero 
                    }
                    else
                    {
                        hayNumero =false;
                        mensajeError = "\aLa contrasena debe contener al menos un numero ";
                    }
                }
                // Verificamos un numero en la contrasena
                if(hayNumero)
                {
                    // Verificamos que contenga al menos una Letra minuscula
                    foreach (char elemento in letrasMin)
                    {
                        // Si el elemento de numeros se encuentras en la contrasena dada por el usuario entonces ingresa al if y esNumero se convieret en trtue
                        if (contrasenaPa.IndexOf(elemento) >= 0)
                        {
                            hayMinuscula = true;
                            break; // Instruccion "Break" fuerza la terminacion del foreach en el momento en que encuentra el numero 
                        }
                        else
                        {
                            hayMinuscula = false;
                            mensajeError = "\aLa contrasena debe contener al menos una minuscula ";
                        }
                    }
                    if (hayMinuscula)
                    {
                        // Verificamos que contenga al menos una Letra minuscula
                        foreach (char elemento in letrasMay)
                        {
                            // Si el elemento de numeros se encuentras en la contrasena dada por el usuario entonces ingresa al if y esNumero se convieret en trtue
                            if (contrasenaPa.IndexOf(elemento) >= 0)
                            {
                                hayMayuscula = true;
                                break; // Instruccion "Break" fuerza la terminacion del foreach en el momento en que encuentra el numero 
                            }
                            else
                            {
                                hayMayuscula = false;
                                mensajeError = "\aLa contrasena debe contener al menos una mayuscula ";
                            }
                        }
                    }
                    if (hayMayuscula)
                    {
                        // Verificamos que contenga al menos una Letra minuscula
                        foreach (char elemento in caracteresEspacial)
                        {
                            // Si el elemento de numeros se encuentras en la contrasena dada por el usuario entonces ingresa al if y esNumero se convieret en trtue
                            if (contrasenaPa.IndexOf(elemento) >= 0)
                            {
                                hayEspecial = true;
                                break; // Instruccion "Break" fuerza la terminacion del foreach en el momento en que encuentra el numero 
                            }
                            else
                            {
                                hayEspecial = false;
                                mensajeError = "\aLa contrasena debe contener al menos un caracter especial \"$%#&!?\" ";
                            }
                        }
                    }
                }
                // Vertificamops que exista un numero, una letra, etc
                if (hayNumero && hayMinuscula && hayMayuscula && hayEspecial)
                {
                    contrasenaValida = true;
                }
                else
                {
                    contrasenaValida = false;
                }
            }
            else
            {
                // Se le indica al usuario que la contrasena no cumple la longitud requerida
                mensajeError = "\ala contrasena debe contener entre 8-20 caracteres";
                contrasenaValida = false;
            }
            return (contrasenaValida, mensajeError);
        }
    }
}
