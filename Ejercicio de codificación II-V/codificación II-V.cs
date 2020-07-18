using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_V
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación II-V: Escriba un programa que convierta de centímetros a pulgadas.Una pulgada es igual a 2.54 centímetros.Los centímetros ingresan por teclado.
            double valorPulgada = 2.95, centimetro, pulgadas;
            Console.Write("CONVERSOR DE CENTIMETROS A DECIMAL");
            Console.WriteLine("\n");

            Console.Write("Digite cantidad de centimetros: ");
            centimetro = Convert.ToDouble(Console.ReadLine());
            pulgadas = (valorPulgada * centimetro);
            Console.WriteLine("\n");
            Console.Write("{0} centimetros son iguales a {1} pulgadas", centimetro, pulgadas);
            Console.ReadKey();
            #endregion
        }
    }
}
