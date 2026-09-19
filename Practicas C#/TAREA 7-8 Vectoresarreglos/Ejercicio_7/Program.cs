// Ejercicio 7 Copiar arreglo multiplicando posiciones pares

 int[] arreglo1 = new int[5];
        int[] arreglo2 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un número: ");
            arreglo1[i] = int.Parse(Console.ReadLine()!);

            if (i % 2 == 0)
            {
                arreglo2[i] = arreglo1[i] * 10;
            }
            else
            {
                arreglo2[i] = arreglo1[i];
            }
        }

        Console.WriteLine("Contenido del segundo arreglo:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arreglo2[i]);
        }
