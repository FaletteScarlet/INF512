using System;

class HolaMundo
{
    static void Main()
    {
        String matricula, nombre;

        Console.Write("\nMatrícula: ");
        matricula= Console.ReadLine();

        Console.Write("Nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("\n***Salida por Consola***\n");
        Console.WriteLine("Su nombre es: \t\t" + nombre);
        Console.WriteLine("Su matrícula es: \t" + matricula);
    }
}