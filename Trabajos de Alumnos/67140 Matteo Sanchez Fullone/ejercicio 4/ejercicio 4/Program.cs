using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] costos = { 10, 25, 50, 80, 120 };

            Console.Write("Ingrese la cantidad de gemas que tiene: ");
            int gemas = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Menú Tienda de Cartas ---");
            Console.WriteLine("1. Mostrar cartas que puede pagar");
            Console.WriteLine("2. Identificar la carta más cara del catálogo");
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nCartas que puede pagar:");
                    bool algunaAlcanzo = false;
                    for (int i = 0; i < costos.Length; i++)
                    {

                        if (gemas >= costos[i])
                        {
                            Console.WriteLine($"Carta {i + 1}: {costos[i]} gemas");
                            algunaAlcanzo = true;
                        }
                    }
                    if (!algunaAlcanzo)
                    {
                        Console.WriteLine("No puede pagar ninguna carta.");
                    }
                    break;

                case 2:
                    int indiceMasCara = 0;
                    for (int i = 1; i < costos.Length; i++)
                    {

                        if (costos[i] > costos[indiceMasCara])
                        {
                            indiceMasCara = i;
                        }
                    }
                    Console.WriteLine($"\nLa carta más cara es la Carta {indiceMasCara + 1} con {costos[indiceMasCara]} gemas.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
    

