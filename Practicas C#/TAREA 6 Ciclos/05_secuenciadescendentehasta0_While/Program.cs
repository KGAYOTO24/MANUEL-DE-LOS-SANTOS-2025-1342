// EJERCICIO 5 - WHILE  Secuencia descendente hasta 0

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine()!);

while (numero >= 0)
{
    Console.WriteLine(numero);
    numero--;
}