namespace Seccion10_247
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de la estructuraa Cliente
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "Juan";
            cliente1.edad = 30;
            cliente1.direccion = "Calle lirios 5";

            Cliente cliente2 = new Cliente();
            cliente2.nombre = "Maria";
            cliente2.edad = 25;
            cliente2.direccion = "Av. Reforma 354";

            // Instanciamos a la clase
            RegistrarClientes registro1 = new RegistrarClientes();

            // Registrar clientes a traves del metodo
            registro1.RegistrarCliente(cliente1);
            registro1.RegistrarCliente(cliente2);

            // Mostrar lista de clientes registrados
            registro1.MostrarClientesRegistrados();

        }
    }

    struct Cliente
    {
        public string nombre;
        public int edad;
        public string direccion;
    }


    class RegistrarClientes
    {
        // Declaramos una lista generica para guardar a los clientes 
        List<Cliente> listaClientes = new List<Cliente>();
        
        // Meetodo para registar clientes 

        public void RegistrarCliente(Cliente clientePa)
        {
            listaClientes.Add(clientePa);
        }

        public void MostrarClientesRegistrados()
        {
            Console.WriteLine("Lista de clientes registrados: \n");
            foreach (var elemento in listaClientes)
            {
                Console.WriteLine($"Nombre: {elemento.nombre}");
                Console.WriteLine($"Edad: {elemento.edad} ");
                Console.WriteLine($"Direccion: {elemento.direccion}");
                Console.WriteLine($"-------------------------------");
            }
        }


    }

   

}
