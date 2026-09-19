// Primero es igual al ultimo

int num, primero, ultimo;

    Console.WriteLine("ingrese los 3 digitos ");
    num = int.Parse(Console.ReadLine()!);

// obligamos al usuario a colocar los 3
if(num.ToString().Length == 3)
{
    primero = num / 100;
    ultimo = num % 10;

// Comparamos
if (primero == ultimo)
            Console.WriteLine("Son iguales ");
        else
            Console.WriteLine("Son diferentes "); 
}
// si el usuario no coloca los 3 digitos principales
else
{
    Console.WriteLine("EL numero ingresado no tiene 3 digitos");
}
       