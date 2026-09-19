// Suma par o impar

int a, b, suma;

        Console.Write("Numero 1: ");
        a = int.Parse(Console.ReadLine()!);

        Console.Write("Numero 2: ");
        b = int.Parse(Console.ReadLine()!);

        suma = a + b; // Sumamos

        // Verificamos si la suma es par
        if (suma % 2 == 0)
            Console.WriteLine("La suma es par");
        else
            Console.WriteLine("La suma es impar");
