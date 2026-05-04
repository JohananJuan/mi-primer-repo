        // Variablles
        string contrasena1, contrasena2 = "";
        ulong i = 3;


        Console.Write("Por favor, digite su contrasena: ");
        contrasena1 = Convert.ToString(Console.ReadLine());


        while (contrasena1 != contrasena2 && i > 0)
                    {
            Console.Write("\nConfirma tu contrasena: ");
            contrasena2 = Convert.ToString(Console.ReadLine());
            
            
            Console.Write("\nTe quedan {0} intentos", i);


            i--;

        }

        Console.Write("\nTu contrasena se ha registrado");
