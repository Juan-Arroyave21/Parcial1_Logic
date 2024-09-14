﻿/* Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y muestre la solución.
 * Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b / a */
public class Program
{
    private static void Main(string[] args)
    {
        decimal a, b;

        Console.Write("Ingrese el coeficiente a: ");
        a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el coeficiente b: ");
        b = Convert.ToDecimal(Console.ReadLine());
 
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("La ecuación tiene infinitas soluciones.");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución.");
            }
        }
        else
        {
            decimal x = -b / a;
            Console.WriteLine("La solución es x = " + x);
        }
    }
}
