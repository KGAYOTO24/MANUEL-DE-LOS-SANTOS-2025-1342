/* EJERCICIO 3 - DO WHILE Mostrar números impares del 1 al 100*/

int i = 1;

do
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }

    i++;
}
while (i <= 100);