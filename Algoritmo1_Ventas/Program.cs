/* Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:
 * ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
 * ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
 * ¿Cuál fue la venta que le generó la mayor comisión?
 * ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
  Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde indique si ganó o no el beneficio.*/

public class Program
{
    private static void Main(string[] args)
    {
        const decimal sueldoBasico = 1300000;
        decimal comisionTotal;
        decimal sueldoTotal;


        Console.Write("Ingrese el valor de su primer venta: ");
        decimal venta1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el valor de su segunda venta: ");
        decimal venta2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese el valor de su tercer venta: ");
        decimal venta3 = Convert.ToDecimal(Console.ReadLine());



    }
}