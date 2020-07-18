using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_IV_II
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación IV-II: Un programa que muestre los números del 100 al 105

            Console.WriteLine("\nNUMEROS 100 AL 105");
            Console.WriteLine("");
            for (int i = 100; i <= 105; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadKey();
            #endregion

        }
    }
}
