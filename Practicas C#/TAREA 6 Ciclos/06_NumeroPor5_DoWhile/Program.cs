// EJERCICIO 6 - DO WHILE Multiplicar por 5

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine()!);

int resultado = numero * 5;

if (numero % 2 == 0)
{
    do
    {
        Console.WriteLine(numero);
        numero++;
    }
    while (numero <= resultado);
}
else
{
    do
    {
        Console.WriteLine(resultado);
        resultado--;
    }
    while (resultado >= numero);
}