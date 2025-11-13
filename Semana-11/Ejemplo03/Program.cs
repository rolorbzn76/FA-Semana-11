using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de tamaño ingresado por el usuario y generar valores aleatorios.
            // Luego determine el promedio, la mayor nota y la menor nota

            // int[]n = new int[10];
            int[] n;
            int tamanio, canAprobados = 0, canDesaprobados = 0, mayor, menor;
            double prom;

            Console.WriteLine("Número de elementos: ");
            tamanio = int.Parse(Console.ReadLine());
            
            n = new int[tamanio];
            // Llamada a métodos void
            generarAleatorios(n);
            imprimirResultados(n);
            // Llamada a métodos con retorno
            prom = calcularPromedio(n);
            mayor = calcularMayor(n);
            menor = calcularMenor(n);
            canAprobados = calcularAprobados(n);
            canDesaprobados = calcularDesaprobados(n);
            // Llamamos a la función void
            imprimirResultados(prom, mayor, menor, canAprobados, canDesaprobados);
        }
        // Función que imprime resultados
        static void imprimirResultados(double prom, int mayor, int menor, int canAprobados, int canDesaprobados)
        {
            Console.WriteLine($"Promedio: {prom}");
            Console.WriteLine($"Mayor nota: {mayor}");
            Console.WriteLine($"Menor nota: {menor}");
            Console.WriteLine($"Aprobados: {canAprobados}");
            Console.WriteLine($"Desaprobados: {canDesaprobados}");
        }
        // Función que genera aleatorios para el arreglo
        static void generarAleatorios(int[] n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(0, 21);
            }
        }
        // Función que imprime los datos del arreglo
        static void imprimirResultados(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"n[{i}] = {n[i]}");
            }
        }
        // Función que calcula y retorna el promedio
        static double calcularPromedio(int[] n)
        {
            int suma = 0;
            double promedio;
            for (int i = 0;i < n.Length;i++)
            {
                suma += n[i];
            }
            promedio = 1.0*suma / n.Length;
            
            return promedio;
        }
        // Función que calcula y retorna el mayor
        static int calcularMayor(int[] n)
        {
            int mayor = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > mayor)
                    mayor = n[i];
            }

            return mayor;
        }

        // Función que calcula y retorna el menor
        static int calcularMenor(int[] n)
        {
            int menor = n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < menor)
                    menor = n[i];
            }

            return menor;
        }
        // Función que calcula y retorna la cantidad de aprobados
        static int calcularAprobados(int[] n)
        {
            int canAprobados = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 12)
                    canAprobados++;
            }

            return canAprobados;
        }
        // Función que calcula y retorna la cantidad de desaprobados
        static int calcularDesaprobados(int[] n)
        {
            int canDesaprobados = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < 12)
                    canDesaprobados++;
            }

            return canDesaprobados;
        }
    }
}
