namespace Tarea10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
            Celular newProducto = new Celular();
            
            // limpiamos consola y colocamos el titulo
            Console.Clear();
            Console.WriteLine("\n\t\tAgregar producto\n");

            // Preguntamos los valores que tendra el producto y se los asignamos
            Console.Write("Marca: ");

        }

    }

}
