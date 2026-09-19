// Sistema Academico basico

/*El programa debe pedir al usuario, pedirle 4 notas y mostrar el litar correspondiente al primario (A)=>90 (B)>= 80 (C)>=70 (F)<= 70
Dale 2 opcion al usuario, Ver el literal y ver el promedio*/



int nota1, nota2, nota3, nota4, promedio, opcion_menu;

System.Console.WriteLine("Ingrese la nota 1 ");
nota1 = int.Parse (Console.ReadLine()!);

System.Console.WriteLine("Ingrese la nota 2 ");
nota2 = int.Parse (Console.ReadLine()!);

System.Console.WriteLine("Ingrese la nota 3 ");
nota3 = int.Parse (Console.ReadLine()!);

System.Console.WriteLine("Ingrese la nota 4 ");
nota4 = int.Parse (Console.ReadLine()!);

promedio = (nota1+nota2+nota3+nota4)/4;

Console.WriteLine("Elige una opciones ");
Console.WriteLine("1. Ver literal ");
Console.WriteLine("2. Ver promedio ");
opcion_menu = int.Parse(Console.ReadLine()!);

switch (opcion_menu)
{
    case 1:
    if (promedio >= 90)
        {
            System.Console.WriteLine($"A {promedio}, Felicidades! ");
            }
        else if (promedio >= 80)
        {
            System.Console.WriteLine($"B {promedio}, Felicidades! ");
        }
        else if(promedio >= 70)
        {
            System.Console.WriteLine($"C {promedio}, Felicidades! ");
        }
        else if(promedio < 70)
        {
            System.Console.WriteLine($"F {promedio}, Siguelo intentando! ");
        }
        break;
    
    case 2:
    
    System.Console.WriteLine($"Tu promedio es: {promedio}");
    break;

    default:
    System.Console.WriteLine("Opcion no valida ");
    break;

        
        
        
    
            
            
    


    
}
             
// 90+95+93+91/4


