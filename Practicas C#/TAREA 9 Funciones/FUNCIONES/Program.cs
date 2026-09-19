using System;

class Program
{
    static void Main()
    {
        // Ejercicio 1
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine()!;
        Console.WriteLine(SaludoPersonalizado(nombre!));

        Console.WriteLine();

        // Ejercicio 2
        Console.Write("Ingrese un número de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine("El último dígito es: " + UltimoDigito(numero));

        Console.WriteLine();

        // Ejercicio 3
        Console.Write("Ingrese un número entero: ");
        int numero2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine(ParOImpar(numero2));

        Console.WriteLine();

        // Ejercicio 4
        Console.Write("Ingrese un número de dos dígitos: ");
        int numero3 = int.Parse(Console.ReadLine()!);
        TablaMultiplicar(numero3);

        Console.WriteLine();

        // Ejercicio 5
        Console.Write("Ingrese un número de dos dígitos: ");
        int numero4 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("El mayor dígito es: " + MayorDigito(numero4));
    }

    
    // Ejercicio 1: Saludo personalizado
    
    static string SaludoPersonalizado(string nombre)
    {
        return "Hola " + nombre + ", ¡bienvenido!";
    }

    
    // Ejercicio 2: Último dígito de un entero
    
    static int UltimoDigito(int numero)
    {
        return numero % 10;
    }

    
    // Ejercicio 3: Par o impar
    
    static string ParOImpar(int numero)
    {
        if (numero % 2 == 0)
        {
            return "El número es PAR";
        }
        else
        {
            return "El número es IMPAR";
        }
    }

   
    // Ejercicio 4: Tabla de multiplicar
   
    static void TablaMultiplicar(int numero)
    {
        int primerDigito = numero / 10;
        int segundoDigito = numero % 10;

        Console.WriteLine("Tabla del " + primerDigito);

        for (int i = 1; i <= segundoDigito; i++)
        {
            Console.WriteLine(primerDigito + " x " + i + " = " + (primerDigito * i));
        }
    }

    
    // Ejercicio 5: Mayor dígito
   
    static int MayorDigito(int numero)
    {
        int primerDigito = numero / 10;
        int segundoDigito = numero % 10;

        if (primerDigito > segundoDigito)
        {
            return primerDigito;
        }
        else
        {
            return segundoDigito;
        }
    }
}
