//ejercicio 1 cantidad de numeros negativos

int cantidad;
        int numero;
        int negativos = 0;

        Console.Write("¿Cuántos números desea introducir?: ");
        cantidad = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            numero = int.Parse(Console.ReadLine()!);

            if (numero < 0)
            {
                negativos++;
            }
        }

        Console.WriteLine("Cantidad de números negativos: " + negativos);
    