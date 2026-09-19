// Programa que simula una calculadora

using System;

class Programa
{
    static void Main()
    {
        int num1, num2;
        string operacion;
        int resultado = 0;

        Console.Write("inserta el primer numero: ");
        num1 = int.Parse(Console.ReadLine()!);

        Console.Write("inserta el segundo numero: ");
        num2 = int.Parse(Console.ReadLine()!);

        Console.Write("inserta la operacion que quieres realizar (+, -, *, /): ");
        operacion = Console.ReadLine()!;

        if (operacion == "+")
        {
            resultado = num1 + num2;
        }
        else if (operacion == "-")
        {
            resultado = num1 - num2;
        }
        else if (operacion == "*")
        {
            resultado = num1 * num2;
        }
        else if (operacion == "/")
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("no puedes dividir entre 0");
                return;
            }
        }
        else
        {
            Console.WriteLine("operacion no valida");
            return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
//MANUEL STARLING DE LOS SANTOS CASTRO