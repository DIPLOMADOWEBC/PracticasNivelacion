using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación II-VI: Crear un programa en C# que calcule la cuota (c) de un préstamo simple. El monto (m) de préstamo, interés (i) y el tiempo(t) ingresaran por teclado. Formula: c = ((m * i) / t) + (m / t)
            double monto, interes, tiempo, cuota;
            Console.WriteLine("*** CALCULO DE CUOTAS/PRESTAMO ***");
            Console.WriteLine("\n");

            Console.Write("DIGITE EL MONTO: ");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE EL INTERES: ");
            interes = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE EL TIEMPO EN MESES: ");
            tiempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("*** DETALLE ***");
            Console.WriteLine("");
            Console.WriteLine("");
            //Formula: c = ((m * i) / t) + (m / t)
            cuota = ((monto * interes) / tiempo) + (monto / tiempo);
            Console.WriteLine("La cuota a pagar es: {0}", cuota);
            Console.ReadKey();
            #endregion
        }
    }
}
