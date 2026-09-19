//perimetro y area

{
   Console.WriteLine("Ingresa la base:");
double baseRect = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ingresa la altura:");
double alturaRect = double.Parse(Console.ReadLine()!);

double area = baseRect * alturaRect;
double perimetro = baseRect + baseRect + alturaRect + alturaRect; 

Console.WriteLine("El area es: " + area);
Console.WriteLine("El perimetro es: " + perimetro);
}
