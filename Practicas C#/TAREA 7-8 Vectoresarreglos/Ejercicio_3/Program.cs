//Ejercicio 3 Condiciones según el número

int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine()!);

        if (numero > 10 && numero % 2 != 0)
        {
            Console.WriteLine("Secuencia del 100 al 500 de 10 en 10:");

            for (int i = 100; i <= 500; i += 10)
            {
                Console.WriteLine(i);
            }
        }
        else if (numero > 10 && numero % 2 == 0)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("¡Hola! Bienvenido.");
            }
        }
        else
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Manuel - Matrícula: 20251342"); }
            }
