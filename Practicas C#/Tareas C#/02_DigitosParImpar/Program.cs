// Par o impar

int num, d1, d2; // Variables

        Console.Write("Digite un numero de 2 digitos: ");
        num = int.Parse(Console.ReadLine()!);

        // Sacamos los dígitos
        d1 = num / 10; // primer dígito
        d2 = num % 10; // segundo dígito

        // Revisamos si el primer dígito es par
        if (d1 % 2 == 0)
            Console.WriteLine("Primer digito par");
        else
            Console.WriteLine("Primer digito impar");

        // Revisamos segundo dígito
        if (d2 % 2 == 0)
            Console.WriteLine("Segundo digito par");
        else
            Console.WriteLine("Segundo digito impar");