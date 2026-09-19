/*string[] nombres = new string[4];

nombres[0] = "Manuel";
nombres[1] = "Griss";
nombres[2] = "starling";

for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
}
*/


/*using System.Runtime.InteropServices;

int[] numeros = new int[3];

for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine("Ingresa un numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
} 

for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine(numeros[i]);
}

int suma = 0;

for (int i = 0; i < 3; i++)
{
    suma += numeros[i];
}

Console.WriteLine("Suma: " + suma);*/


/*int[] numeros = new int[3];

numeros[0] = 100;
numeros[1] = 200;
numeros[2] = 300;

System.Console.WriteLine(numeros[0]);
System.Console.WriteLine(numeros[1]);
System.Console.WriteLine(numeros[2]);*/

/*int[] numeros = new int[4];
int contador = 0;

for (int i = 0; i < 4; i++)
{
    System.Console.WriteLine("ingresa un numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);

    if (numeros[i] > 10)
    {
        contador++;
    }
}
System.Console.WriteLine("Numeros mayores que 10: " + contador);*/


/*int[] numeros = new int[5];

int positivos = 0;
int negativos = 0;

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Ingresa numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);

    if (numeros[i] > 0)
    {
        positivos ++;
    }
    else if (numeros[i] < 0)
    {
        negativos ++;
    }

}
System.Console.WriteLine("Cantidad de numeros positivos: " + positivos);
System.Console.WriteLine("Cantidad de numeros negativos: " + negativos);*/


/* Escribe un programa que:

Pregunte cuántos números se van a introducir.

Solicite esos números uno por uno.

Al final, muestre cuántos de esos números fueron negativos.*/

/*using System.Runtime.CompilerServices;

int numeros;
int Cantidad; 
int cantidadNegativa = 0;
int cantidadPositiva = 0;

System.Console.WriteLine("Cuantos numeros desea ingresar? ");
Cantidad = int.Parse(Console.ReadLine()!);

for (int i = 0; i < Cantidad; i++)
{
    System.Console.WriteLine("ingrese esos numeros: ");
    numeros = int.Parse(Console.ReadLine()!);
    

    if(numeros < 0)
    {
        cantidadNegativa++;
    }else if (numeros > 0)
    {
        cantidadPositiva++;


    }
    System.Console.WriteLine($"Numero utilizado: {numeros} ");
}
System.Console.WriteLine($"Cantidad de numeros negativos: {cantidadNegativa},  Cantidad de numeros positivos: {cantidadPositiva}.");*/





/*int num1, num2;
int mayor, menor;

System.Console.Write("ingresa el primer numero: ");
num1 = int.Parse(Console.ReadLine()!);
System.Console.Write("Ingresa el segundo numero: ");
num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    mayor = num1;
    menor = num2;

}
else
{
    mayor = num2;
    menor = num1;

}
    System.Console.WriteLine("Esta es tu secuencia:");
for(int i = mayor; i >= menor; i--)
{
    System.Console.WriteLine(i);
}*/


/*int num;

System.Console.WriteLine("Ingresa un numero ");
num = int.Parse(Console.ReadLine()!);

if (num > 10 && num % 2 != 0)
{
    for(int i= 100; i <= 500; i += 10)
    {
        System.Console.WriteLine(i);
    }

}
else if(num > 10 && num % 2 == 0)
{
    for(int i = 0; i < 5; i++)
    {
        System.Console.WriteLine("Hola ");
    }
}
else
{
    for(int i = 0; i < 15; i++)
    {
        System.Console.WriteLine("Manuel de los santos - 20251342");
    }
}*/

/*Guardar 5 números → arreglo
Sumarlos → acumulador (suma)
Mostrar resultado*/

/*int[] numeros = new int[5];
int suma = 0;

for (int i = 0; i < 5; i++)
{
    System.Console.Write("Ingresa numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);

}
for (int i = 0; i < 5; i++)
{
    suma += numeros[i];
}
System.Console.WriteLine($"La suma de los numero es: {suma} ")*/


/*using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[7];
        bool encontrado = false;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Ingrese número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);

            if (numeros[i] == 23)
            {
                encontrado = true;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("Hola!");
        }
        else
        {
            Console.WriteLine("Adiós!");
        }
    }
}*/


/*int[] numeros = new int[10];
int ContadorPares = 0;
int ContadorImpares = 0;

for (int i = 0; i < 10; i++)
{
    System.Console.Write("Ingresa numero: ");
    numeros[i] = int.Parse (Console.ReadLine()!);
    
    if (numeros[i] % 2 == 0)
    {
        ContadorPares++;
    }
    else
    {
        ContadorImpares++;
    }
}

System.Console.WriteLine($"Cantidad de numeros pares: {ContadorPares}, Cantidad de numeros impares: {ContadorImpares}.");*/


/*Programa de jose: Crear un programa que pida al usuario 10 numeros, 
almacene en un arreglo
y muestre los que son divisibles * 7 o que sean multiplos de 7*/

/*int[] Numeros = new int[10];

for(int i = 0; i < 10; i++)
{
    System.Console.Write("ingrese numero: ");
    Numeros[i] = int.Parse(Console.ReadLine()!);

}
System.Console.WriteLine("Numeros multiplos de 7:");

for (int i = 0; i < 10; i++)
{
     if(Numeros[i] % 7 == 0)
    {
        System.Console.WriteLine(Numeros[i]);
    }
}*/

/* Crear un programa que pida al usuario 1 palabra, esa palabra
la guardara en caracteres, luego mostrara por separado las vocales
y las consonantes*/

/*Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine()!.ToLower();

        Console.WriteLine("Vocales:");
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == 'a' || palabra[i] == 'e' || 
                palabra[i] == 'i' || palabra[i] == 'o' || 
                palabra[i] == 'u')
            {
                Console.WriteLine(palabra[i]);
            }
        }

        Console.WriteLine("Consonantes:");
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] != 'a' && palabra[i] != 'e' && 
                palabra[i] != 'i' && palabra[i] != 'o' && 
                palabra[i] != 'u')
            {
                Console.WriteLine(palabra[i]);
            }
        }*/

/*Crea un programa que pida al usuario 1 numero y determine si es capicua
(al reves) */

/*Console.Write("Ingrese un número: ");
        string numero = Console.ReadLine()!;

        string invertido = "";

        
        for (int i = numero.Length - 1; i >= 0; i--)
        {
            invertido += numero[i];
        }

        if (numero == invertido)
        {
            Console.WriteLine("Es capicua");
        }
        else
        {
            Console.WriteLine("No es capicua");
        }*/

/* crear un programa que pida al usuario el tamaño
de un arreglo de numeros enteros y luego llene el arreglo
con numeros aleatorios y muestre por pantalla
el numero mayor y en menor y el arreglo. */

/*int tamaño;

Console.Write("Ingrese el tamaño del arreglo: ");
tamaño = int.Parse(Console.ReadLine()!);

int[] numeros = new int[tamaño];
Random rnd = new Random();

for (int i = 0; i < tamaño; i++)
{
    numeros[i] = rnd.Next(0, 50); 
}

int mayor = numeros[0];
int menor = numeros[0];

for (int i = 0; i < tamaño; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("Arreglo:");
for (int i = 0; i < tamaño; i++)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine("\nMayor: " + mayor);
Console.WriteLine("Menor: " + menor);*/





/* Crear un programa que solicite al usuario 6 numeros lo almacene en el arreglo 1 y lo pase copiado al arreglo 2*/

/*int[] numeros = new int[6];

for (int i = 0; i < 6; i++)
{
    System.Console.WriteLine("ingrese numero: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

int[] numero2 = new int[6];

for (int i = 0; i < 6; i++)
{
    numero2[i] = numeros[i];
}
for (int i = 0; i < 6; i++)
{
    System.Console.WriteLine(numeros[i]);*/




/*static void MostrarSaludo()
{
    System.Console.WriteLine("Hola, estoy aprendiendo funciones ");
}
MostrarSaludo();*/

/*static void SaludarPersona(String nombre)
{
    System.Console.WriteLine($"Hola {nombre}");
}

SaludarPersona("Manuel");*/

/*static int Sumar (int a, int b)

{
    return a + b;
}

int resultado = Sumar(5, 3);
System.Console.WriteLine(resultado);*/


/*static int Mayor(int a, int b)
{
    if(a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
System.Console.WriteLine(Mayor(6,3));*/

/*string[] tareas = new string[100];
int contador = 0;

static void AgregarTareas(string[] tareas, ref int contador)
{
    System.Console.Write("Agrega una tarea: ");
    string tarea = Console.ReadLine()!;

    tareas[contador] = tarea;
    contador++;

    System.Console.WriteLine("Tarea agregada ");
}
static void VerTareas(string[] tareas, ref int contador)
{
    if (contador == 0)
    {
        System.Console.WriteLine("no hay tareas ");
        return;
    }
    for (int i = 0; i < contador; i++)
    {
        System.Console.WriteLine((i + 1) + ". " + tareas[i]);
    }
}

static void EliminarTarea(string[] tareas, ref int contador)
{
    Console.Write("Ingrese la posicion: ");
    int pos = int.Parse(Console.ReadLine()!) - 1;

    if (pos < 0 || pos >= contador)
    {
        Console.WriteLine("Posicion invalida");
        return;
    }

    for (int i = pos; i < contador - 1; i++)
    {
        tareas[i] = tareas[i + 1];
    }

    contador--;
    Console.WriteLine("Tarea eliminada");
}

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Agregar tarea");
    Console.WriteLine("2. Ver tareas");
    Console.WriteLine("3. Eliminar tarea");
    Console.WriteLine("4. Salir");

    Console.Write("Seleccione una opcion: ");
    int opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            AgregarTareas(tareas, ref contador);
            break;

        case 2:
            VerTareas(tareas, ref contador);
            break;

        case 3:
            EliminarTarea(tareas, ref contador);
            break;

        case 4:
            salir = true;
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
}*/



/* string[] titulo =  new string[100];
string[] fecha =  new string[100];
string[] descripcion =  new string[100];

int contador = 0;

static void AgregarEvento(String[] titulo, string[] fecha, string[] descripcion, ref int contador)
{
    System.Console.Write("Agrega un Titulo: ");
    titulo[contador] = Console.ReadLine()!;

    System.Console.Write("Agrega una Fecha: ");
    fecha[contador] = Console.ReadLine()!;

    System.Console.Write("Agrega una Descripcion: ");
    descripcion[contador] = Console.ReadLine()!;

    contador ++;


    System.Console.Write("Has agregado un evento exitosamente. ");

}

static void VerEventos(string[] titulo, string[] fecha, string[] descripcion, int contador)
{
    if(contador == 0)
    {
        System.Console.WriteLine("No hay eventos ");
        return;
    }

}
for(int i = 0; i < contador; i++)
{
    System.Console.WriteLine("\nEvento #" + (i+1));
    System.Console.WriteLine("Titulo:" + titulo[i]);
    System.Console.WriteLine("Fecha: " + fecha[i]);
    System.Console.WriteLine("Descripcion: " + descripcion[i]);
}

static void BuscarPorTitulo(string[] titulo, string[] fecha, string[] descripcion, int contador)
{
    Console.Write("Nombre del titulo: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < contador; i++)
    {
        if (titulo[i].ToLower().Contains(buscar.ToLower()))
        {
            Console.WriteLine("\nTitulo: " + titulo[i]);
            Console.WriteLine("Fecha: " + fecha[i]);
            Console.WriteLine("Descripcion: " + descripcion[i]);

            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("No se encontro ningun evento con ese titulo");
    }
}*/



/*
string[] NombreEstudiantes = new string[25];
int contador = 0;
bool salir = false;

static void AgregarNombre(string[] NombreEstudiante, ref int contador)
{
    System.Console.Write("Agregue el nombre del estudiante: ");
    NombreEstudiante[contador] = Console.ReadLine()!;

    System.Console.WriteLine("Has agregado un nombre ");

    contador++;
}

static void MostrarNombre(string[] NombreEstudiante, int contador)
{
    if(contador == 0)
    {
        System.Console.WriteLine("No hay estudiantes. ");
        return;
    }

for(int i = 0; i < contador; i++)
{
    System.Console.WriteLine((i + 1) + ". " + NombreEstudiante[i]);
}

}

static void BuscarNombre(string[] NombreEstudiante, int contador)
{
    System.Console.Write("Digite el nombre a buscar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for(int i = 0; i < contador; i++)
    {
        if(NombreEstudiante[i].ToLower() == buscar.ToLower())
        {
            System.Console.WriteLine("Encontrado en la posicion: " + i  );
            encontrado = true;
        }
        
    }
    if (!encontrado)
    {
        System.Console.WriteLine("Nombre no encontrado.");
    }

}

while (!salir)
{
    System.Console.WriteLine("==== MENU =====");

System.Console.WriteLine("1. Agregar Nombre del estudiante ");
System.Console.WriteLine("2. Mostrar nombre de estudiantes ");
System.Console.WriteLine("3. Buscar nombre de estudiante ");
System.Console.WriteLine("4. Salir ");

System.Console.Write("Ingrese una opcion: ");
int opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
    AgregarNombre(NombreEstudiantes, ref contador);
    break;

    case 2:
    MostrarNombre(NombreEstudiantes, contador);
    break;

    case 3:
    BuscarNombre(NombreEstudiantes, contador);
    break;
    
    case 4:
    salir = true;
        System.Console.WriteLine("Saliste del programa. ");
    break;

    default:
        System.Console.WriteLine("opcion no valida");
        break;
}
}*/


/*string[] Nombre = new string[100];
string[] Numero = new string[100];

int contador = 0;
bool salir = false;

static void AgregarContacto(string[] Nombre, string[] Numero, ref int contador)
{
    System.Console.Write("Ingresa un nombre: ");
    Nombre[contador] = Console.ReadLine()!;

    System.Console.Write("Ingresa tu numero: ");
    Numero[contador] = Console.ReadLine()!;

    System.Console.WriteLine("\nHas agregado tu nombre y numero correctamente. ");

    contador++;
}

static void MostrarContacto(string[] Nombre, string[] Numero, int contador)
{
    if(contador == 0)
    {
        System.Console.WriteLine("No existen contactos. ");
        return;
    }
    for(int i = 0; i < contador; i++)
    {
        System.Console.WriteLine($"{i + 1}. {Nombre[i]} - {Numero[i]}");
    }
}

static void BuscarContacto(string[] Nombre, string[] Numero, int contador)
{
    System.Console.Write("Ingrese el contacto a buscar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado =  false;


    for(int i = 0; i < contador; i++)
    {
        if(Nombre[i].ToLower() == buscar.ToLower())
        {
            System.Console.WriteLine("El contacto es:");
            System.Console.WriteLine("Nombre: " + Nombre[i]);
            System.Console.WriteLine("Numero: " + Numero[i]);
            encontrado = true;
        }
    }
    if (!encontrado)
    {
        System.Console.WriteLine("No encontrado ");
    }

  
}

static void EliminarContacto(string[] nombres, string[] telefonos, ref int contador)
{
    Console.Write("Ingrese la posicion a eliminar: ");
    int pos = int.Parse(Console.ReadLine()!) - 1;

    if (pos < 0 || pos >= contador)
    {
        Console.WriteLine("Posicion invalida");
        return;
    }

    for (int i = pos; i < contador - 1; i++)
    {
        nombres[i] = nombres[i + 1];
        telefonos[i] = telefonos[i + 1];
    }

    contador--;

    Console.WriteLine("Contacto eliminado");
}

while (!salir)
{
    System.Console.WriteLine("==== MENU ===");
    System.Console.WriteLine("1. Agregar ");
    System.Console.WriteLine("2. Mostrar ");
    System.Console.WriteLine("3. Buscar ");
    System.Console.WriteLine("4. Eliminar ");
    System.Console.WriteLine("5. Salir");

    System.Console.WriteLine("Seleccione un opcion. ");
    int opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            AgregarContacto(Nombre, Numero, ref contador);
            break;
        
        case 2:
            MostrarContacto(Nombre, Numero, contador);
            break;
        
        case 3:
            BuscarContacto(Nombre, Numero, contador );
            break;
        
        case 4:
            EliminarContacto(Nombre, Numero, ref contador);
            break;

        case 5:
            salir = true;
            System.Console.WriteLine("Saliendo del programa ");
            break;

        default:
            System.Console.WriteLine("Opcion no valida ");
            break;        
    }
}*/




/*string[] tarea = new string[50];
int contador = 0;
bool salir = false;

static void AgregarTarea(string[] tarea, ref int contador)
{
    System.Console.Write("Ingresa una tarea: ");
    tarea[contador] = Console.ReadLine()!;

    contador++;
}

static void VerTareas(String[] tarea, int contador)
{
    if(contador == 0)
    {
        System.Console.WriteLine("No existen tareas: ");
        return;
    }
    for(int i = 0; i < contador; i++)
    {
        System.Console.WriteLine($"{i + 1}. {tarea[i]}");
    }
}

static void EliminarTarea(String[] tarea, ref int contador)
{
    System.Console.Write("Que tarea desea eliminar: ");
    int posicion = int.Parse(Console.ReadLine()!) - 1;
    
    if(posicion < 0 || posicion >= contador)
    {
        System.Console.WriteLine("Posicion invalida ");
        return;
    }
    for(int i = posicion; i < contador - 1; i++)
    {
        tarea[i] = tarea[i + 1];

    }
    System.Console.WriteLine("Eliminaste correctamente una tarea ");
    contador --;


}

while (!salir)
{
    System.Console.WriteLine("==== MENU INTERACTIVO ==== ");

    System.Console.WriteLine("1 Agregar tarea ");
    System.Console.WriteLine("2. Ver todas las tareas ");
    System.Console.WriteLine("3. Eliminar una tarea ");
    System.Console.WriteLine("4. salir ");

    System.Console.WriteLine("ingresa una opcion ");
    int opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            AgregarTarea(tarea, ref contador);
            break;
        
        case 2:
            VerTareas(tarea, contador);
            break;
        
        case 3:
            EliminarTarea(tarea, ref contador);
            break;
        
        case 4:
            salir = true;
            System.Console.WriteLine("Saliendo del programa");
            break;
        
        default:
            System.Console.WriteLine("Opcion no valida ");
            break;
    }




}*/



/*System.Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine()!;

System.Console.Write("Cuantos productos comprara: ");
int cantidad = int.Parse(Console.ReadLine()!);

string[] NombreProducto = new string[cantidad];
double[] PrecioProducto = new double[cantidad];
int[] cantidades = new int[cantidad];
double[] subtotales = new double[cantidad];

double totalGeneral = 0;

for(int i = 0; i < cantidad; i++)
{
    System.Console.WriteLine($"Producto {i + 1}");

    System.Console.Write("Nombre: ");
    NombreProducto[i] = Console.ReadLine()!;

    System.Console.Write("Precio: ");
    PrecioProducto[i] = double.Parse(Console.ReadLine()!);

    System.Console.Write("Cantidades: ");
    cantidades[i] = int.Parse(Console.ReadLine()!);

    subtotales[i] = PrecioProducto[i] * cantidades[i];

    totalGeneral += subtotales[i];


}*/





/*Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine()!;

Console.Write("Cuantos productos desea comprar: ");
int n = int.Parse(Console.ReadLine()!);

// ARREGLOS
string[] nombres = new string[n];
double[] precios = new double[n];
int[] cantidades = new int[n];
double[] subtotales = new double[n];

double totalGeneral = 0;

// INGRESO DE DATOS
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nProducto {i + 1}");

    Console.Write("Nombre: ");
    nombres[i] = Console.ReadLine()!;

    Console.Write("Precio: ");
    precios[i] = double.Parse(Console.ReadLine()!);

    Console.Write("Cantidad: ");
    cantidades[i] = int.Parse(Console.ReadLine()!);

    // CALCULO POR PRODUCTO
    subtotales[i] = precios[i] * cantidades[i];

    totalGeneral += subtotales[i];
}

// CALCULOS
double ajuste;
double totalFinal;
string tipo;

if (totalGeneral > 5000)
{
    ajuste = totalGeneral * 0.10; // descuento
    totalFinal = totalGeneral - ajuste;
    tipo = "Descuento (10%)";
}
else
{
    ajuste = totalGeneral * 0.18; // impuesto
    totalFinal = totalGeneral + ajuste;
    tipo = "Impuesto (18%)";
}

// SALIDA
Console.WriteLine("\n===== FACTURA =====");
Console.WriteLine("Cliente: " + cliente);

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1}. {nombres[i]} - Precio: {precios[i]} - Cantidad: {cantidades[i]} - Subtotal: {subtotales[i]}");
}

Console.WriteLine("\nTotal general: " + totalGeneral);
Console.WriteLine(tipo + ": " + ajuste);
Console.WriteLine("Total final: " + totalFinal);

// MENSAJE FINAL
if (totalGeneral > 5000)
{
    Console.WriteLine("Cliente VIP 🎉");
}
else
{
    Console.WriteLine("Gracias por su compra 👍");
}*/





/*System.Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine()!;

System.Console.Write("Cuantos articulos desea comprar: ");
int CantArticulo = int.Parse(Console.ReadLine()!);

string[] NombreProd = new string[CantArticulo];
double[] PrecioProd = new double[CantArticulo];
int[] cantidades = new int[CantArticulo];
double[] subtotales = new double[CantArticulo];

double TotalGeneral = 0;


for(int i = 0; i < CantArticulo; i++)
{
    System.Console.WriteLine($"\nProducto {i + 1}");

    System.Console.Write("Nombre: ");
    NombreProd[i] = Console.ReadLine()!;

    System.Console.Write("Precio: ");
    PrecioProd[i] = double.Parse(Console.ReadLine()!);

    System.Console.Write("Cantidades: ");
    cantidades[i] = int.Parse(Console.ReadLine()!);

    subtotales[i] = PrecioProd[i] * cantidades[i];

    TotalGeneral += subtotales[i];

}

for(int i = 0; i < CantArticulo; i++)
{
    System.Console.WriteLine($"{i + 1}. {NombreProd[i]} - {PrecioProd[i]} - {cantidades[i]} - {subtotales[i]}  ");
}*/





