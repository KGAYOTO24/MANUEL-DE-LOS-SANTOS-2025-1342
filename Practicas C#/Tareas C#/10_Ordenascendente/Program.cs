// Orden ascendente

 int a, b, c, temp;

        Console.Write("Numero 1: ");
        a = int.Parse(Console.ReadLine()!);

        Console.Write("Numero 2: ");
        b = int.Parse(Console.ReadLine()!);

        Console.Write("Numero 3: ");
        c = int.Parse(Console.ReadLine()!);

        // Ordenamos usando intercambios
        if (a > b) { temp = a; a = b; b = temp; }
        if (a > c) { temp = a; a = c; c = temp; }
        if (b > c) { temp = b; b = c; c = temp; }

        Console.WriteLine("Orden: " + a + " " + b + " " + c);