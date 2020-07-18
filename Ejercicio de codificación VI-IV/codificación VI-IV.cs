using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_VI_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación VI-IV: Crear un programa que sume dos matrices, la matriz A y la matriz B.Imprimir la matriz resultante

            int[,] matrisA = new int[2, 2];
            int[,] matrisB = new int[2, 2];
            int[,] matrisSum = new int[2, 2];


            Console.WriteLine("\nARREGLO BIDIMENCIONAL ");
            Console.WriteLine("");

            //MATRIS A
            matrisA[0, 0] = 5;
            matrisA[0, 1] = 10;

            matrisA[1, 0] = 15;
            matrisA[1, 1] = 20;

            //MATRIS B
            matrisB[0, 0] = 30;
            matrisB[0, 1] = 25;

            matrisB[1, 0] = 20;
            matrisB[1, 1] = 15;

            Console.WriteLine("MATRIS A");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrisA[i, j] + " ");
                }
            }
            Console.WriteLine("MATRIS B");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrisB[i, j] + " ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("SUMA DE MATRIS A + B");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 2; j++)
                {
                    matrisSum[i, j] = (matrisA[i, j] + matrisB[i, j]);
                    Console.WriteLine(matrisSum[i, j] + " ");
                }
            }

            Console.ReadKey();
            #endregion
        }
    }
}
