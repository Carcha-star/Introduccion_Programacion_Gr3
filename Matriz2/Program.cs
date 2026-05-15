
        int[] numeros = { 123, 456, 789, 123, 555, 1234, 999, 456, 777 };

        Console.WriteLine("=== BUSCADOR DE NUMEROS ===");
        Console.WriteLine("Lista de numeros: 123, 456, 789, 123, 555, 1234, 999, 456, 777");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Ingresa un numero para buscar: ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int numeroBuscar))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Ingresa solo numeros!");
                Console.ResetColor();
                Console.WriteLine();
                continue;
            }

            int encontrados = 0;
            bool primerEncontrado = false;

            Console.WriteLine("\n--- RESULTADOS ---");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscar)
                {
                    encontrados++;

                    if (encontrados == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" POSICION {i + 1}: {numeros[i]}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($" POSICION {i + 1}: {numeros[i]}");
                    }
                }
            }
            if (encontrados == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Registro no encontrado");
            }

            Console.ResetColor();
            Console.WriteLine("\n-------------------");
            Console.Write("Buscar otro? (s/n): ");
            
            if (Console.ReadLine().ToLower() != "s")
                break;

            Console.WriteLine();
        }