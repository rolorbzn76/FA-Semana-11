using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma, tamanio;
            int[] n = { 15, 10, 20, 17, 8, 13};
            double[] sueldos = { 1500.00, 1800.5, 2000.54, 3001.00 }; 

            suma = n[0] + n[1] + n[2] + n[3] + n[4];
            // La propiedad Length obtiene la cantidad de elementos del arreglo
            tamanio = n.Length;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Longitud: {tamanio}");
        }
    }
}
