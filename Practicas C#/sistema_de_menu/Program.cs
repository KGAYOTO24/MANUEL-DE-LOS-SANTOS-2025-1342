/* Realiza un programa en C# que simule un sistema de menú.

El programa debe solicitar el nombre del usuario y mostrar un menú con varias opciones.

El usuario podrá elegir opciones que sumen los puntos que desee o resten los puntos que desee a una variable acumuladora.

El sistema debe repetirse hasta que el usuario decida salir.

Al final, el programa debe mostrar el nombre del usuario y el total de puntos obtenidos.
*/

System.Console.Write("Ingresa tu nombre: ");
string nombre = Console.ReadLine()!;

int puntos = 0;
int opcion;

do
{
    System.Console.WriteLine("\n ==== MENU =====");
    System.Console.WriteLine("1. Sumar 20 ");
    System.Console.WriteLine("2. Restar 15 ");
    System.Console.WriteLine("3. ver puntos acumulados ");
    System.Console.WriteLine("4. Salir ");

    opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            puntos += 20;
            System.Console.WriteLine("sumaste 10 puntos ");
            break;

            case 2:
            puntos -= 15;
            System.Console.WriteLine("restaste 15 puntos ");
            break;

            case 3:
            System.Console.WriteLine($"Los puntos que has acumulado son: {puntos} ");
            break;

            case 4:
            System.Console.WriteLine($"{nombre}, Has decidido salir. Hasta luego! ");
            break;

            default:
            System.Console.WriteLine("caracter no valido ");
            break;


    }
}while (opcion != 4);

System.Console.WriteLine("\n ====== Resultado Final ==== ");
System.Console.WriteLine($"Jugador: {nombre}" );
System.Console.WriteLine($"puntos acumulados: {puntos} ");