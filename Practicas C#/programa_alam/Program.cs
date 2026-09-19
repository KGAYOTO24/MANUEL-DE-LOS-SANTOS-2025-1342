/* Crear un programa que pida al usuario, una cotraseña (contraseña 1234), 
el usuario tiene 3 intentos para colocar la contraseña en caso de que se agoten los 3 intentos
el programa mostrara acceso denegado, en el caso de que la contraseña sea correcta, que aparezca
Bienvenido al programa.*/

string contraseñaCorrecta = "1234";
        string contraseñaUsuario;

        int intentos = 3;

        while (intentos > 0)
        {
            Console.Write("Ingresa la contraseña: ");
            contraseñaUsuario = Console.ReadLine()!;

            if (contraseñaUsuario == contraseñaCorrecta)
            {
                Console.WriteLine("Bienvenido al programa");
                break;
            }
            else
            {
                intentos--;
                Console.WriteLine("Contraseña incorrecta. Intentos restantes: " + intentos);
            }
        }

        if (intentos == 0)
        {
            Console.WriteLine("Acceso denegado");
        }