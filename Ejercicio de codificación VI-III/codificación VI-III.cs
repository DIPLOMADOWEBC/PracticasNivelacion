using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_VI_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación VI-III: Escriba un programa en C# que llene esta tabla con nombres de personas. La información se visualizará de la misma manera con dos bucles.

            string[,] nombres = new string[2, 3];
            int sum = 0;

            Console.WriteLine("\nARREGLO BIDIMENCIONAL ");
            Console.WriteLine("");

            nombres[0, 0] = "Juan";
            nombres[0, 1] = "Carlos";
            nombres[0, 2] = "Daniel";

            nombres[1, 0] = "Jose";
            nombres[1, 1] = "Miguel";
            nombres[1, 2] = "Antonio";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(nombres[i, j] + " ");
                }
            }

            Console.ReadKey();
            #endregion

        }
    }
}
