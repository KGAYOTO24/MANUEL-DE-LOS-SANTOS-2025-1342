// Ejercicio 5 Buscar si existe el número 23

int[] numeros = new int[7];
        bool encontrado = false;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Ingrese un número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);

            if (numeros[i] == 23)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("¡Hola! Encontramos el número 23.");
        }
        else
        {
            Console.WriteLine("No se encontró el número 23. Hasta luego.");
        }