// Intercambiar variables

{

 Console.WriteLine("Escribe el valor de A:");
 string varA = Console.ReadLine()!;
 Console.WriteLine("Escribe el valor de B:");
 string varB = Console.ReadLine()!;


 string temporal = varA;
 varA = varB;
 varB = temporal;

 Console.WriteLine("Ahora A vale: " + varA);
 Console.WriteLine("Ahora B vale: " + varB);   

Console.ReadKey();

}