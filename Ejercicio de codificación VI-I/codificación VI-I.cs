using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_VI_I
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación VI-I: Crear una aplicación que cargue un vector de 5 códigos validos. Los códigos ingresaran por teclado.

            int[] vector = new int[5];

            Console.WriteLine("\nVECTOR");
            Console.WriteLine("");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("INGRECE VALOR#{0}: ", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nRESULTADOS");
            Console.WriteLine("");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("VALOR#{0} = {1}", i, vector[i]);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
