namespace Tarea11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable que va a guardar la ruta a explorar
            string directorio;

            do
            {
                // Pide al usuario que ingrese la ruta del directorio que vamos a explorar
                Console.Write("Por favor, ingrese la ruta del directorio: ");
                directorio = Console.ReadLine();

                // Verifica si el directorio existe
                if (!Directory.Exists(directorio))
                {
                    Console.WriteLine("La ruta especificada no existe, Por favor, ingrese una ruta valida");
                }

            } while (!Directory.Exists(directorio)); // Mientras el directorio ingresado no exista, seguiremos pidiendo uno valido 

            // Sii el directorio ingresado si existe, salimos del do-while y ejecutamos el metodo con ese directorio como argumento
            ExplorarDirectorio(directorio);
        }

        static void ExplorarDirectorio(string directorioPa)
        {
            // Variable para controlar un cliclo para seguiir ejecutando el programa 
            bool continuar = true;

            // Mientras la variable continuar sea true el rpograma se seguirta ejecutando 
            while (continuar)
            {
                Console.Clear();

                // Mosramos un mensaje con el nombre del directorio que estanmos explorando 
                Console.WriteLine($"Contenido de: {directorioPa}\n");

                // Obtenemos una lista de todos los archivos y subdirectorios
                string[] archivosSubdirectorios = Directory.GetFileSystemEntries(directorioPa);

                // Mostramos el contenido del directorio en una tabla 
                MostrarTabla(archivosSubdirectorios);

                // Le pedimos al usaurio que ingrese una opcion de las mostradas en la tabla, segun su indicee. O le damos la opcion de salir del program,as
                Console.Write("Ingresa el numero de la opcion que sedeas explorar  (o 'a' para ir hacia atras en la ruta, 'n' para ingresar a una nueva ruta, o 's' para salir)");

                string opcion = Console.ReadLine().ToLower();

                // Analizamos las opciones usando una instruccion else if
                // Logica para slir del programa
                if (opcion == "s")
                {
                    // asignamos el valor de False para slir
                    continuar = false;
                }
                else if (opcion == "a")
                {
                    // Para regresar un nivel en la ruta, usamos a GetdirectoryName para extraer la ultima parte de la ruta, de esta forma logramos volver hacia atras
                    if (Path.GetDirectoryName(directorioPa) != null)
                    {
                        directorioPa = Path.GetDirectoryName(directorioPa);
                    }
                }
                else if (opcion == "n")
                {
                    Console.Clear();

                    // Pedimos al usuario que vuelva a ingresar una ruta para poder explorarla
                    Console.Write("Ingresa la nueva ruta: ");
                    string nuevaRuta = Console.ReadLine();

                    if (Directory.Exists(nuevaRuta))
                    {
                        directorioPa = nuevaRuta;
                    }
                    else
                    {
                        Console.WriteLine("Ruta no encontrada");
                        Console.WriteLine("Presiona cualquie tecla para continuar");
                        Console.ReadKey();
                    }

                }
                else if (opcion != "a" && opcion != "n" && opcion != "s")
                {
                    int opcionEscogida = Convert.ToInt32(opcion);

                    if (opcionEscogida >= 0 && opcionEscogida < archivosSubdirectorios.Length)
                    {
                        if (Directory.Exists(archivosSubdirectorios[opcionEscogida]))
                        {
                            directorioPa = archivosSubdirectorios[opcionEscogida];
                        }
                        else
                        {
                            // si la opcion no es un directorio, entonces es un archivo, asi que llamamos al metodo que nos permite trabajar con ello

                            OperacionesArchivos(archivosSubdirectorios[opcionEscogida]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresa un numero valido ");
                        Console.WriteLine("Presione cualquier tecla para continuar ...");
                        Console.ReadKey();
                    }
                }

            }


        }

        // Metodo usado para mostrar a los archivos y subdirectorios de forma ordenada
        static void MostrarTabla(string[] archivosSubdirectoriosPa)
        {
            // Imprimimos los tituilos de la tabla, dejando espacios y colocandolos a la izquierda 
            Console.WriteLine($"{"Indice",-8}{"Nombre",-50}{"Tipo",-13}");

            // Instanciamos a striung parar crear una cadena de guiones
            String guiones = new string('-', 71);

            // Imprimimos los guiones 
            Console.WriteLine(guiones);

            // Declaramos variables para guardar el nombre del archivo/directorio y su tipo (extensiono subdirectorio)
            string nombre, tipo;

            //  Recorremos a lamatriz que contiene a los archivos y subdirectorios
            for (int i = 0; i < archivosSubdirectoriosPa.Length; i++)
            {
                // extraemos solo el nombre del archivo o subdirectorio de la posicion en que nos encontremos y se lo asignamos a una variable "nombre"
                nombre = Path.GetFileName(archivosSubdirectoriosPa[i]);

                // Si existe un subdirectorio en nuestra posicion actual (for)
                if (Directory.Exists(archivosSubdirectoriosPa[i]))
                {
                    // Entonces el tipo sera un subdirectorio
                    tipo = "Subdirectorio";
                }
                else
                {
                    // Si no, entonces extraemos la extensio del archivo en el que estemos y se la asignamos a tipo
                    tipo = Path.GetExtension(archivosSubdirectoriosPa[i]);
                }

                // Mosramos un indice para el elemneto en el que estemos, su nombre (sin ruta compleja) y su tipo
                // Usamos la interpolacion de cadenas para alinear los elementos "í", "nombre", "tipo"
                Console.WriteLine($"{i,-8}{nombre,-50}{tipo,-13}");

            }

            Console.WriteLine();
        }

        // Metodo que maneja las operaciones copiar, mover, eliminar y renombrar de un archivo
        static void OperacionesArchivos(string rutaArchivoPa)
        {
            // Variables para colocarv rutas y respuestas de las 4 operaciones 
            string rutaCopiarArchivo, rutaMoverArchivo, destinoArchivo, respuestaReemplazo, respuestaEliminar, respuestaRenombrar, nuevoNombreArchivo, rutaArchivoRenombrado;

            // Extraemos el nombre del archivo y su extension para poder mostrarlo
            string nombreArchivo = Path.GetFileName(rutaArchivoPa);

            Console.WriteLine($"\n\nQue quieres hacer con el archivo [{nombreArchivo}]");

            // Mostramos el menu con las operaciones qu se pueden realizar
            Console.WriteLine("1. Copiar\n" +
                              "2. Mover\n" +
                              "3. Eliminar\n" +
                              "4. Renombrar");

            Console.Write("Selecciona una opcion: ");
            int opcionArchivo = Convert.ToInt32(Console.ReadLine());

            switch (opcionArchivo)
            {
                case 1:
                    // Preguntamos la ruta donde se quiere copiar el archivo
                    Console.Write("\nIngrese la ruta en donde se quiere copiar el archivo: ");
                    rutaCopiarArchivo = Console.ReadLine();

                    // verificamos que la ruta existe
                    if (Directory.Exists(rutaCopiarArchivo))
                    {
                        // Creamnos la ruta de destino con el nombre del archivo ya incluido
                        destinoArchivo = Path.Combine(rutaCopiarArchivo, nombreArchivo);

                        if (!File.Exists(destinoArchivo))
                        {
                            // Copiamos el archivo
                            File.Copy(rutaArchivoPa, destinoArchivo);

                            // Leer hacemos saber al usuario que la operacion fue exitosa 
                            MensajeRealizadoConExito("copiado");
                        }
                        else
                        {
                            Console.Write($"\nEl archivo [{nombreArchivo}] ya existe en la ruta de destino, Desea reemplazarlo?  (s/n)");
                            respuestaReemplazo = Console.ReadLine().ToLower();

                            if (respuestaReemplazo == "s")
                            {
                                File.Copy(rutaArchivoPa, destinoArchivo, true);

                                // Le hacemos saber al usuario que la operacion fue exitosa
                                MensajeRealizadoConExito("copiado");
                            }
                            else
                            {
                                // Le hacemos saber que la oracion fue cancelada
                                MensajeOperacionCancelada();
                            }
                        }

                    }
                    else
                    {
                        // Metodo que muestra un mensaje cuando la ruta ingresada no es valida 
                        MensajeRutaNoValida();
                    }


                    break;

                case 2:

                    // Preguntamos la ruta donde se quiere mover el archivo
                    Console.Write("\nIngrese la ruta en donde se quiere mover el archivo: ");
                    rutaMoverArchivo = Console.ReadLine();

                    // verificamos que la ruta existe
                    if (Directory.Exists(rutaMoverArchivo))
                    {
                        // Creamos la ruta de destino con el nombre del archivo ya incluido 
                        destinoArchivo = Path.Combine(rutaMoverArchivo, nombreArchivo);

                        // Verificamos que el archivo no exista en el destino
                        if (!File.Exists(destinoArchivo))
                        {
                            // Movemos el archivo 
                            File.Move(rutaArchivoPa, destinoArchivo);

                            // Le hacemos saber que al usuario que la operacion fue exitosa
                            MensajeRealizadoConExito("movido");
                        }
                        else
                        {
                            Console.Write($"\nEl archivo [{nombreArchivo}] ya existe en la ruta de destino, Desea reemplazarlo?  (s/n)");
                            respuestaReemplazo = Console.ReadLine().ToLower();

                            if (respuestaReemplazo == "s")
                            {
                                // Movemos el archivo
                                File.Move(rutaArchivoPa, destinoArchivo, true);

                                // Le hacemos saber al usuario que la operacion fue exitosa
                                MensajeRealizadoConExito("movido");
                            }
                            else
                            {
                                // Le hacemos saber que la oracion fue cancelada
                                MensajeOperacionCancelada();
                            }
                        }
                    }
                    else
                    {
                        // Metodo que muestra un mensaje cuando la ruta ingresada no es valida 
                        MensajeRutaNoValida();
                    }

                    break;

                case 3:
                    Console.Write($"\nEsta seguro de que desea eliminar el archivo [{nombreArchivo}] ?  (s/n)");
                    respuestaEliminar = Console.ReadLine().ToLower();

                    if (respuestaEliminar == "s")
                    {
                        // Eliminamos el archivo
                        File.Delete(rutaArchivoPa);

                        // Le hacemos saber al usuario que la operacion fue exitosa
                        MensajeRealizadoConExito("eliminado");
                    }
                    else
                    {
                        // Le hacemos saber que la oracion fue cancelada
                        MensajeOperacionCancelada();
                    }

                    break;

                case 4:
                    // Pedimos el nuevo nombre para el archivo 
                    Console.Write("\nIngresa el nuevo nombre para el archivo (con extension): ");
                    nuevoNombreArchivo = Console.ReadLine();

                    // Confirmamos que sea correcto 
                    Console.Write($"El nuevo nombre de [{nombreArchivo}] sera : [{nuevoNombreArchivo}], es correcto? (s/n): ");
                    respuestaRenombrar = Console.ReadLine().ToLower();

                    if (respuestaRenombrar == "s")
                    {
                        // En caso de querer renombrar, creamo la nueva ruta del archivo con el nuevo nombre. Para ello, quitamos el nombre de la ruta original y la conncatenamos el nuevo
                        rutaArchivoRenombrado = Path.Combine(Path.GetDirectoryName(rutaArchivoPa), nuevoNombreArchivo);

                        // Movemos el archivo, esto es para simular el renombre
                        File.Move(rutaArchivoPa, rutaArchivoRenombrado);

                        // Le hacemos saber al usaurio que la operacion fue exuitosa 
                        MensajeRealizadoConExito("renombrado");
                    }
                    else if (respuestaRenombrar == "n")
                    {
                        MensajeOperacionCancelada();
                    }

                    break;

                default:
                    Console.Write("Escoge una opcion correcta");
                    Console.Write("Presione cualquier tecla para continuar ...");
                    Console.ReadKey();

                    break;

            }

        }

        // Metodo que muestra un  mensaje cuando la ruta ingresada no es valida
        static void MensajeRutaNoValida()
        {
            // Le hacmos saber al usuario que ha ingresado una ruta invalida
            Console.WriteLine("\nIngresa una ruta valida");

            // Dejamos que el usuario vea que se equivoco y no escogfio un directorio 
            Console.Write("Presiona cualquier tecla para continuar ...");
            Console.ReadKey();
        }

        // Metodo que muestra un mensaje cuando alguna operaciones cancelada
        static void MensajeOperacionCancelada()
        {
            // Cancelamos la operacion
            Console.WriteLine("\nOperacion cancelada por el usuario");
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }

        // Metodo que muestra un  mensaje cuando las operaciones copiar, mover, eliminar y remombrar son exitosasa
        static void MensajeRealizadoConExito(string tipoMovimientoPa)
        {
            Console.WriteLine($"\nEl archivo se ha {tipoMovimientoPa} con exito");
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }

    }
}