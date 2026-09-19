//EJERCICIO 5 - DO WHILE Secuencia descendente hasta 0

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine()!);

do
{
    Console.WriteLine(numero);
    numero--;
}
while (numero >= 0);