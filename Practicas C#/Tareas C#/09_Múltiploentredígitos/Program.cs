// multiplo entre digitos
{
    int num, d1, d2;

    Console.WriteLine("escriba el numero de 2 digitos ");
    num = int.Parse(Console.ReadLine()!);

    d1 = num / 10;
    d2 = num % 10;

    // verificamos multiplos

    if (d1 % d2 == 0 || d2 % d1 == 0)
        Console.WriteLine("el numero es multiplo del otro ");
        else
        Console.WriteLine("no son miltiplos ");
}        
