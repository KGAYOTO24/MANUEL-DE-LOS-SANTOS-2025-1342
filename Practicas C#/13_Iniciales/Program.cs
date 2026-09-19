// Iniciales

{
    Console.WriteLine("¿Cual es tu nombre?");
string n = Console.ReadLine()!;
Console.WriteLine("¿Primer apellido?");
string p1 = Console.ReadLine()!;
Console.WriteLine("¿Segundo apellido?");
string p2 = Console.ReadLine()!;


string iniciales = n[0] + "" + p1[0] + "" + p2[0];
Console.WriteLine("Tus iniciales son: " + iniciales.ToUpper());


    Console.ReadKey();
}
