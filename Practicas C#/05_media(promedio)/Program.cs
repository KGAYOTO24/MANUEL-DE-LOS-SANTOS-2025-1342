// Media de tres números

{
    Console.WriteLine("Dime el primer numero:");
double a = double.Parse(Console.ReadLine()!);

Console.WriteLine("Dime el segundo numero:");
double b = double.Parse(Console.ReadLine()!);

Console.WriteLine("Dime el tercer numero:");
double c = double.Parse(Console.ReadLine()!);

double promedio = (a + b + c) / 3;
Console.WriteLine("El promedio de los tres es: " + promedio);

Console.ReadKey();

}