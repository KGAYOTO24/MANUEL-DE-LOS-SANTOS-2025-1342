// Minutos a Horas y Minutos

{
    Console.WriteLine("¿Cuantos minutos quieres convertir?");
int totalMins = int.Parse(Console.ReadLine()!);

int h = totalMins / 60; 
int m = totalMins % 60; // 

Console.WriteLine(totalMins + " minutos son " + h + " horas y " + m + " minutos");
}