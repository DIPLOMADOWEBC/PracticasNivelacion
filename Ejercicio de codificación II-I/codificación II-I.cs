using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_I
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación II-I: Escriba un programa que pida al usuario que escriba su nombre, y lo salude llamándolo por su nombre.
            string nombre;            Console.Write("Introduzca su nombre: ");            //Console.WriteLine("__________________________________");            nombre = Console.ReadLine();            Console.WriteLine(" ");            Console.WriteLine("Saludos Sr. " + nombre);
            Console.ReadKey();
            #endregion
        }
    }
}
