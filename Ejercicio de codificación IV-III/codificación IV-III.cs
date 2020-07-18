using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_IV_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación IV-III: Un programa que muestre los números del 3 al 20 con su cubo al lado.

            Console.WriteLine("\nNUMEROS 3 AL 20");
            Console.WriteLine("");
            for (int i = 3; i <= 20; i++)
            {
                Console.WriteLine($"EL CUBO DE {i} = {Math.Pow(i, 3)}");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
