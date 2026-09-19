//EJERCICIO 7 - WHILE Secuencia entre dos números

Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    while (num1 >= num2)
    {
        Console.WriteLine(num1);
        num1--;
    }
}
else
{
    while (num1 <= num2)
    {
        Console.WriteLine(num1);
        num1++;
    }
}