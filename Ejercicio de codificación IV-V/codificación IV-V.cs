using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_IV_V
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación IV-V: Un programa que muestre todas las tablas de multiplicar, esto es, la del 1, 2, 3,4.Hasta el 12 usando dos bucles anidados.

            int resul = 0;
            Console.WriteLine("\nTABLAS DE MULTIPLICACION");
            Console.WriteLine("");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("\nTABLA DEL {0}", i);
                for (int j = 1; j <= 12; j++)
                {
                    resul = (i * j);
                    Console.WriteLine($"{i} x {j} = {resul}");
                }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
