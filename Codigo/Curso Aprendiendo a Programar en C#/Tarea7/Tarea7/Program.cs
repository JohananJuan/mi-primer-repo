using System.Globalization;

namespace Tarea7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variavbles
            double montoAr, saldoInicialAr;
            int opcion;
            string nombreAr, apellidosAr, direccionAr, rfcAr;

            // Aviso de nueva Cuenta
            Console.Write("Esta a punto de crear una nueva cuenta, por favor presione cualquier tecla para continuar:  ");
            Console.ReadKey();

            Console.WriteLine("\n\nIngrese la informacion que se le solicita a continuacion");

            Console.Write("\nNombre: ");
            nombreAr = Console.ReadLine();

            Console.Write("\nApellidos: ");
            apellidosAr = Console.ReadLine();

            Console.Write("\nDireccion: ");
            direccionAr = Console.ReadLine();

            Console.Write("\nRFC: ");
            rfcAr = Console.ReadLine();

            Console.Write("\nIngresa su deposito inicial: ");
            saldoInicialAr = Convert.ToDouble(Console.ReadLine());

            // Instanciamos la clase 
             CuentaBancaria cliente1 = new CuentaBancaria(nombreAr, apellidosAr, saldoInicialAr ,direccionAr, rfcAr);


            Console.Write("\nCuenta Creada");
            Console.ReadKey();

            Console.Clear();

            // Menu

            do
            {
                Console.WriteLine("\n1. Deposito\n" +
                                  "2. Retiro\n" +
                                  "3. Consultar Saldo \n" +
                                  "4. Mostrar infoprmacion de la cuenta\n" +
                                  "5. Salir");

                Console.Write("\nElija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)

                {

                    case 1:
                        Console.Write("Ingrese el monto a depositar: $");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Deposito(montoAr);

                        break;

                    case 2:
                        Console.Write("Ingrese el monto a retirar: ");
                        montoAr = Convert.ToDouble(Console.ReadLine());

                        cliente1.Retiro(montoAr);

                        break;

                    case 3:
                        cliente1.ConsultaSaldo();
                        break;

                    case 4: 
                        Console.WriteLine(cliente1.ToString());
                        break;

                }


            } while (opcion >= 1 && opcion <= 4);



        }
    }

    class CuentaBancaria
    {
        // Campos
        private string nombre, apellidos, direccion, rfc;
        private double saldo; 

        // Constructor
        public CuentaBancaria(string nombrePa, string apellidoPa, double saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellidos = apellidoPa;
            saldo = saldoPa;
            direccion = direccionPa;
            rfc = rfcPa;
        }

        // Metodos
        public double Deposito(double montaPa)
        {
            saldo += montaPa;
            return saldo;
        }


        public double Retiro(double montaPa)
        {
            if ( saldo >= montaPa)
            {
                saldo -= montaPa;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
            return saldo;
        }

        public void ConsultaSaldo()
        {
            Console.WriteLine($"\nTu saldo es {saldo}");
        }


        public override string ToString()
        {
            string mensaje;
            mensaje = "\nTitular: " + nombre + " " + apellidos + "\nRfc: " + rfc + "\nDireccion: " + direccion + "\nSaldo: $" + saldo;

            return mensaje;
        }



    }

}
