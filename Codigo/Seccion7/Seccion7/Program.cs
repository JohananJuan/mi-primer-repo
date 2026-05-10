namespace Seccion7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variable local
            bool acelerar;


            // Instanciamos la calse automovil
            Automovil automovil1 = new Automovil();


            // Mostyramos el campo privado
            //Console.WriteLine($"El color es: {automovil1.Color}");


            // Asignandole un valor a campoo privado
            automovil1.Combustible = "Diesel";
            //Console.WriteLine($"El combustible es: {automovil1.Combustible}");

            Console.WriteLine(automovil1.ToString());

        
        }

    }

    // [Modificador de accxeso] [class] [indentificador]

    public class Automovil
    {
        // Campos
        private string color = "rojo", modelo = "ZB30", combustible, ano = "1998", numPuertas = "4";
        private int ccMotor = 1500;


        // Ejemplo para campos inicialikzados con el constructor
        private string asientos, colorTablero;
        private bool camaraTrasera;


        //Constructor
        public Automovil()
        {
            asientos = "Piel";
            colorTablero = "Cafe";
            camaraTrasera = false;
        }


        // Propiedades 
        // [acceso] [tipo] [Nombre]

        public string Color
        {
            // descripcion de acceso get
            get => color;

        }


        // un descriptor de acceso set

        public string Combustible
        {
            get { return combustible; }
            set => combustible = value; 
        }



        // Metodos
        public bool Acelerar()
        {
            bool acelerar = true;
            Console.WriteLine("Acelerar");
            return acelerar;
        }

        public bool Frenar()
        {
            bool acelerar = true;
            Console.WriteLine("Frenar");
            return acelerar;
        }


        public void velocidades(ref byte velocidadPa)
        {
            velocidadPa++;
            Console.WriteLine("Cambio de velocidad");
        }


        // Invalidadno el ,metodo string

        public override string ToString()
        {

            string mensaje;
            mensaje = "Modelo: " + modelo + "\nColor: " + color + "\nAno: " + ano + "\nPuertas" + numPuertas + "\nTipo de combustible: " + combustible + "\nMotor: " + ccMotor + "\nAsientos" + asientos + "\nColor del tablero: " + colorTablero + "\nCamara trasera: " + camaraTrasera; 

            return mensaje;
            
        }
    }

}
