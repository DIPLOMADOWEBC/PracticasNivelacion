using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_IV
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Ejercicio de codificación II-IV: Escribir un programa que C# que calcule sueldo bruto (SB), sueldo neto (SN) y descuento (DD). Las tarifas por horas(HT) y horas trabajadas(TH) ingresan por teclado.El descuento aplicar a todos los sueldos calculados es del 10 %.Imprimir sueldo bruto, descuento y sueldo neto.
           double sueldoBT, sueldoNT, descuento, tarifasxHT, horasTH;

           Console.Write("CALCULO DE SALARIO");
           Console.WriteLine("\n");
           Console.Write("Cantidad de horas trabajadas: ");
           horasTH = Convert.ToDouble(Console.ReadLine());
           Console.Write("Tarifa de horas trabajadas: ");
           tarifasxHT = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("\n");
           Console.WriteLine("*** DETALLE ***");
           Console.WriteLine("________________________");
           Console.WriteLine("");

           sueldoNT = (horasTH * tarifasxHT);
           descuento = (sueldoNT * 0.10);
           sueldoBT = (sueldoNT + descuento);

           Console.WriteLine("SUELDO BRUTO: {0}",sueldoBT);
           Console.WriteLine("DESCUENTO: {0}",descuento);
           Console.WriteLine("SUELDO NETO: {0}",sueldoNT);
           Console.ReadKey();
            #endregion
        }
    }
}
