// Descuento del 15%

{

    Console.WriteLine("Total de la cuenta:");
double precioOriginal = double.Parse(Console.ReadLine()!);

double ahorro = precioOriginal * 0.15;
double precioFinal = precioOriginal - ahorro;

Console.WriteLine("El descuento es de: " + ahorro);
Console.WriteLine("Al final pagas: " + precioFinal);

Console.ReadKey();

}