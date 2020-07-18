using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_codificación_II_III
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio de codificación II-III: Escribir un programa en C# que ingrese el nombre de un producto, el precio y la cantidad. El programa calculará el ITBIS que es del 18 %.Imprimir el sub total, el monto de itbis y el total a pagar.
            string nombreProducto;
            double precio, subtotal,total,ibtis;
            int cantidad;

            Console.Write("PUNTO DE VENTA");
            Console.WriteLine("\n");
            Console.Write("DIGITE EL NOMBRE DEL PRODUCTO: ");
            nombreProducto = Console.ReadLine();
            Console.Write("DIGITE EL PRECIO: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("DIGITE LA CANTIDAD: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("*** DETALLE ***");
            Console.WriteLine("________________________");
            Console.WriteLine("");

            subtotal = (precio * cantidad);
            ibtis = (subtotal * 0.18);
            total = (subtotal + ibtis);

            Console.WriteLine("SUBTOTAL: " + subtotal);
            Console.WriteLine("IBTIS: " + ibtis);
            Console.WriteLine("TOTAL: " + total);
            Console.ReadKey();
            #endregion
        }
    }
}
