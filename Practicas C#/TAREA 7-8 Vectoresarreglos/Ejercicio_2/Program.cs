//Ejercicio 2 secuencia descendente entre dos números

int num1, num2;
        int mayor, menor;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine()!);

        if (num1 > num2)
        {
            mayor = num1;
            menor = num2;
        }
        else
        {
            mayor = num2;
            menor = num1;
        }

        Console.WriteLine("Secuencia descendente:");

        for (int i = mayor; i >= menor; i--)
        {
            Console.WriteLine(i);
        }