using System.Net.Http.Headers;

namespace Seccio7Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            string nombreAr, apellidoAr, nip;

            Console.WriteLine("\t\t Bienvenido a MonsterInc.");
            Console.WriteLine("\tIngrese los siguientes campos que se le solicitan \n");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("Digite su nip para asignarlo a su tarjeta baancaria: ");
            nip = Console.ReadLine();

            // Instanciamos a la clase Empleado
            Empleado empleado1 = new Empleado (nombreAr, apellidoAr);

            empleado1.Nip = nip;

            // Mostrar la informacion de nustro objeto
            Console.WriteLine(empleado1.ToString());

        }
    }

    class Empleado
    {
        // Campos
        private string nombre, apellido, id, locker, banco, nip;

        // Constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            // Llamamos a los metodos para  generar los numeros aleatorios 
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignarBanco();

        }

        //Instanciamos a Random
        Random random = new Random();

        // Propiedades
        public string Nip
        {
            set => nip = value;
        }

        // Metodos
        private string GenerarID()
        {


            // Variables
            int i, numero;
            string id = " ";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {


            // Variables
            int i, numero;
            string locker = " ";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);

                locker += numero.ToString();
            }
            return locker;
        }




        private string AsignarBanco()
        {


            // Variables
            int asignarBanco;
            string banco = " ";

            asignarBanco = random.Next(1, 3);

            switch(asignarBanco)
            {
                case 1:
                    banco = " Santander";
                    break;
                case 2:
                    banco += " BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = " ";


            mensaje = "Empleado: " + nombre + " " + apellido + " " + "\nNumero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

            return mensaje;
        }
    }
}
