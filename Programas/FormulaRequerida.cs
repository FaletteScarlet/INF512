//FormulaRequerida.cs

using System;

class FormulaRequerida
{
    static void Main()
    {
        //Declaracion de Variables
        String mensaje="Programa que calcula una formula";
        double  x = 0, y = 0, z = 0, w = 0, formula=0;

        //Pantalla
        Console.Clear();
        Console.WriteLine(mensaje);

        //Entrada de Datos
        Console.Write("\nIntroduzca un número real: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("\nIntroduzca un segundo número real: ");
        y = double.Parse(Console.ReadLine());

        Console.Write("\nIntroduzca un tercer número real: ");
        z = double.Parse(Console.ReadLine());

        Console.Write("\nIntroduzca un cuarto número real: ");
        w = double.Parse(Console.ReadLine());

        //Proceso
        formula = ((0.045 * x + 2.33 * y) / (2.1 * Math.Pow(z,(x + ((7.3 * w)/(9.2 * z - x * y)))) - z/w * 4.5)) * x * y * z * w;


        //Salida
        Console.WriteLine("\nEl Resultado es {0}",formula);
        Console.ReadLine();
    
    }
}