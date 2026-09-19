
using System.Collections;

bool salir = false;

while(!salir)
System.Console.WriteLine(" === Menu === ");
System.Console.WriteLine("1. Ver listado general de estudiantes. ");
System.Console.WriteLine("2. Ver estadisticas del grupo. ");
System.Console.WriteLine("3. Buscar estudiante por nombre");
System.Console.WriteLine("4. Ver estudiantes por condicion");
System.Console.WriteLine("5. Salir");

System.Console.Write("Elige una opcion: ");
int opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
    RegistrarDatos(nombre)
    break;

    case 2:
    break;

    case 3:
    break;

    case 4:
    break;

    case 5:
        salir = true;
    break;
    
    
}



static void RegistrarDatos(String[] NombreEstudiante, int[] calificacionEstudiante, int cantidadEstudiante)

{
    for (int i = 0; i < cantidadEstudiante; i++)

    System.Console.Write("Cuantos estudiantes quiere ingresar: ");
    cantidadEstudiante = int.Parse(Console.ReadLine()!);

    System.Console.Write("Nombre del estudiante: ");
    NombreEstudiante[cantidadEstudiante] = Console.ReadLine()!;

    System.Console.WriteLine("Ingresa calificacion ");
    calificacionEstudiante[cantidadEstudiante] = int.Parse(Console.ReadLine()!);


}
static void MostrarDatos(String[] NombreEstudiante, int[] calificacionEstudiante, int cantidadEstudiante)
{
    
    for(int i = 0; i < cantidadEstudiante; i++)

    {
        System.Console.WriteLine($"Nombre del estudiante: {NombreEstudiante[i]}");
        System.Console.WriteLine($"calificacion: {calificacionEstudiante}");

        if(calificacionEstudiante[i] > 70)
        {
            System.Console.WriteLine("Estado: Aprobado ");
        }
        else
        {
            System.Console.WriteLine("Estado: Repobrado ");
        }
    }

}
static void EstadisticaGrupo(string[] nombreEstudiante, int[] Calificaciones, int cantidadEstudiante)
{
    int promedio = 0;

    for(int i = 0; i < cantidadEstudiante; i++);
    promedio = Calificaciones[cantidadEstudiante];

    if(promedio > Calificaciones[cantidadEstudiante])
    {
        System.Console.WriteLine("Es mayor ");
    }
    else
    {
        System.Console.WriteLine("Es menor");
    }
    System.Console.WriteLine($"Nombre del estudiante {nombreEstudiante[cantidadEstudiante]} - calificacion {Calificaciones[cantidadEstudiante]}");


        
    
}


static void BuscarEstudiante(String[] nombreEstudiante, int[] calificaciones, int cantidadEstudiante)
{
    string buscar;

    System.Console.Write("Que estudiante quiere buscar: ");
    buscar = Console.ReadLine()!;

    for(int i = 0; i < cantidadEstudiante; i++)

    if(nombreEstudiante[cantidadEstudiante].ToLower() == buscar.ToLower())
    {
        System.Console.WriteLine($"Nombre del estudiante {nombreEstudiante[i]} - Calificacion {calificaciones[i]} ");
    }

}




