// Raíz Cuadrada y Cúbica

{
    
    Console.WriteLine("Introduce un numero:");
double valor = double.Parse(Console.ReadLine()!);

double rCuadrada = Math.Sqrt(valor);

double rCubica = Math.Pow(valor, 1.0 / 3.0);

Console.WriteLine("Raiz cuadrada: " + rCuadrada);
Console.WriteLine("Raiz cubica: " + rCubica);

}