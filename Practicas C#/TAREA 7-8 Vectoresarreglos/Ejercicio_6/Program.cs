//Ejercicio 6 Contar pares e impares

int[] numeros = new int[10];
        int pares = 0;
        int impares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);

            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine("Cantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);
    
