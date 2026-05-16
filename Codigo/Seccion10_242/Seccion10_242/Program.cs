using System.Runtime.InteropServices;

namespace Seccion10_242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a la estructura
            Tranferencia transferencia1 = new Tranferencia();
            transferencia1.fecha = DateTime.Now;
            transferencia1.monto = 1800;
            transferencia1.destinatario = "Jose Enrique";
            transferencia1.numeroCuenta = "133011133008";
            transferencia1.concepto = "Pago del prestamo";

            Console.WriteLine(transferencia1.ToString());

        }
    }

    struct Tranferencia
    {
        // Campos
        public DateTime fecha;
        public double monto;
        public string destinatario;
        public string numeroCuenta;
        public string concepto;

        public override string ToString()
        {
            string mensaje;

            mensaje = $"Feha:{fecha.ToString()} \nMonto: ${monto} \nDestinatario: {destinatario} \nNumero de cuenta: {numeroCuenta} \nConcepto: {concepto} ";
            return mensaje;
        }
    }
}
