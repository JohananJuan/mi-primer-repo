//namespace Tarea11_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Variable que va a guardar la ruta a explorar
//            string directorio;

//            do
//            {
//                // Pide al usuario que ingrese la ruta del directorio que vamos a explorar
//                Console.Write("Por favor, ingrese la ruta del directorio: ");
//                directorio = Console.ReadLine();

//                // Verifica si el directorio existe
//                if (!Directory.Exists(directorio))
//                {
//                    Console.WriteLine("La ruta especificada no existe, Por favor, ingrese una ruta valida");
//                }

//            } while (!Directory.Exists(directorio)); // Mientras el directorio ingresado no exista, seguiremos pidiendo uno valido 

//            // Sii el directorio ingresado si existe, salimos del do-while y ejecutamos el metodo con ese directorio como argumento
//            ExplorarDirectorio(directorio);
//        }

//        static void ExplorarDirectorio(string directorioPa)
//        {
//            // Variable para controlar un cliclo para seguiir ejecutando el programa 
//            bool continuar = true;

//            // Mientras la variable continuar sea true el rpograma se seguirta ejecutando 
//            while (continuar)
//            {
//                Console.Clear();

//                // Mosramos un mensaje con el nombre del directorio que estanmos explorando 
//                Console.WriteLine($"Contenido de: {directorioPa}\n");

//                // Obtenemos una lista de todos los archivos y subdirectorios
//                string[] archivosSubdirectorios = Directory.GetFileSystemEntries(directorioPa);

//                // Mostramos el contenido del directorio en una tabla 
//                MostrarTabla(archivosSubdirectorios);

//                // Le pedimos al usaurio que ingrese una opcion de las mostradas en la tabla, segun su indicee. O le damos la opcion de salir del program,as
//                Console.Write("Ingresa el numero de la opcion que sedeas explorar  (o 'a' para ir hacia atras en la ruta, 'n' para ingresar a una nueva ruta, o 's' para salir)");

//                string opcion = Console.ReadLine().ToLower();

//                // Analizamos las opciones usando una instruccion else if
//                // Logica para slir del programa
//                if (opcion == "s")
//                {
//                    // asignamos el valor de False para slir
//                    continuar = false;
//                }
//                else if (opcion == "a")
//                {
//                    // Para regresar un nivel en la ruta, usamos a GetdirectoryName para extraer la ultima parte de la ruta, de esta forma logramos volver hacia atras
//                    directorioPa = Path.GetDirectoryName(directorioPa);
//                }
//                else if (opcion == "n")
//                {
//                    Console.Clear();

//                    // Pedimos al usuario que vuelva a ingresar una ruta para poder explorarla
//                    Console.Write("Ingresa la nueva ruta: ");
//                    string nuevaRuta = Console.ReadLine();

//                    if (Directory.Exists(nuevaRuta))
//                    {
//                        directorioPa = nuevaRuta;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Ruta no encontrada");
//                        Console.WriteLine("Presiona cualquie tecla para continuar");
//                        Console.ReadKey();
//                    }

//                }
//                else if (Convert.ToInt32(opcion) >= 0 && Convert.ToInt32(opcion) < archivosSubdirectorios.Length)
//                {
//                    int opcionEscogida = Convert.ToInt32(opcion);

//                    if (Directory.Exists(archivosSubdirectorios[opcionEscogida]))
//                    {
//                        directorioPa = archivosSubdirectorios[opcionEscogida];
//                    }
//                    else
//                    {
//                        // si la opcion no es un directorio, entonces es un archivo, asi que llamamos al metodo que nos permite trabajar con ello
//                        Console.WriteLine("Ruta no encontrada");

//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Ingresa un numero valido ");

//                }

//            }


//        }
//        static void MostrarTabla(string[] archivosSubdirectoriosPa)
//        {
//            // Imprimimos los tituilos de la tabla, dejando espacios y colocandolos a la izquierda 
//            Console.WriteLine($"{"Indice",-8}{"Nombre",-50}{"Tipo",-13}");

//            // Instanciamos a striung parar crear una cadena de guiones
//            String guiones = new string('-', 71);

//            // Imprimimos los guiones 
//            Console.WriteLine(guiones);

//            // Declaramos variables para guardar el nombre del archivo/directorio y su tipo (extensiono subdirectorio)
//            string nombre, tipo;

//            //  Recorremos a lamatriz que contiene a los archivos y subdirectorios
//            for (int i = 0; i < archivosSubdirectoriosPa.Length; i++)
//            {
//                // extraemos solo el nombre del archivo o subdirectorio de la posicion en que nos encontremos y se lo asignamos a una variable "nombre"
//                nombre = Path.GetFileName(archivosSubdirectoriosPa[i]);

//                // Si existe un subdirectorio en nuestra posicion actual (for)
//                if (Directory.Exists(archivosSubdirectoriosPa[i]))
//                {
//                    // Entonces el tipo sera un subdirectorio
//                    tipo = "Subdirecorio";
//                }
//                else
//                {
//                    // Si no, entonces extraemos la extensio del archivo en el que estemos y se la asignamos a tipo
//                    tipo = Path.GetExtension(archivosSubdirectoriosPa[i]);
//                }

//                // Mosramos un indice para el elemneto en el que estemos, su nombre (sin ruta compleja) y su tipo
//                // Usamos la interpolacion de cadenas para alinear los elementos "í", "nombre", "tipo"
//                Console.WriteLine($"{i,-8}{nombre,-50}{tipo,-13}");

//            }

//            Console.WriteLine();
//        }

//        static void OperacionesArchivos(string rutaArchivoPa)
//        {
//            // Variables para colocarv rutas y respuestas de las 4 operaciones 
//            string rutaCopiarArchivo, rutaMoverArchivo, destinoArchivo, respuestaReemplazo, respuestaEliminar, respuestaRenombrar, nuevoNombreArchivo, rutaArchivoRenombrado;

//            // Extraemos el nombre del archivo y su extension para poder mostrarlo
//            string nombreArchivo = Path.GetFileName(rutaArchivoPa);

//        }

//    }
//}



// Queda pendiente la elaboracion del metodo Opraciones con archivos y su implementacion en los casos segun corresponda Main