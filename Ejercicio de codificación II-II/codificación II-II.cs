using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_II
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación II-II: Crear una aplicación en C# que calcule promedio de cuatro notas. Las variables a utilizar son nota enero, nota febrero, nota marzo, nota abril y promedio.
            decimal notaEnero, notaFebrero, notaMArzo, notaAbril, promedio;
            Console.WriteLine("*** CALCULO DE NOTAS ***");
            Console.WriteLine("\n");
            Console.Write("Digite nota enero: ");
            notaEnero = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite nota febrero: ");
            notaFebrero = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite nota marzo: ");
            notaMArzo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite nota abril: ");
            notaAbril = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n");
            promedio = (notaEnero + notaFebrero + notaMArzo + notaAbril) / 4;

            Console.Write("EL promedio es {0}: ",promedio);
            Console.ReadKey();
            #endregion
        }
    }
}
