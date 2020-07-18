using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_VI_II
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación VI-II: Crear una aplicación que calcule e imprima la sumatoria de los elementos de un vector.Los elementos ingresarán por teclado.

            int[] vector = new int[5];
            int sum = 0;

            Console.WriteLine("\nVECTOR");
            Console.WriteLine("");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("INGRECE VALOR#{0}: ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
                sum += vector[i];
            }
            Console.WriteLine("");
            Console.Write("\nSUMATORIA TOTAL: {0}", sum);

            Console.ReadKey();
            #endregion
        }
    }
}
