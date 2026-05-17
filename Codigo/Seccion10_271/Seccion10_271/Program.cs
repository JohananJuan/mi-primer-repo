namespace Seccion10_271
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            string nombreJugador1, nombreJugador2;
            int primerTurno;

            // Pedimos elk nombre del jugador 1
            Console.Write("Jugador 1, escoge un nombre: ");
            nombreJugador1 = Console.ReadLine();

            // Creamos al primer jugador y enviamos su nombre y salu inicial
            Jugador jugador1 = new Jugador(nombreJugador1, 1000);

            // Le preguntamos al primer jugador el personaje y arma que va a ausar 
            jugador1.EscogerPersonaje();
            jugador1.EscogerArma();


            // Pedimos elk nombre del jugador 2
            Console.Write("Jugador 2, escoge un nombre: ");
            nombreJugador2 = Console.ReadLine();

            // Creamos al primer jugador y enviamos su nombre y salu inicial
            Jugador jugador2 = new Jugador(nombreJugador2, 1000);

            // Le preguntamos al primer jugador el personaje y arma que va a ausar 
            jugador2.EscogerPersonaje();
            jugador2.EscogerArma();

            //Invocamos a TirarDados y guardamos el valor random devuelto en la variable primnerTurno

            primerTurno = Batalla.TirarDados();

            // Determinamos cual jugador empezara primero
            if (primerTurno == 1)
            {
                // El jugador 1 empieza primero
                Console.WriteLine($"{jugador1.Nombre} empieza primero \n");

                // Enviamos primero al jugador 1 para que realice el ataque
                Batalla.SimularBatalla(jugador1, jugador2);
            }
            else
            {
                Console.WriteLine($"{jugador2.Nombre} empieza primero \n");
                Batalla.SimularBatalla(jugador2, jugador1);

            }


        } // Fin de main
    } // Fin de la calse Program

    enum TipoPersonaje
    {
        Escudero,
        Arquero,
        Caballero
    } // Tipo Personaje


    enum TipoArma
    {
        Espada,
        Arco,
        Martillo
    } // Tipo Arma

    class Jugador
    {
        // Campos
        string nombre;
        int salud;
        int ataque;
        int defensa;
        TipoPersonaje personajeEscogido;
        TipoArma armaEquipada;

        // Instanciamos Random
        Random random = new Random();

        // Propiedades 
        public string Nombre { get => nombre; set => nombre = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        internal TipoPersonaje PersonajeEscogido { get => personajeEscogido; set => personajeEscogido = value; }
        internal TipoArma ArmaEquipada { get => armaEquipada; set => armaEquipada = value; }

        // Constructor
        public Jugador (string nombrePa, int saludPa)
        {
            nombre = nombrePa;
            salud = saludPa;
        }

        // Metodo que permite al usuario escoiger personaes del enum
        public void EscogerPersonaje()
        {
            // Guarda el valor de las opciones  escogidas
            int opcion;

            Console.Clear();

            // Menu para escoger personajes
            do
            {
                Console.WriteLine("1. Escudero\n" +
                                  "2. Arquero\n" +
                                  "3. Caballero");
                Console.Write($"{nombre}, escoge un personaje:  ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while( opcion < 1 || opcion > 3 );

            // Switch para roles de personajes
            switch ( opcion )
            {
                case 1:
                    PersonajeEscogido = TipoPersonaje.Escudero;
                    ResumenPersonajeEscogido();

                    break;

                case 2: 
                    PersonajeEscogido = TipoPersonaje.Arquero;
                    ResumenPersonajeEscogido();

                    break;

                case 3:
                    PersonajeEscogido = TipoPersonaje.Caballero;
                    ResumenPersonajeEscogido();

                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;


            }
        } // Escoger Personaje

        public void ResumenPersonajeEscogido()
        {
            // Mostramos un resumen del personaje que ecogio el jugador
            Console.WriteLine($"{Nombre}, ahora eres un \"{personajeEscogido}\"");

            Console.Write("\nPresione Caulquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();


        } // Resumen de personaje escodigo

        public void EscogerArma()
        {
            // Guarda el valor de la opcion escogida
            int opcion;

            Console.Clear();

            // Mientras opcion sea vaslida
            do
            {
                Console.WriteLine("1. Espada (ataque: 130, defensa: 40) ");
                Console.WriteLine("2. Arco (ataque: 140, defensa: 30)");
                Console.WriteLine("3. Martillo (ataque: 150, defensa: 20)");

                Console.Write($"\n {nombre}, elige un arma: ");
                opcion = Convert.ToInt32( Console.ReadLine() );
                Console.Clear();

                // Switch para los tipos de armas que el usuario escoja

                switch (opcion)
                {
                    case 1:
                        ArmaEquipada = TipoArma.Espada;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;

                    case 2:
                        ArmaEquipada = TipoArma.Arco;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;

                    case 3:
                        ArmaEquipada = TipoArma.Martillo;
                        ValoresAtaqueDefensaArma();
                        ResumenArmaEscogida();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            } while (opcion < 1 || opcion > 3);
        }// Escoger arma 


        // Metodo para asignar valores de ataque y defensa al jugador dependiendo de la arma 
        public void ValoresAtaqueDefensaArma()
        {
            switch(ArmaEquipada)
            {
                case TipoArma.Espada: 
                    Ataque = 130;
                    Defensa = 40;
                    break;

                case TipoArma.Arco: 
                    Ataque = 140;
                    Defensa = 30;
                    break;

                case TipoArma.Martillo:
                    Ataque = 150;
                    Defensa = 20;
                    break;

            }
        } // Vlores Ataque Defensa
        // Resumen de Arma Escogida
        public void ResumenArmaEscogida()
        {
            Console.WriteLine($"{Nombre}, escogiste \"{ArmaEquipada}\" \nCon el nivel de ataque: [{Ataque}] y una defensa de [{Defensa}] ");

            Console.Write($"\nPresiona cualquier tecla para continuar...");
            Console.ReadLine();
            Console.Clear();

        } // Resumen de arma Escogida
        public void Atacar()
        {
            Console.WriteLine($"\n{PersonajeEscogido} {Nombre} ataca con su {ArmaEquipada}\n");
        }

        public void Defender()
        {
            Console.WriteLine($"\n{PersonajeEscogido} {Nombre} de defiende con su {ArmaEquipada}\n");
        }

        // Metodo para preguntarle al usuario si desea atacar o defender
        public void EscogerAtacarDefender()
        {
            // Guarda el valor de la opcion escogida
            int opcion; 
            do
            {
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Defender");
                
                Console.Write($"\n [{PersonajeEscogido} {Nombre}], elige una opcion:  ");
                opcion = Convert .ToInt32( Console.ReadLine() );

                switch (opcion) 
                {
                    case 1:
                        Atacar();
                        break;

                    case 2:
                        Defender();
                        break;

                        default:
                        Console.Write("Opcion ivalida");
                        break;
                }
            } while (opcion < 1 || opcion > 2);
  


        }

        public void ResumenJugador()
        {
            Console.WriteLine($"[{PersonajeEscogido}{Nombre}] Salud: {Salud} / [{ArmaEquipada}] Ataque: {Ataque}. Defensa {Defensa}");
        }

        public void CalcularDano(int ataqueOtroJugadorPa)
        {
            int danoRecibido;

            // Varable para dano aleatrorio 
            int ataqueSorpresa;

            // Le asignamos un valor de ataque aleatorio usando Next
            ataqueSorpresa = random.Next(-15, 16);

            danoRecibido = ataqueOtroJugadorPa - Defensa + ataqueSorpresa;
            Salud -= danoRecibido;
        }


    } // Clase Jugador

    class Batalla
    {
        // Insanciamos a Random
        static Random random = new Random();

        // Metodo que determian que jugador empezara
        public static int TirarDados()
        {
            Console.WriteLine("Presiona cualquier tecla para determinar que jugador comienza ...");
            Console.ReadKey();
            Console.Clear();

            // Variable que guarda el valor de los datos
            int primerTurno = random.Next(1, 3);
            return primerTurno;
        }

        public static void SimularBatalla(Jugador jugador1Pa, Jugador jugador2Pa)
        {
            // Variable emcargada de controlar las rondas de los jugadores
            int ronda = 1;

            // Mensaje Inical 
            Console.WriteLine("La batalla ha comenzado\n");
            Console.WriteLine($"RONDA {ronda}\n");

            // Mostraremos un resumen de cada jugador
            jugador1Pa.ResumenJugador();
            jugador2Pa.ResumenJugador();

            // Primer ronda del Jugador 1
            Console.WriteLine($"\n {jugador1Pa.PersonajeEscogido} {jugador1Pa.Nombre}, empieza a atacar ");
            Console.Write($"Presiona Enter para usar tu {jugador1Pa.ArmaEquipada} ...");
            Console.ReadKey();
            jugador1Pa.Atacar();

            // Calculamos el damo del jugador 1 acaba de hacerle al jugador 2
            jugador2Pa.CalcularDano(jugador1Pa.Ataque);

            // Primera ronda del  jugador2
            // Le preguintamos que quiere hacer
            jugador2Pa.EscogerAtacarDefender();

            // CAlculamos el dano del jugador 2 al jugador 1
            jugador1Pa.CalcularDano(jugador2Pa.Ataque);

            // Seguimos haciendo lo mismo 4 vrondas mas 
            for (ronda = 2;  ronda <= 5; ronda ++)
            {
                // Mostramos la ronda que se estga jugando
                Console.WriteLine($"Ronda {ronda}\n");

                // Mostramos el resumen de cada jugador
                jugador1Pa.ResumenJugador();
                jugador2Pa.ResumenJugador();

                // Le preguntamos alk jugador que sea hacer
                jugador1Pa.EscogerAtacarDefender();

                // Calculamos el dano del jugador 1 acaba de hacer al jugador 2
                jugador2Pa.CalcularDano(jugador1Pa.Ataque);

                Console.WriteLine();
            }
            // Mensaje dando por terminada la batalla 
            Console.WriteLine("\nLa batalla ha terminado\n");

            //Mostramos por ultima vez las estadisticas de cada jugador
            jugador1Pa.ResumenJugador();
            jugador2Pa.ResumenJugador();

            // Determinamos quien gano la batalla basandose en su nivel de salud final
            if (jugador1Pa.Salud > jugador2Pa.Salud)
            {
                Console.WriteLine($"\n{jugador1Pa.Nombre} ha ganado");
            }
            else
            {
                Console.WriteLine($"\n{jugador2Pa.Nombre} ha ganado");
            }
        } // Clase Batalla

    }// Fin de batalla


} // Fin del Namespace
