namespace Seccion12_341
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable para controlar el bucle menu
            bool salir = false;



            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("--- Menu Principal --- \n" +
                                  "1. Ver productos\n" +
                                  "2. Agreagar producto\n" +
                                  "3. Salir");
                Console.Write("Escoge una opcion");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Mostrando productos ....");
                            break;

                        case 2:
                            Console.WriteLine("Agregando productos ....");
                            break;

                        case 3:
                            Console.WriteLine("Saliendo ....");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion fuera de rango");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida");

                }

                if (salir == false) // Si no se ha elegido salir 
                {
                    Console.WriteLine("\nPresiona cualquier tecla");
                    Console.ReadKey();
                }




                //while (salir == false)
                //{
                //    Console.Clear();
                //    Console.WriteLine("--- Menu Principal --- \n" +
                //                      "1. Ver productos\n" +
                //                      "2. Agreagar producto\n" +
                //                      "3. Salir");
                //    Console.Write("Escoge una opcion");

                //    try
                //    {
                //        // Intentamos convertir la entrada del usuario a un entero

                //        int opcion = Convert.ToInt32(Console.ReadLine());


                //        switch(opcion)
                //        {
                //            case 1:
                //                Console.WriteLine("Mostrando productos ....");
                //                break;

                //            case 2:
                //                Console.WriteLine("Agregando productos ....");
                //                break;

                //            case 3:
                //                Console.WriteLine("Saliendo ....");
                //                salir = true;
                //                break;
                //            default:
                //                Console.WriteLine("Opcion fuera de rango");
                //                break;
                //        }
                //    }

                //    catch(FormatException)
                //    {
                //        Console.WriteLine("Error: debes ingresar un numero valido");
                //    }

                //    catch (OverflowException)
                //    {
                //        Console.WriteLine("Error: debes ingresar un numero valido");
                //    }

                //    catch (Exception ex)
                //    {
                //        Console.WriteLine($"Error inesperado: {ex.Message} ");
                //    }

                //    if (salir == false) // Si no se ha elegido salir 
                //    {
                //        Console.WriteLine("\nPresiona cualquier tecla");
                //        Console.ReadKey();
                //    }


            }
        }
    }
}
