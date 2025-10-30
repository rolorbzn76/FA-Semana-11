using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 15, 10, 20, 17, 8, 13, 19 };
            int suma = 0, canAprobados = 0, canDesaprobados = 0;
            int mayor = n[0], menor = n[0];
            double promedio;
            // Recorremos el arreglo desde la posición 0 hasta el final
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"n[{i}] = {n[i]}");
                suma += n[i];
                // Calculamos la cantidad de aprobados y desaprobados
                if (n[i] >= 12)
                    canAprobados++;
                else
                    canDesaprobados++;
                // Calculamos la mayor nota
                if (n[i] > mayor)
                    mayor = n[i];
                // Calculamos la menor nota
                if (n[i] < menor)
                    menor = n[i];
            }
            promedio = 1.0*suma / n.Length;
            Console.WriteLine($"\nSuma: {suma}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Número de aprobados: {canAprobados}");
            Console.WriteLine($"Número de desaprobados: {canDesaprobados}");
            Console.WriteLine($"Mayor nota: {mayor}");
            Console.WriteLine($"Menor nota: {menor}");
        }
    }
}
