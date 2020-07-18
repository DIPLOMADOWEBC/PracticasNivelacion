using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_IV_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación IV-IV: Un programa que muestre la tabla de multiplicar del número 4

            int resul = 0;
            Console.WriteLine("\nTABLA DE MULTIPLICAR DEL 4");
            Console.WriteLine("");
            for (int i = 1; i <= 12; i++)
            {
                resul = (4 * i);
                Console.WriteLine($"{4} x {i} = {resul}");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
