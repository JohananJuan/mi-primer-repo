namespace Tarea8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias 
            int opcion;
            string nombre;
            long numero;

            // Instancia de la coleccion 
            Dictionary<string, long> contactos = new Dictionary<string, long>();

            do
            {
                Console.Clear();

                // Menu
                Console.WriteLine("1. Agregar contacto\n" +
                                  "2. Buscar contacto\n" +
                                  "3. Eliminar contacto\n" +
                                  "4. Mostrar contacto\n");
                                  "5. Actuzalizar Contacto\n");
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();


                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();

                        Console.Write("Numero: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        contactos.Add(nombre, numero);
                        Console.WriteLine($"\n{nombre} se ha agregado con exito ");

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.Write("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine($"\nContacto encontrado!");
                            Console.WriteLine($"{nombre}:{contactos[nombre]}");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine($"\nContacto no existe");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Write("Contacto a eliminar: ");
                        nombre = Console.ReadLine();


                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);

                            Console.WriteLine($"\n {nombre} se ha eliminado con exito");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine($"\nContacto no existe");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();
                        }

                        break;

                    case 4:
                        Console.WriteLine($"Contactos en tu agenda: \n");

                        foreach (KeyValuePair<string, long> elemento in contactos)
                        {
                            Console.WriteLine($"{elemento.Key}: {elemento.Value} ");
                        }


                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                        Console.ReadKey();

                        break;

                    case 5:
                        Console.WriteLine("Actualizar el contacto (escribir nombre) : \n");
                        nombre = Console.ReadLine ();
                        
                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\n Escribir el nuevo numero: ");
                            numero = Convert.ToInt32 (Console.ReadLine());

                            contactos[nombre] = numero; //Acctualizamos el value del contacto que sobreescribimos

                            Console.WriteLine("Informacion Actualizada!");
                            Console.WriteLine($"{nombre}: {contactos[nombre]}");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();
                            

                        }
                        else
                        {
                            Console.WriteLine($"\nContacto no existe");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                            Console.ReadKey();
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu ");
                        Console.ReadKey();

                        break;
                }

            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
