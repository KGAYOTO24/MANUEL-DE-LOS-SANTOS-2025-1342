// Fahrenheit a Celsius.

{
    Console.WriteLine("Pon los grados Fahrenheit:");

    double fahr = double.Parse(Console.ReadLine());

    double celsius = (fahr - 32) * 5 / 9;
    Console.WriteLine("En grados Celsius son: " + celsius);

    Console.ReadKey();

}