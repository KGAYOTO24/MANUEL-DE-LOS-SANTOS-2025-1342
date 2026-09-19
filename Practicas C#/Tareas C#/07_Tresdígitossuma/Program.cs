// tres digitos suma
int num, d1, d2, d3, suma;

        Console.Write("Digite numero de 3 digitos: ");
        num = int.Parse(Console.ReadLine()!);

        // Verificamos que tenga 3 dígitos
        if (num >= 100 && num <= 999)
        {
            d1 = num / 100;
            d2 = (num / 10) % 10;
            d3 = num % 10;

            suma = d1 + d2 + d3;

            Console.WriteLine("La suma es: " + suma);
        }
        else
        
            Console.WriteLine("No tiene 3 digitos");
