using System;
using System.IO;

class Program
{
    static string[] estudiantes = new string[]
    {
        "Anthony Montero",
        "Isidro Yarol Reyes Hidalgo",
        "Michael Jose Perez Reyes",
        "Xavier Capellan",
        "Anderson Junior Hernndez Ramrez",
        "Dalvin Vsquez",
        "Randolf Isa Medina Espinosa",
        "Yarilyn Idelky Mancebo Mesa",
        "Edwis Antonio Jimenez Mercedes",
        "Manuel Starling De Los Santos Castro",
        "Jose Ignacio Carmona De Leon",
        "Yeider Jhoser Poche Rosario",
        "Maximo Andres Coco",
        "Axel Joel Silvestre De Los Santos",
        "Johncarlos Ramirez Pimentel",
        "Francis Miguel Jimnez Polanco",
        "Alam Alexander Fernandez Reyes",
        "Alexander Daniel Baez Garcia",
        "Randy Mescain Martinez",
        "Miguel Angel Checo Reyes"
    };

    static int cantidadEstudiantes = 20;

    static string desarrollador = "";
    static string facilitador = "";

    static Random random = new Random();

    static void Main()
    {
        Menu();
    }

    
    static void Menu()
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====================================");
            Console.WriteLine("  SELECCION RANDOM");
            Console.WriteLine("=====================================");
            Console.ResetColor();

            Console.WriteLine("1. Nueva selección");
            Console.WriteLine("2. Ver última selección");
            Console.WriteLine("3. Ver historial");
            Console.WriteLine("4. Salir");

            Console.Write("\nSeleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Entrada invalida.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    NuevaSeleccion();
                    break;

                case 2:
                    VerSeleccion();
                    break;

                case 3:
                    VerHistorial();
                    break;

                case 4:
                    if (!ConfirmarSalida())
                    {
                        opcion = 0;
                    }
                    break;

                default:
                    Console.WriteLine(" Opción incorrecta.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 4);
    }

    
    static void NuevaSeleccion()
    {
        if (cantidadEstudiantes < 2)
        {
            Console.WriteLine("no hay suficientes estudiantes.");
            Console.ReadKey();
            return;
        }

        int index1 = random.Next(cantidadEstudiantes);
        int index2;

        do
        {
            index2 = random.Next(cantidadEstudiantes);
        }
        while (index1 == index2);

        desarrollador = estudiantes[index1];
        facilitador = estudiantes[index2];

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=====================================");
        Console.WriteLine(" RESULTADO DE LA SELECCIÓN ");
        Console.WriteLine("=====================================");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n desarrollador en vivo:");
        Console.WriteLine("➡ " + desarrollador);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n facilitador del ejercicio:");
        Console.WriteLine("➡ " + facilitador);

        Console.ResetColor();

        GuardarHistorial();

        Console.ReadKey();
    }

    
    static void VerSeleccion()
    {
        Console.Clear();

        if (string.IsNullOrEmpty(desarrollador))
        {
            Console.WriteLine("no hay selecciones aun.");
        }
        else
        {
            Console.WriteLine("ultima selección:\n");
            Console.WriteLine("desarrollador: " + desarrollador);
            Console.WriteLine("facilitador: " + facilitador);
        }

        Console.ReadKey();
    }

    
    static void GuardarHistorial()
    {
        string linea = desarrollador + "," + facilitador + "," + DateTime.Now;

        File.AppendAllText("historial.txt", linea + Environment.NewLine);
    }

   
    static void VerHistorial()
    {
        Console.Clear();

        if (!File.Exists("historial.txt"))
        {
            Console.WriteLine(" no hay historial disponible.");
        }
        else
        {
            Console.WriteLine(" HISTORIAL:\n");
            Console.WriteLine(File.ReadAllText("historial.txt"));
        }

        Console.ReadKey();
    }

    
    static bool ConfirmarSalida()
    {
        Console.Write("¿Seguro que desea salir? (S/N): ");
        string respuesta = Console.ReadLine()!.ToUpper();

        return respuesta == "S";
    }
}
