﻿/* Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:
 * ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
 * ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
 * ¿Cuál fue la venta que le generó la mayor comisión?
 * ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
  Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio.*/

using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        const decimal sueldoBasico = 1300000;
        decimal comisionTotal;
        decimal sueldoTotal;
        decimal beneficioExtra = 100000;
        decimal objetivosMes = 1000000;
        decimal comisionMayor;
        
        Console.Write("Ingrese el valor de su primer venta: ");
        decimal venta1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el valor de su segunda venta: ");
        decimal venta2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el valor de su tercer venta: ");
        decimal venta3 = Convert.ToDecimal(Console.ReadLine());

        decimal comision1 = (venta1 * 10 / 100);
        decimal comision2 = (venta2 * 10 / 100);
        decimal comision3 = (venta3 * 10 / 100);
        comisionTotal = comision1 + comision2 + comision3;
        sueldoTotal = sueldoBasico + comisionTotal;

        Console.WriteLine($"El valor de las comisiones recibidas por la venta 1 son de :{comision1:C0}, por la venta 2 son de :{comision2:C0}, y por la venta 3 son de :{comision3:C0}");
        Console.WriteLine($"Su sueldo total es de : {sueldoTotal:C0}");

        if (venta1 > venta2 && venta1 > venta3)
        {
            Console.WriteLine($"La venta que le genero mayor comision es: {comisionMayor = venta1:C0}");
        }
        else if (venta2 > venta1 && venta2 > venta3)
        {
            Console.WriteLine($"La venta que le genero mayor comision es: {comisionMayor = venta2:C0}");
        }
        else
        {
            Console.WriteLine($"La venta que le genero mayor comision es: {comisionMayor = venta3:C0}");
        }

        decimal promedioComisiones = (comisionTotal / 3);
        Console.WriteLine($"El valor promedio de las comisiones recibidas este mes es de {promedioComisiones:C0}");

        if ((venta1 + venta2 + venta3) >= objetivosMes) ;
        {
            Console.WriteLine($"Este mes tienes un beneficio extra de : {beneficioExtra:C0} por superar el objetivo de ventas mensual");
        }
    }
}