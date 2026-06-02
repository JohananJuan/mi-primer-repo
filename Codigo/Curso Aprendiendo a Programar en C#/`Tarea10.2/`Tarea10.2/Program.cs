namespace _Tarea10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intanciamos a la clase CompraBolertos
            // 
            CompraBoletos compraBoletos = new CompraBoletos();
            compraBoletos.Reservacion();
        }
    }

    // definimos una estructura para reprsentar la informacion del cliente 
    struct Cliente
    {
        // Campos
        string nombre;
        string apellidp;
        string id;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidp { get => apellidp; set => apellidp = value; }
        public string Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }
    }

    enum Destinos
    {
        Guadalajara = 900,
        Monterrey = 1000,
        LosAngeles = 1700
    }

    enum Horarios
    {
        Siete_AM = 7,
        Tres_PM = 15,
        Ocho_PM = 22
    }

    enum SeccionAvion
    {
        Atras = 0,
        Centro = 50,
        Adelante = 80
    }

    enum TipoAsiento
    {
        Medio = 20,
        Paasillo = 60,
        Ventana = 90
    }

    class CompraBoletos
    {
        // Campos
        Destinos destinoEscogido;
        Horarios horarioEscogido;
        SeccionAvion seccioEscogida;
        TipoAsiento asientoEscogido;

        int precioBase;
        int precioSeccion;
        int precioAsiento;
        int precioFinal;

        public void Reservacion()
        {
            // Mensaje de bienvenida
            Console.WriteLine("\n\t\tReserva de Vuelos\n");

            // Creamos un objeto cliente para poder guardar la informacion 
            Cliente cliente = new Cliente();

            // Pedimos infomacion al cliete
            Console.WriteLine("Ingrese la infroacion que se le pide a contiuacion: ");

            Console.WriteLine("Ingrese la informaciob que se le pide: ");

            Console.Write("Nombre: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            cliente.Apellidp= Console.ReadLine();
            Console.Write("Edad: ");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Identificaion Oficial: ");
            cliente.Id = Console.ReadLine();

            SeleccionarDestino();
            SeleccionarHorario();
            SeleccionarSeccion();
            SeleccionarAsiento();
            ResumenREservacion(cliente);

        }

        public void SeleccionarDestino()
        {
            // Variables 
            int opcionDestino;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nDestinos Disponibles: ");

            foreach (Destinos elemento in Enum.GetValues(typeof(Destinos)))
            {
                Console.WriteLine($"{indice ++}. {elemento} - $ {(int)elemento}");
            }
            Console.Write("Selecciones un destino (numero): ");
            opcionDestino = Convert.ToInt32(Console.ReadLine());

            switch (opcionDestino )
            {
                case 1:
                    destinoEscogido = Destinos.Guadalajara;
                    precioBase = (int)destinoEscogido;
                    break;

                case 2:
                    destinoEscogido = Destinos.Monterrey;
                    precioBase = (int)destinoEscogido;
                    break;

                case 3:
                    destinoEscogido = Destinos.LosAngeles;
                    precioBase = (int)destinoEscogido;
                    break;

                default:
                    Console.WriteLine("Destino no valido");
                    break;
            }

        }

        public void SeleccionarHorario()
        {
            // Variables 
            int opcionHorario;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nHorarios Disponibles: ");

            foreach (Horarios elemento in Enum.GetValues(typeof(Horarios)))
            {
                Console.WriteLine($"{indice++}. {elemento} - $ {(int)elemento}");
            }
            Console.Write("Selecciones un destino (numero): ");
            opcionHorario = Convert.ToInt32(Console.ReadLine());

            switch (opcionHorario)
            {
                case 1:
                    horarioEscogido = Horarios.Siete_AM;
                    break;

                case 2:
                    horarioEscogido = Horarios.Tres_PM;
                    break;

                case 3:
                    horarioEscogido = Horarios.Ocho_PM;
                    break;

                default:
                    Console.WriteLine("Horario no valido");
                    break;
            }
        }

        public void SeleccionarSeccion()
        {
            // Variables 
            int opcionSeccion;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nSecciones Disponibles: ");

            foreach (SeccionAvion elemento in Enum.GetValues(typeof(SeccionAvion)))
            {
                Console.WriteLine($"{indice++}. {elemento} - $ {(int)elemento}");
            }
            Console.Write("Selecciones seccion (numero): ");
            opcionSeccion = Convert.ToInt32(Console.ReadLine());

            switch (opcionSeccion)
            {
                case 1:
                    seccioEscogida = SeccionAvion.Atras;
                    precioSeccion = (int)seccioEscogida;
                    break;

                case 2:
                    seccioEscogida = SeccionAvion.Centro;
                    precioSeccion = (int)seccioEscogida;
                    break;

                case 3:
                    seccioEscogida = SeccionAvion.Adelante;
                    precioSeccion = (int)seccioEscogida;
                    break;

                default:
                    Console.WriteLine("Seccion no valido");
                    break;
            }
        }

        public void SeleccionarAsiento()
        {
            // Variables 
            int opcioAsiento;
            int indice = 1;

            // Mostramos los destinos disponibles
            Console.WriteLine("\nAsientos Disponibles: ");

            foreach (TipoAsiento elemento in Enum.GetValues(typeof(TipoAsiento)))
            {
                Console.WriteLine($"{indice++}. {elemento} - $ {(int)elemento}");
            }
            Console.Write("Selecciones un asiento (numero): ");
            opcioAsiento = Convert.ToInt32(Console.ReadLine());

            switch (opcioAsiento)
            {
                case 1:
                    asientoEscogido = TipoAsiento.Medio;
                    precioAsiento = (int)asientoEscogido;
                    break;

                case 2:
                    asientoEscogido = TipoAsiento.Paasillo;
                    precioAsiento = (int)asientoEscogido;
                    break;

                case 3:
                    asientoEscogido = TipoAsiento.Ventana;
                    precioAsiento = (int)asientoEscogido;
                    break;

                default:
                    Console.WriteLine("Asiento no valido");
                    break;
            }
        }

        public void ResumenREservacion(Cliente cliente)
        {
            // Limpiamos
            Console.Clear();

            // Mostramos el resumen de la reserva
            Console.WriteLine("Resumen de la reserva: \n");
            Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellidp} ");
            Console.WriteLine($"Edad: {cliente.Edad}");
            Console.WriteLine($"Numero de identificaion: {cliente.Id}  ");

        }


    }

}
