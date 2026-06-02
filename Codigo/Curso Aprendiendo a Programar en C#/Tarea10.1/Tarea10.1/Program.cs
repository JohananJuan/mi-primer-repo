namespace Tarea10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            bool repetir = true; // Se encarga de repetir el menu  hasta que nosotros decidamos alir de el 
            int opcion;

            Inventario inventario = new Inventario();

            do
            {
                Console.Clear();

                Console.WriteLine("\nMundo Celular\n");
                Console.WriteLine("1. Agregar producto\n " +
                                  "2. Mostrar inventario\n" +
                                  "3. Eliminar Producto\n" +
                                  "4. Salir");
                Console.Write("Ingresa una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        inventario.AgregarProducto();
                        break;

                    case 2:
                        inventario.MostrarProducto();
                        break;

                    case 3:
                        inventario.eliminarProducto();
                        break;

                    case 4:
                        repetir = false;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }


            } while (repetir);
        }
    }

    struct Celular
    {
        // Campos
        string marca;
        string modelos;
        int memoriaPrincipal;
        double precio;
        int stock;

        public string Marca { get => marca; set => marca = value; }
        public string Modelos { get => modelos; set => modelos = value; }
        public int MemoriaPrincipal { get => memoriaPrincipal; set => memoriaPrincipal = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }

    class Inventario
    {
        // Crea una lista de productos para almacenar el inventario
        List<Celular> listaCelulares = new List<Celular>();

        public void AgregarProducto()
        {
            // Creamos un producto (objeto)
            Celular nuevoProducto = new Celular();
            
            // limpiamos consola y colocamos el titulo
            Console.Clear();
            Console.WriteLine("\n\t\tAgregar producto\n");

            // Preguntamos los valores que tendra el producto y se los asignamos
            Console.Write("Marca: ");
            nuevoProducto.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            nuevoProducto.Modelos = Console.ReadLine();

            Console.Write("Memoria: ");
            nuevoProducto.MemoriaPrincipal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Precio: ");
            nuevoProducto.Precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock: ");
            nuevoProducto.Stock = Convert.ToInt32(Console.ReadLine());

            // Agregamos el producto Celular al inventario List
            listaCelulares.Add(nuevoProducto);

            Console.Write("Productoi agregado con exito");
            Console.ReadKey();
        }

        public void MostrarProducto()
        {
            Console.Clear();

            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("El inventario esta vacio");
            }
            else
            {
                int indice = 1;
                Console.WriteLine("Inventario de productos:\n");

                foreach (var elemento in listaCelulares)
                {
                    Console.WriteLine($"{indice}. Marca: {elemento.Marca}, Modelo: {elemento.Modelos}, Memoria: {elemento.MemoriaPrincipal}, Precio: ${elemento.Precio}, Stock: {elemento.Stock},");
                    indice ++;

                }
            }
            Console.Write("\nPresione culaquier tecla para continuar...");
            Console.ReadKey();

        }

        public void eliminarProducto()
        {
            // Variables para indicar el indice del producto a eliminar
            int productoEliminar;

            Console.Clear();
            if (listaCelulares.Count == 0)
            {
                Console.WriteLine("El inventario esta vacio");
            }
            else
            {
                Console.Write($"Ingresa el numero de producto (indice) que deseas eliminar (del 1 al {listaCelulares.Count}): ");
                productoEliminar = Convert.ToInt32(Console.ReadLine()) - 1;  // Decimos que -1 para que el inidce ingresado coincida con el indice real de la list

                // Verificamos que el numero ingresado sea valido 
                if (productoEliminar >= 0 && productoEliminar < listaCelulares.Count)
                {
                    // Confirmamos si el producto Ingresado es el quese desea aliminar
                    Console.Write($"Deseas elimanar:  {listaCelulares[productoEliminar].Marca}, {listaCelulares[productoEliminar].Modelos}? (si/no): ");
                    string opcion = Console.ReadLine().ToLower();

                    if (opcion == "si")
                    {
                        // Variables para mostrar un mensaje de cula fue el libro eliminado
                        string marcaEliminada = listaCelulares[productoEliminar].Marca;
                        string modeloEliminada = listaCelulares[productoEliminar].Modelos;
                        
                        // Eliminamos el producto
                        listaCelulares.RemoveAt(productoEliminar);

                        // Le mostramos al usuario que  libro se eliminao
                        Console.WriteLine($"\nEl producto {marcaEliminada} {modeloEliminada} fue eliminado");

                    }
                    else
                    {
                        Console.Write("Operacion \"Eliminar producto candelada\"");
                    }
                    Console.Write("Operacion \"Eliminar producto candelada\"");
                }
                Console.Write("Presiona cualquier tecla para continuar ...");
                Console.ReadKey();
            }


        }

    }

}
