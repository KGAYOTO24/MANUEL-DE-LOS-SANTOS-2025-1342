//Mayor de dos numeros

int a, b;

        Console.Write("Digite numero 1: ");
        a = int.Parse(Console.ReadLine()!);

        Console.Write("Digite numero 2: ");
        b = int.Parse(Console.ReadLine()!);

        // Comparamos
        if (a > b)
            Console.WriteLine("El mayor es " + a);
        else
            Console.WriteLine("El mayor es " + b);

