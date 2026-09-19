//Suma de digitos

int num, d1, d2, suma;

        Console.Write("Digite un numero de 2 digitos: ");
        num = int.Parse(Console.ReadLine()!);

        // Separar dígitos
        d1 = num / 10;
        d2 = num % 10;

        // Sumarlos
        suma = d1 + d2;

        Console.WriteLine("La suma es: " + suma);
