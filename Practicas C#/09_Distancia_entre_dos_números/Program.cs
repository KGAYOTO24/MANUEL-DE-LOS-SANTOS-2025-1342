// Distancia entre dos números

{
    Console.WriteLine("Numero uno:");
double numA = double.Parse(Console.ReadLine()!);

Console.WriteLine("Numero dos:");
double numB = double.Parse(Console.ReadLine()!);


double dist = Math.Abs(numA - numB);
Console.WriteLine("La distancia entre ellos es de: " + dist);

Console.ReadKey();

}