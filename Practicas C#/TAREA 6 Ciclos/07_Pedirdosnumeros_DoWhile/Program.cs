// EJERCICIO 7 - DO WHILE Secuencia entre dos números

Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    do
    {
        Console.WriteLine(num1);
        num1--;
    }
    while (num1 >= num2);
}
else
{
    do
    {
        Console.WriteLine(num1);
        num1++;
    }
    while (num1 <= num2);
}